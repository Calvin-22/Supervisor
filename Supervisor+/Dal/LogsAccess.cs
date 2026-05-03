using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supervisor.Model; 

namespace Supervisor.Dal
{
    class LogsAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public LogsAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les logs
        /// </summary>
        /// <returns>liste des erreurs</returns>
        public List<Logs> GetLesLogs()
        {
            List<Logs> lesLogs = new List<Logs>();

            if (access.Manager != null)
            {
                string req = "SELECT idAcces, Date_heure_entree, Resultat_tentative, " +
                             "Date_heure_sortie, Presence, Etat_porte, idUser, UID " +
                             "FROM acces_log " +
                             "ORDER BY Date_heure_entree DESC";

                try
                {
                    List<object[]> records = access.Manager.ReqSelect(req);

                    if (records != null)
                    {
                        foreach (object[] record in records)
                        {
                            int idAcces = Convert.ToInt32(record[0]);
                            DateTime dateEntree = Convert.ToDateTime(record[1]);
                            string resultat = (string)record[2];

                            // Gestion du NULL MySQL → C#
                            DateTime? dateSortie = record[3] == DBNull.Value
                                ? (DateTime?)null
                                : Convert.ToDateTime(record[3]);

                            int presence = Convert.ToInt32(record[4]);
                            int etatPorte = Convert.ToInt32(record[5]);
                            int idUser = Convert.ToInt32(record[6]);
                            string uid = (string)record[7];

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

                            lesLogs.Add(log);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur GetLesLogs : " + e.Message);
                }
            }
            return lesLogs;
        }
    }

}
