
using System.ComponentModel;
using System.Data;
using System.Reflection;
using Supervisor.Controller;
using Supervisor.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;






namespace Supervisor.View
{
    public partial class FrmMenuPrincipal : Form
    {
        // Timer pour la supervision en temps réel
        System.Windows.Forms.Timer timerSupervision;
        System.Windows.Forms.Timer timerProgress;

        // Variable pour éviter les notifications d'effraction multiples si plusieurs logs consécutives indiquent une effraction
        private bool effractionEnCours = false;

        /// <summary>
        /// Variables pour la détection de porte ouverte prolongée (+10s) avec anti-spam (une seule alerte envoyée tant que la porte reste ouverte)
        /// </summary>
        private DateTime? heureDernierLogPorteOuverte = null;
        private bool alertePorteOuverteEnvoyee = false;
        private const int SEUIL_PORTE_OUVERTE_SECONDES = 10; // seuil de 10 secondes pour l'alerte de porte ouverte trop longtemps

        /// <summary>
        /// Variables pour la détection d'effraction nocturne : on considère comme suspect toute tentative d'accès avec porte ouverte entre 22h00 et 06h00
        /// </summary>
        private readonly TimeSpan heureDebutSuspecte = new TimeSpan(22, 0, 0); // 22h00
        private readonly TimeSpan heureFinSuspecte = new TimeSpan(6, 0, 0);   // 06h00
        private bool alerteComportementSuspectEnvoyee = false;


        // Dernière date de log connue pour détecter les nouvelles entrées automatiquement
        private DateTime derniereDateConnue = DateTime.MinValue;

        /// <summary>
        /// Objet pour gérer la liste des mutations
        /// </summary>
        private BindingSource bdglogs = new BindingSource();

        private FrmLogsController controller;

        public FrmMenuPrincipal()
        {
            InitializeComponent();

            // Activation du double buffered pour la fluidité du défilement du dgvMutation
            typeof(DataGridView).InvokeMember("DoubleBuffered",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
            null, dgvlogs, new object[] { true });

            timerSupervision = new System.Windows.Forms.Timer();

            // Appel de la méthode d'initialisation
            Init();
        }

        /// <summary>
        /// Initialisations
        /// </summary>
        private void Init()
        {
            controller = new FrmLogsController();
            RemplirListeLogs();
            StatistiquesLogs();

            // Supervision initiale
            var derniere = controller.GetDerniereLog();
            if (derniere != null)
            {
                derniereDateConnue = derniere.Date_heure_entree;
                MettreAJourEtatLocal(derniere);
            }

            // Initialisation du ComboBox pour le filtre Résultat
            cbResultat.Items.Add("Tous");
            cbResultat.Items.Add("ACCES");
            cbResultat.Items.Add("REFUS");
            cbResultat.SelectedIndex = 0;

            // Abonnement à l'événement de changement de sélection du ComboBox
            cbResultat.SelectedIndexChanged += cbResultat_SelectedIndexChanged;


            // Abonnement à l'événement de formatage des cellules du DataGridView pour formater la colonne "Etat de la porte"
            dgvlogs.CellFormatting += dgvlogs_CellFormatting;

            // Démarrage du timer pour la supervision en temps réel
            timerSupervision.Interval = 3000; // 3 secondes
            timerSupervision.Tick += TimerSupervision_Tick;
            timerSupervision.Start();

            lblEtatSysteme.Text = "Système opérationnel et sécurisé";
            lblEtatSysteme.ForeColor = Color.Green;
            InitProgressBar();
        }

        /// <summary>
        /// Méthode appelée à chaque tick du timer pour superviser les nouvelles entrées de logs en temps réel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerSupervision_Tick(object sender, EventArgs e)
        {
            var derniere = controller.GetDerniereLog();
            if (derniere == null) return;

            // Message de debug pour vérifier la fréquence des requêtes SQL (visible dans la fenêtre "Sortie" de Visual Studio)
            System.Diagnostics.Debug.WriteLine("Requête SQL envoyée : " + DateTime.Now.ToString("HH:mm:ss.fff"));


            // Si nouvelle log détectée
            if (derniere.Date_heure_entree > derniereDateConnue)
            {
                derniereDateConnue = derniere.Date_heure_entree;

                // Mise à jour de l'état du local
                MettreAJourEtatLocal(derniere);

                // Ajout dans le DataGridView
                AjouterNouvelleLog(derniere);

                // Mise à jour des statistiques
                StatistiquesLogs();
            }

            // Détection d’effraction avec anti-spam
            if (EstEffraction(derniere))
            {
                if (!effractionEnCours)
                {
                    effractionEnCours = true;
                    // Changement de couleur du header du DataGridView pour indiquer une alerte
                    dgvlogs.ColumnHeadersDefaultCellStyle.BackColor = Color.Firebrick;
                    dgvlogs.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Firebrick;
                    // Changement de logo pour indiquer une alerte
                    LogoSupervisor.Image = logo_rouge.Image;
                    // Mise à jour du label d'état du système
                    lblEtatSysteme.Text = "Effraction détectée !";
                    lblEtatSysteme.ForeColor = Color.Firebrick;
                    NotifierEffraction(derniere);
                }
            }

            else if (derniere.Etat_porte == 0)
            {
                // Si tout est redevenu normal, on réarme le système
                effractionEnCours = false;
                dgvlogs.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
                dgvlogs.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkBlue;
                LogoSupervisor.Image = logo_bleu.Image;

                // Mise à jour du label d'état du système
                lblEtatSysteme.Text = "Système opérationnel et sécurisé";
                lblEtatSysteme.ForeColor = Color.Green;
            }


            if (!effractionEnCours)
            {
                // Gestion du temps d'ouverture de la porte
                if (derniere.Etat_porte == 1) // porte ouverte
                {
                    if (heureDernierLogPorteOuverte == null)
                    {
                        // La porte vient de s'ouvrir → on enregistre l'heure du log
                        heureDernierLogPorteOuverte = derniere.Date_heure_entree;
                        alertePorteOuverteEnvoyee = false;
                    }
                    else
                    {
                        // Porte toujours ouverte donc calcul de la durée depuis le dernier log "ouverte"
                        TimeSpan duree = DateTime.Now - heureDernierLogPorteOuverte.Value;

                        if (!alertePorteOuverteEnvoyee &&
                            duree.TotalSeconds >= SEUIL_PORTE_OUVERTE_SECONDES)
                        {

                            alertePorteOuverteEnvoyee = true;

                            // Changement de couleur du header du DataGridView pour indiquer une méfiance
                            dgvlogs.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
                            dgvlogs.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Goldenrod;
                            // Changement de logo pour indiquer une méfiance
                            LogoSupervisor.Image = logo_jaune.Image;

                            lblEtatSysteme.Text = "Comportement suspect détecté";
                            lblEtatSysteme.ForeColor = Color.Goldenrod;

                            NotifierPorteOuverteLongtemps(duree);
                        }
                    }
                }
                else if (derniere.Etat_porte == 0)
                {
                    // Porte fermée donc réarmement
                    heureDernierLogPorteOuverte = null;
                    alertePorteOuverteEnvoyee = false;

                    dgvlogs.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
                    dgvlogs.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkBlue;
                    LogoSupervisor.Image = logo_bleu.Image;

                    // Mise à jour du label d'état du système
                    lblEtatSysteme.Text = "Système opérationnel et sécurisé";
                    lblEtatSysteme.ForeColor = Color.Green;
                }
            }


            if (!effractionEnCours)
            {
                // Détection comportement suspect
                if (EstComportementSuspect(derniere))
                {
                    // Changement de couleur du header du DataGridView pour indiquer une méfiance
                    dgvlogs.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
                    dgvlogs.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Goldenrod;
                    // Changement de logo pour indiquer une méfiance
                    LogoSupervisor.Image = logo_jaune.Image;

                    lblEtatSysteme.Text = "Comportement suspect détecté";
                    lblEtatSysteme.ForeColor = Color.Goldenrod;

                    if (!alerteComportementSuspectEnvoyee)
                    {
                        alerteComportementSuspectEnvoyee = true;
                        NotifierComportementSuspect(derniere);
                    }
                }
                else if (derniere.Etat_porte == 0 &&
                    derniere.Date_heure_entree.TimeOfDay >= heureDebutSuspecte ||
                          derniere.Date_heure_entree.TimeOfDay <= heureFinSuspecte)
                {
                    // Réarmement si tout redevient normal
                    alerteComportementSuspectEnvoyee = false;
                    dgvlogs.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
                    dgvlogs.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkBlue;
                    LogoSupervisor.Image = logo_bleu.Image;

                    // Mise à jour du label d'état du système
                    lblEtatSysteme.Text = "Système opérationnel et sécurisé";
                    lblEtatSysteme.ForeColor = Color.Green;
                }
            }
        }

        private void InitProgressBar()
        {
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = 100;
            ProgressBar.Value = 0;

            timerProgress = new System.Windows.Forms.Timer();
            timerProgress.Interval = 30; // 30 ms → 100 ticks → 3 secondes
            timerProgress.Tick += TimerProgress_Tick;
            timerProgress.Start();
        }

        private void TimerProgress_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.Value < 100)
            {
                ProgressBar.Value += 1;
            }
            else
            {
                ProgressBar.Value = 0; // reset instantané
            }
        }


        /// <summary>
        /// Méthode pour ajouter une nouvelle log en haut du DataGridView (pour la supervision en temps réel)
        /// </summary>
        /// <param name="log"></param>
        private void AjouterNouvelleLog(Logs log)
        {
            var liste = bdglogs.List.Cast<Logs>().ToList();
            liste.Insert(0, log); // en haut du tableau

            bdglogs.DataSource = new SortableBindingList<Logs>(liste);
            dgvlogs.DataSource = bdglogs;
        }

        /// <summary>
        /// Méthode pour mettre à jour les labels d'état du local (porte, présence, dernier UID, résultat, date/heure) à partir d'une log
        /// </summary>
        /// <param name="log"></param>
        private void MettreAJourEtatLocal(Logs log)
        {
            lblPorte.Text = log.Etat_porte == 1 ? "Ouverte" : "Fermée";
            lblPresence.Text = log.Presence == 1 ? "Présence détectée" : "Aucune présence";
            lblDernierUID.Text = log.UID;
            lblDernierResultat.Text = log.Resultat_tentative;
            lblDernierEvenement.Text = log.Date_heure_entree.ToString("dd/MM/yyyy HH:mm:ss");

            lblPorte.BackColor = log.Etat_porte == 1 ? Color.OrangeRed : Color.LightGreen;
            lblPresence.BackColor = log.Presence == 1 ? Color.Gold : Color.LightGray;

            lblDernierResultat.BackColor =
                log.Resultat_tentative == "ACCES" ? Color.LightGreen : Color.LightCoral;
        }


        /// Méthode appelée lors du changement de sélection dans le ComboBox pour appliquer les filtres
        private void cbResultat_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppliquerFiltres();
        }

        /// Méthode pour appliquer les filtres sélectionnés et mettre à jour la DataGridView
        private void AppliquerFiltres()
        {
            var liste = controller.GetLesLogs();

            // Filtre Résultat
            if (cbResultat.SelectedItem.ToString() != "Tous")
            {
                string filtre = cbResultat.SelectedItem.ToString();
                liste = liste.Where(l => l.Resultat_tentative == filtre).ToList();
            }

            // Mise à jour du DataGridView
            bdglogs.DataSource = new SortableBindingList<Logs>(liste);
            dgvlogs.DataSource = bdglogs;

            StatistiquesLogs();

        }

        /// <summary>
        /// Méthode pour calculer et afficher les statistiques des logs de bases.
        /// </summary>
        private void StatistiquesLogs()
        {
            int total = bdglogs.Count;

            int autorises = bdglogs.List.Cast<Logs>()
                .Count(l => l.Resultat_tentative == "ACCES");

            int refuses = bdglogs.List.Cast<Logs>()
                .Count(l => l.Resultat_tentative == "REFUS");

            lblTotalTentatives.Text = total.ToString();
            lblAccesAutorise.Text = autorises.ToString();
            lblAccesRefuses.Text = refuses.ToString();
        }

        /// <summary>
        /// Méthode pour remplir la DataGridView avec les données des logs
        /// </summary>
        private void RemplirListeLogs()
        {
            // Récupération des données via le contrôleur
            List<Logs> lesLogs = controller.GetLesLogs();

            // Binding
            bdglogs.DataSource = new SortableBindingList<Logs>(lesLogs);

            dgvlogs.DataSource = bdglogs;

            // Tri automatique sur toutes les colonnes
            foreach (DataGridViewColumn col in dgvlogs.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            // Application des DisplayName du modèle Logs
            foreach (DataGridViewColumn col in dgvlogs.Columns)
            {
                var prop = TypeDescriptor.GetProperties(typeof(Logs))[col.DataPropertyName];
                if (prop != null)
                {
                    var displayNameAttr = prop.Attributes[typeof(DisplayNameAttribute)] as DisplayNameAttribute;
                    if (displayNameAttr != null)
                    {
                        col.HeaderText = displayNameAttr.DisplayName;
                    }
                }
            }

            // Ajustement automatique des colonnes
            dgvlogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ajustement spécifique pour les colonnes de date
            dgvlogs.Columns["Date_heure_entree"].FillWeight = 120;
            dgvlogs.Columns["Date_heure_sortie"].FillWeight = 120;

            // Scroll vertical uniquement
            dgvlogs.ScrollBars = ScrollBars.Vertical;
        }

        public class SortableBindingList<T> : BindingList<T>
        {
            private bool isSorted;
            private ListSortDirection sortDirection;
            private PropertyDescriptor sortProperty;

            public SortableBindingList() : base() { }

            public SortableBindingList(IList<T> list) : base(list) { }

            protected override bool SupportsSortingCore => true;
            protected override bool IsSortedCore => isSorted;
            protected override PropertyDescriptor SortPropertyCore => sortProperty;
            protected override ListSortDirection SortDirectionCore => sortDirection;

            protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
            {
                var items = (List<T>)Items;

                items.Sort((x, y) =>
                {
                    var xValue = prop.GetValue(x);
                    var yValue = prop.GetValue(y);

                    int result = Comparer<object>.Default.Compare(xValue, yValue);

                    // On applique le sens du tri
                    return direction == ListSortDirection.Ascending ? result : -result;
                });

                sortProperty = prop;
                sortDirection = direction;
                isSorted = true;

                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }

        }

        /// <summary>
        /// Méthode pour formater la colonne "Etat de la porte" en affichant "Ouverte" ou "Fermée" au lieu de 1 ou 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvlogs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string prop = dgvlogs.Columns[e.ColumnIndex].DataPropertyName;

            // --- État de la porte (0 = Fermée, 1 = Ouverte)
            if (prop == "Etat_porte")
            {
                if (e.Value is int etat)
                {
                    e.Value = etat == 1 ? "Ouverte" : "Fermée";
                    e.FormattingApplied = true;
                }
            }

            // --- Présence (0 = Non, 1 = Oui)
            if (prop == "Presence")
            {
                if (e.Value is int presence)
                {
                    e.Value = presence == 1 ? "Oui" : "Non";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnFiltrerDates_Click(object sender, EventArgs e)
        {
            FiltrerParDates();
        }

        private void FiltrerParDates()
        {
            DateTime debut = dtpDebut.Value.Date;
            DateTime fin = dtpFin.Value.Date.AddDays(1).AddTicks(-1);

            // Récupération de la liste ACTUELLEMENT affichée dans le DGV
            var listeAffichee = bdglogs.List.Cast<Logs>().ToList();

            // Application du filtre sur la liste affichée
            var resultat = listeAffichee
                .Where(l => l.Date_heure_entree >= debut && l.Date_heure_entree <= fin)
                .ToList();

            // Mise à jour du DataGridView
            bdglogs.DataSource = new SortableBindingList<Logs>(resultat);
            dgvlogs.DataSource = bdglogs;

            // Mise à jour des compteurs
            lblTotalTentatives.Text = resultat.Count.ToString();
            lblAccesAutorise.Text = resultat.Count(l => l.Resultat_tentative == "ACCES").ToString();
            lblAccesRefuses.Text = resultat.Count(l => l.Resultat_tentative == "REFUS").ToString();
        }


        private void BtnReset_Click(object sender, EventArgs e)
        {
            RemplirListeLogs();
            StatistiquesLogs();
            cbResultat.SelectedIndex = 0;
        }


        /// <summary>
        /// Bouton Rechercher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            FiltrerParUID();
        }

        /// <summary>
        /// Méthode pour filtrer les logs par UID (contenu dans TXT) à partir de la liste actuellement affichée
        /// </summary>
        private void FiltrerParUID()
        {
            string uidRecherche = txtRechercheUID.Text.Trim();

            if (string.IsNullOrWhiteSpace(uidRecherche))
                return;

            // Récupération de la liste ACTUELLEMENT affichée
            var listeAffichee = bdglogs.List.Cast<Logs>().ToList();

            // Filtre UID (contient)
            var resultat = listeAffichee
                .Where(l => !string.IsNullOrEmpty(l.UID) &&
                            l.UID.Contains(uidRecherche, StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Mise à jour du DataGridView
            bdglogs.DataSource = new SortableBindingList<Logs>(resultat);
            dgvlogs.DataSource = bdglogs;

            // Mise à jour des compteurs
            lblTotalTentatives.Text = resultat.Count.ToString();
            lblAccesAutorise.Text = resultat.Count(l => l.Resultat_tentative == "ACCES").ToString();
            lblAccesRefuses.Text = resultat.Count(l => l.Resultat_tentative == "REFUS").ToString();

            txtRechercheUID.Clear();
        }

        private void switchCouleur_StateChanged(object sender, SiticoneNetCoreUI.StateChangedEventArgs e)
        {
            if (switchCouleur.Checked)
            {
                // Active la colorisation
                dgvlogs.CellFormatting += dgvlogs_CellFormatting_Couleurs;

                // Force un redraw
                dgvlogs.Refresh();
            }
            else
            {
                // Désactive la colorisation
                dgvlogs.CellFormatting -= dgvlogs_CellFormatting_Couleurs;

                // Remet tout en blanc
                foreach (DataGridViewRow row in dgvlogs.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }

                dgvlogs.Refresh();
            }
        }

        /// <summary>
        /// Méthode pour coloriser les lignes du DataGridView selon le résultat de la tentative d'accès (ACCES en vert, REFUS en rouge)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvlogs_CellFormatting_Couleurs(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvlogs.Rows[e.RowIndex].DataBoundItem is Logs log)
            {
                // Colorisation selon le résultat
                if (log.Resultat_tentative == "ACCES")
                {
                    dgvlogs.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dgvlogs.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (log.Resultat_tentative == "REFUS")
                {
                    dgvlogs.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Coral;
                    dgvlogs.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        /// <summary>
        /// Bouton pour ajouter une log aléatoire (pour tester la supervision en temps réel et les statistiques)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjouterLogAleatoire_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int idAcces = rnd.Next(1, 999999);
            DateTime dateEntree = DateTime.Now;
            string resultat = rnd.Next(2) == 0 ? "ACCES" : "REFUS";
            DateTime? dateSortie = null;
            int presence = rnd.Next(2);
            int etatPorte = rnd.Next(2);
            int idUser = rnd.Next(1, 5);

            // UID NFC aléatoire (8 hex)
            string uid = "";
            const string hex = "0123456789ABCDEF";
            for (int i = 0; i < 8; i++)
                uid += hex[rnd.Next(hex.Length)];

            // Création du modèle Logs
            Logs log = new Logs(
                idAcces,
                dateEntree,
                resultat,
                dateSortie,
                presence,
                etatPorte,
                idUser,
                uid
            );

            // Envoi au controller → DAL → SQL
            controller.AjouterLog(log);

            // Mise à jour interface
            AjouterNouvelleLog(log);
            StatistiquesLogs();
        }


        /// <summary>
        /// Bouton pour exporter les données affichées dans le DataGridView vers un fichier PDF en utilisant la bibliothèque iTextSharp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Fichiers PDF (*.pdf)|*.pdf";
                sfd.Title = "Exporter en PDF";
                sfd.FileName = "Export.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportDataGridViewToPdf(dgvlogs, sfd.FileName);
                }
            }
        }

        /// <summary>
        /// Exporte le DataGridView vers un fichier PDF.
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="filePath"></param>
        private void ExportDataGridViewToPdf(DataGridView dgv, string filePath)
        {
            var pdfDoc = new Document(
                PageSize.A4.Rotate(),
                10f, 10f, 10f, 10f
            );

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);
                pdfDoc.Open();

                // Colonnes visibles uniquement
                var colonnesVisibles = dgv.Columns
                    .Cast<DataGridViewColumn>()
                    .Where(c => c.Visible)
                    .ToList();

                PdfPTable table = new PdfPTable(colonnesVisibles.Count);
                table.WidthPercentage = 100;

                // En-têtes visibles
                foreach (var col in colonnesVisibles)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    table.AddCell(cell);
                }

                // Lignes visibles
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow || !row.Visible) continue;

                    foreach (var col in colonnesVisibles)
                    {
                        var cell = row.Cells[col.Index];

                        // On prend la valeur affichée à l'écran
                        string value = cell.FormattedValue?.ToString() ?? "";

                        table.AddCell(new Phrase(value));
                    }
                }

                pdfDoc.Add(table);
                pdfDoc.Close();
            }

            MessageBox.Show("PDF exporté avec succès !");
        }

        /// <summary>
        /// Méthode pour détecter une possible effraction : porte ouverte + badge refusé ou pas de lecture de badge
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        private bool EstEffraction(Logs log)
        {
            bool porteOuverte = log.Etat_porte == 1;
            bool badgeRefuse = log.Resultat_tentative == "REFUS";
            bool aucuneLectureBadge = string.IsNullOrWhiteSpace(log.UID);

            return porteOuverte && (badgeRefuse || aucuneLectureBadge);
        }

        /// <summary>
        /// Méthode pour notifier l'utilisateur en cas d'effraction détectée : affiche un message d'alerte clair et professionnel + joue un son d'alerte
        /// </summary>
        /// <param name="log"></param>
        private void NotifierEffraction(Logs log)
        {
            // Son d’alerte
            System.Media.SystemSounds.Exclamation.Play();

            // Message clair et professionnel
            string message =
                "EFFRACTION DÉTECTÉE\n\n" +
                $"Date : {log.Date_heure_entree:dd/MM/yyyy HH:mm:ss}\n" +
                $"Porte : {(log.Etat_porte == 1 ? "Ouverte" : "Fermée")}\n" +
                $"Résultat : {log.Resultat_tentative}\n" +
                $"UID : {(string.IsNullOrWhiteSpace(log.UID) ? "Aucun (ou inconnu)" : log.UID)}";

            MessageBox.Show(
                message,
                "Alerte de sécurité",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        /// <summary>
        /// Méthode pour notifier l'utilisateur si la porte est restée ouverte depuis trop longtemps (plus de 10 secondes) : affiche un message d'alerte clair et professionnel + joue un son d'alerte
        /// </summary>
        /// <param name="duree"></param>
        private void NotifierPorteOuverteLongtemps(TimeSpan duree)
        {
            System.Media.SystemSounds.Exclamation.Play();

            string message =
       "ALERTE : Porte ouverte depuis trop longtemps\n\n" +
       $"Porte ouverte depuis : {FormaterDuree(duree)}\n" +
       $"Dernier log d'ouverture : {heureDernierLogPorteOuverte:dd/MM/yyyy HH:mm:ss}";

            MessageBox.Show(
                message,
                "Alerte de sécurité",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        /// <summary>
        /// Méthode pour formater une durée (TimeSpan) en une chaîne lisible (ex : "12 secondes", "3 min 45 s", "1 h 20 min")
        /// </summary>
        /// <param name="duree"></param>
        /// <returns></returns>
        private string FormaterDuree(TimeSpan duree)
        {
            if (duree.TotalSeconds < 60)
                return $"{duree.TotalSeconds:F0} secondes";

            if (duree.TotalMinutes < 60)
                return $"{(int)duree.TotalMinutes} min {duree.Seconds} s";

            return $"{(int)duree.TotalHours} h {duree.Minutes} min";
        }

        /// <summary>
        /// Méthode pour déterminer si une tentative d'accès est suspecte en fonction de l'heure : on considère comme suspect toute tentative avec porte ouverte entre 22h00 et 06h00
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private bool EstHeureSuspecte(DateTime date)
        {
            TimeSpan heure = date.TimeOfDay;

            // Cas normal : 22h → minuit
            if (heure >= heureDebutSuspecte)
                return true;

            // Cas minuit → 6h
            if (heure <= heureFinSuspecte)
                return true;

            return false;
        }

        /// <summary>
        /// Méthode pour déterminer si une tentative d'accès est suspecte : porte ouverte + badge valide + présence détectée entre 22h00 et 06h00
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        private bool EstComportementSuspect(Logs log)
        {
            bool badgeValide = log.Resultat_tentative == "ACCES";

            return badgeValide && EstHeureSuspecte(log.Date_heure_entree);
        }

        /// <summary>
        /// Méthode pour notifier l'utilisateur en cas de comportement suspect détecté : affiche un message d'alerte clair et professionnel + joue un son d'alerte
        /// </summary>
        /// <param name="log"></param>
        private void NotifierComportementSuspect(Logs log)
        {
            System.Media.SystemSounds.Exclamation.Play();

            string message =
                "COMPORTEMENT SUSPECT\n\n" +
                $"Accès légitime mais à une heure inhabituelle\n" +
                $"Heure : {log.Date_heure_entree:dd/MM/yyyy HH:mm:ss}\n" +
                $"UID : {log.UID}\n" +
                $"Présence détectée : Oui\n" +
                $"Porte : Ouverte";

            MessageBox.Show(
                message,
                "Alerte comportement suspect",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        /// <summary>
        /// Bouton pour se déconnecter : ferme le formulaire actuel et retourne à l'écran d'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDéconnexion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Voulez-vous vraiment vous déconnecter ?",
        "Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                FrmAuthentification frm = new FrmAuthentification();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void BtnStatistiques_Click(object sender, EventArgs e)
        {
            OuvrirStats();
        }

        private void OuvrirStats()
        {
            // Création de la popup Statistiques
            Form popup = new Form();
            popup.Text = "Statistiques Supervisor+";
            popup.FormBorderStyle = FormBorderStyle.FixedDialog;
            popup.StartPosition = FormStartPosition.CenterScreen;
            popup.Size = new Size(1100, 1100);
            popup.TopMost = true;
            popup.Icon = this.Icon;

            // Layout principal : 2 colonnes, 2 lignes
            TableLayoutPanel layout = new TableLayoutPanel();
            layout.Dock = DockStyle.Fill;
            layout.ColumnCount = 2;
            layout.RowCount = 2;

            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 60));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 40));

            popup.Controls.Add(layout);

            // Récupération des données
            var logs = bdglogs.List.Cast<Logs>().ToList();

            int autorises = logs.Count(l => l.Resultat_tentative == "ACCES");
            int refuses = logs.Count(l => l.Resultat_tentative == "REFUS");

            var parUtilisateur = logs
                .GroupBy(l => l.IdUser)
                .ToDictionary(g => "User " + g.Key, g => g.Count());

            var parHeure = logs
                .GroupBy(l => l.Date_heure_entree.Hour)
                .ToDictionary(g => g.Key + "h", g => g.Count());

            // 1) Camembert Répartition
            var chartPie = new Chart();
            chartPie.Dock = DockStyle.Fill;
            chartPie.ChartAreas.Add(new ChartArea("A"));
            var s1 = new Series("Répartition");
            s1.ChartType = SeriesChartType.Pie;
            s1.Points.AddXY("Autorisés", autorises);
            s1.Points.AddXY("Refusés", refuses);
            chartPie.Series.Add(s1);
            chartPie.Titles.Add("Répartition des accès");
            chartPie.Titles[0].Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
            chartPie.Legends.Add(new Legend("L"));
            layout.Controls.Add(chartPie, 0, 0);

            // 2) Histogramme par utilisateur
            var chartUsers = new Chart();
            chartUsers.Dock = DockStyle.Fill;
            chartUsers.ChartAreas.Add(new ChartArea("A"));
            var s2 = new Series("Par utilisateur");
            s2.ChartType = SeriesChartType.Column;
            s2.BorderWidth = 2;

            foreach (var kvp in parUtilisateur)
                s2.Points.AddXY(kvp.Key, kvp.Value);

            chartUsers.Series.Add(s2);
            chartUsers.Titles.Add("Tentatives par utilisateur");
            chartUsers.Titles[0].Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
            chartUsers.Legends.Add(new Legend("L"));
            layout.Controls.Add(chartUsers, 1, 0);

            // 3) Courbe par heure (large en bas)
            var chartHeure = new Chart();
            chartHeure.Dock = DockStyle.Fill;
            chartHeure.ChartAreas.Add(new ChartArea("A"));
            var s3 = new Series("Par heure");
            s3.ChartType = SeriesChartType.Line;
            s3.BorderWidth = 3;
            s3.MarkerStyle = MarkerStyle.Circle;
            s3.MarkerSize = 7;

            foreach (var kvp in parHeure.OrderBy(k => k.Key))
                s3.Points.AddXY(kvp.Key, kvp.Value);

            chartHeure.Series.Add(s3);
            chartHeure.Titles.Add("Activité par heure (globale)");
            chartHeure.Titles[0].Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
            chartHeure.Legends.Add(new Legend("L"));
            layout.Controls.Add(chartHeure, 0, 1);
            layout.SetColumnSpan(chartHeure, 2); // >>> Le graphique du bas prend toute la largeur

            popup.Show();
        }

        private void BtnRasberry_Click(object sender, EventArgs e)
        {
            FrmSystemHealth frm = new FrmSystemHealth();
            frm.Show();
        }
    }
}
