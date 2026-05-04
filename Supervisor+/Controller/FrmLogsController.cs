using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supervisor.Dal;
using Supervisor.Model;

namespace Supervisor.Controller
{
    public class FrmLogsController
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly LogsAccess access;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public FrmLogsController()
        {
            access = new LogsAccess();
        }

        /// <summary>
        /// Récupère et retourne les logs
        /// </summary>
        /// <returns>liste des erreurs</returns>
        public List<Logs> GetLesLogs()
        {
            return access.GetLesLogs();
        }

        public Logs GetDerniereLog()
        {
            return access.GetDerniereLog();
        }

        public void AjouterLog(Logs log)
        {
            access.AjouterLog(log);
        }




    }
}
