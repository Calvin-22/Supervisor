using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Common;
using Supervisor.Controller;
using Supervisor.Model;





namespace Supervisor.View
{
    public partial class FrmMenuPrincipal : Form
    {
        // Timer pour la supervision en temps réel
        System.Windows.Forms.Timer timerSupervision;

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

            timerSupervision.Interval = 3000; // 3 secondes
            timerSupervision.Tick += TimerSupervision_Tick;
            timerSupervision.Start();

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

        /// <summary>
        /// Méthode pour se déconnecter et revenir à l'écran d'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Hide(); // cacher le formulaire précédent 
            FrmAuthentification frm = new FrmAuthentification(); // ouvrir nouveau formulaire
            frm.ShowDialog(); // ouverture 
            this.Close(); // fermeture du formulaire caché 
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

        private void siticoneButtonAdvanced2_Click(object sender, EventArgs e)
        {

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
                    dgvlogs.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                    dgvlogs.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (log.Resultat_tentative == "REFUS")
                {
                    dgvlogs.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Firebrick;
                    dgvlogs.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

    }
}
