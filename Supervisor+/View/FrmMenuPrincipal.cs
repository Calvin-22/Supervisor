using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        /// <summary>
        /// Objet pour gérer la liste des mutations
        /// </summary>
        private BindingSource bdglogs = new BindingSource();

        private FrmLogsController controller;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
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

            // Initialisation du ComboBox pour le filtre Résultat
            cbResultat.Items.Add("Tous");
            cbResultat.Items.Add("ACCES");
            cbResultat.Items.Add("REFUS");
            cbResultat.SelectedIndex = 0;

            // Abonnement à l'événement de changement de sélection du ComboBox
            cbResultat.SelectedIndexChanged += cbResultat_SelectedIndexChanged;

        }

        /// Méthode appelée lors du changement de sélection dans le ComboBox pour appliquer les filtres
        private void cbResultat_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppliquerFiltres();
        }

        /// Méthode pour appliquer les filtres sélectionnés et mettre à jour la DataGridView
        private void AppliquerFiltres()
        {
            var liste = controller.GetLesLogs(); // ou ta liste déjà chargée

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

        }
    }
}
