using Supervisor.Bdd_Manager;
using MySql.Data.MySqlClient;
using System.Media;

namespace Supervisor.Dal
{
    /// <summary>
    /// Singleton : classe d'accès à BddManager
    /// </summary>
    public class Access
    {
        /// <summary>
        /// chaine de connexion à la bdd
        /// </summary>
        private static readonly string connectionString = "server=localhost; user id=supervisor_admin@; " +
            "password=D5-66jdlqoa!%okà@d*; database=dbca25; SslMode=Required;";
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// Getter sur l'objet d'accès aux données
        /// </summary>
        public BddManager Manager { get; }

        /// <summary>
        /// Création unique de l'objet de type BddManager
        /// Arrête le programme si l'accès à la BDD a échoué
        /// </summary>
        private Access()
        {
            try
            {
                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Erreur : Connexion impossible à la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Teste la connexion à la base de données
        /// </summary>
        /// <returns></returns>
        public bool TesterConnexion()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Création d'une seule instance de la classe
        /// </summary>
        /// <returns></returns>
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }

    }
}
