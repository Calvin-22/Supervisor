using System;
using System.Collections.Generic;
using Supervisor.Model;
using MySql.Data.MySqlClient;
using Supervisor.Model.Supervisor.Model;

namespace Supervisor.Dal
{
    class SystemHealthAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public SystemHealthAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Ajoute un état système dans la table SystemHealth
        /// </summary>
        public SystemHealth AjouterEtat(SystemHealth health)
        {
            if (access.Manager != null)
            {
                string req = "INSERT INTO acces_systemhealth " +
                             "(CpuTemp, CpuLoad, RamUsage, DiskUsage, NetworkState, Voltage, CaseTemp, GlobalState, Timestamp) " +
                             "VALUES (@cpuTemp, @cpuLoad, @ram, @disk, @net, @volt, @caseTemp, @state, @ts)";

                Dictionary<string, object> p = new Dictionary<string, object>()
                {
                    { "@cpuTemp", health.CpuTemp },
                    { "@cpuLoad", health.CpuLoad },
                    { "@ram", health.RamUsage },
                    { "@disk", health.DiskUsage },
                    { "@net", health.NetworkState },
                    { "@volt", health.Voltage },
                    { "@caseTemp", health.CaseTemp },
                    { "@state", health.GlobalState },
                    { "@ts", health.Timestamp }
                };

                try
                {
                    access.Manager.ReqUpdate(req, p);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur AjouterEtat : " + e.Message);
                }
            }

            return health;
        }

        /// <summary>
        /// Récupère le dernier état système (supervision temps réel)
        /// </summary>
        public SystemHealth GetDernierEtat()
        {
            SystemHealth health = null;

            if (access.Manager != null)
            {
                string req = "SELECT CpuTemp, CpuLoad, RamUsage, DiskUsage, NetworkState, Voltage, CaseTemp, GlobalState, Timestamp " +
                             "FROM acces_systemhealth " +
                             "ORDER BY Timestamp DESC " +
                             "LIMIT 1";

                try
                {
                    List<object[]> records = access.Manager.ReqSelect(req);

                    if (records != null && records.Count > 0)
                    {
                        object[] r = records[0];

                        double cpuTemp = Convert.ToDouble(r[0]);
                        int cpuLoad = Convert.ToInt32(r[1]);
                        int ram = Convert.ToInt32(r[2]);
                        int disk = Convert.ToInt32(r[3]);
                        int net = Convert.ToInt32(r[4]);
                        double volt = Convert.ToDouble(r[5]);
                        double caseTemp = Convert.ToDouble(r[6]);
                        string state = (string)r[7];
                        DateTime timestamp = Convert.ToDateTime(r[8]);

                        health = new SystemHealth(cpuTemp, cpuLoad, ram, disk, net, volt, caseTemp, state, timestamp);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur GetDernierEtat : " + e.Message);
                }
            }

            return health;
        }
    }
}
