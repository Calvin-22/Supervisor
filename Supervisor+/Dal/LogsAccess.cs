using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
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

        /// <summary>
        /// Récupère la dernière entrée de acces_log (supervision temps réel)
        /// </summary>
        /// <returns>Dernière log ou null</returns>
        public Logs GetDerniereLog()
        {
            Logs log = null;

            if (access.Manager != null)
            {
                string req = "SELECT idAcces, Date_heure_entree, Resultat_tentative, " +
                             "Date_heure_sortie, Presence, Etat_porte, idUser, UID " +
                             "FROM acces_log " +
                             "ORDER BY Date_heure_entree DESC " +
                             "LIMIT 1";
                try
                {
                    List<object[]> records = access.Manager.ReqSelect(req);

                    if (records != null && records.Count > 0)
                    {
                        object[] record = records[0];

                        int idAcces = Convert.ToInt32(record[0]);
                        DateTime dateEntree = Convert.ToDateTime(record[1]);
                        string resultat = (string)record[2];

                        DateTime? dateSortie = record[3] == DBNull.Value
                            ? (DateTime?)null
                            : Convert.ToDateTime(record[3]);

                        int presence = Convert.ToInt32(record[4]);
                        int etatPorte = Convert.ToInt32(record[5]);
                        int idUser = Convert.ToInt32(record[6]);
                        string uid = (string)record[7];

                        log = new Logs(
                            idAcces,
                            dateEntree,
                            resultat,
                            dateSortie,
                            presence,
                            etatPorte,
                            idUser,
                            uid
                        );
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur GetDerniereLog : " + e.Message);
                }
            }
            return log;
        }

        /// <summary>
        /// Ajoute une log à la table acces_log
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public Logs AjouterLog(Logs log)
        {
            if (access.Manager != null)
            {
                string req = "INSERT INTO acces_log " +
                             "(idAcces, Date_heure_entree, Resultat_tentative, Date_heure_sortie, " +
                             "Presence, Etat_porte, idUser, UID) " +
                             "VALUES (@idAcces, @entree, @res, @sortie, @presence, @porte, @idUser, @uid)";

                Dictionary<string, object> p = new Dictionary<string, object>()
        {
            { "@idAcces", log.IdAcces },
            { "@entree", log.Date_heure_entree },
            { "@res", log.Resultat_tentative },
            { "@sortie", log.Date_heure_sortie },
            { "@presence", log.Presence },
            { "@porte", log.Etat_porte },
            { "@idUser", log.IdUser },
            { "@uid", log.UID }
        };

                try
                {
                    access.Manager.ReqUpdate(req, p);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur AjouterLog : " + e.Message);
                }
            }

            // On renvoie la log insérée
            return log;
        }


    }

}
