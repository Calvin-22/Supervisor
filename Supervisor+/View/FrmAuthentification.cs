using System.Media;
using Supervisor.Controller;
using Supervisor.Model;
using Supervisor.View;

namespace Supervisor.View
{
    public partial class FrmAuthentification : Form
    {

        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmAuthentificationController controller;

        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations : 
        /// Création du contrôleur
        /// </summary>
        private void Init()
        {
            controller = new FrmAuthentificationController();
        }


        private void BtnSeConnecter_Click(object sender, EventArgs e)
        {
            String login = txtIdentifiant.Text;
            String pwd = txtMdp.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Authentification authentification = new Authentification(login, pwd);
                if (controller.ControleAuthentification(authentification))
                {
                    this.Hide(); // cacher le formulaire précédent 
                    FrmMenuPrincipal frm = new FrmMenuPrincipal(); // ouvrir nouveau formulaire
                    frm.ShowDialog(); // ouverture 
                    this.Close(); // fermeture du formulaire caché 
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Identifiant ou mot de passe incorrect. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMdp.Clear();
                }
            }
        }

        /// <summary>
        /// Faux bouton afin de contourner les limitations du framework Siticone avec Winforms.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FakeAcceptButton_Click(object sender, EventArgs e)
        {
            BtnSeConnecter_Click(BtnSeConnecter, EventArgs.Empty);
        }


    }
}
