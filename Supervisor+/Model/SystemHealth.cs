using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supervisor.Model
{
    using System;
    using System.ComponentModel;

    namespace Supervisor.Model
    {
        public class SystemHealth
        {
            [DisplayName("Température CPU (°C)")]
            public double CpuTemp { get; set; }

            [DisplayName("Charge CPU (%)")]
            public int CpuLoad { get; set; }

            [DisplayName("RAM utilisée (%)")]
            public int RamUsage { get; set; }

            [DisplayName("Espace disque (%)")]
            public int DiskUsage { get; set; }

            [DisplayName("État réseau")]
            public int NetworkState { get; set; }

            [DisplayName("Tension (V)")]
            public double Voltage { get; set; }

            [DisplayName("Température boîtier (°C)")]
            public double CaseTemp { get; set; }

            [DisplayName("État général")]
            public string GlobalState { get; set; }

            [DisplayName("Horodatage")]
            public DateTime Timestamp { get; set; }

            public SystemHealth(double cpuTemp, int cpuLoad, int ramUsage, int diskUsage, int networkState, double voltage, double caseTemp, string globalState, DateTime timestamp)
            {
                CpuTemp = cpuTemp;
                CpuLoad = cpuLoad;
                RamUsage = ramUsage;
                DiskUsage = diskUsage;
                NetworkState = networkState;
                Voltage = voltage;
                CaseTemp = caseTemp;
                GlobalState = globalState;
                Timestamp = timestamp;
            }
        }
    }

}
