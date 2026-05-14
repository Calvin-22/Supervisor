using Supervisor.Dal;
using Supervisor.Model;
using Supervisor.Model.Supervisor.Model;

namespace Supervisor.Controller
{
    public class FrmSystemHealthController
    {
        private readonly SystemHealthAccess access;

        public FrmSystemHealthController()
        {
            access = new SystemHealthAccess();
        }

        /// <summary>
        /// Ajoute un état généré côté Vue, puis retourne le dernier état stocké
        /// </summary>
        public SystemHealth AjouterEtat(SystemHealth etatGenere)
        {
            access.AjouterEtat(etatGenere);
            return access.GetDernierEtat();
        }

        /// <summary>
        /// Récupère le dernier état (à l'ouverture)
        /// </summary>
        public SystemHealth GetDernierEtat()
        {
            return access.GetDernierEtat();
        }
    }
}
