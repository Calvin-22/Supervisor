using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
