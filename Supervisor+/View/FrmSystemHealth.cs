using System;
using System.Drawing;
using System.Windows.Forms;
using Supervisor.Controller;
using Supervisor.Model;
using Supervisor.Model.Supervisor.Model;

namespace Supervisor.View
{
    public partial class FrmSystemHealth : Form
    {
        private readonly FrmSystemHealthController controller;

        public FrmSystemHealth()
        {
            InitializeComponent();
            controller = new FrmSystemHealthController();

            ChargerDernierEtat();
        }

        /// <summary>
        /// Charge le dernier état stocké en BDD à l'ouverture
        /// </summary>
        private void ChargerDernierEtat()
        {
            var health = controller.GetDernierEtat();

            if (health != null)
                DisplayHealth(health);
            else
                lblGlobalState.Text = "Aucune donnée";
        }

        /// <summary>
        /// Génère un état aléatoire côté Vue
        /// </summary>
        private SystemHealth GenerateRandomHealth()
        {
            Random r = new Random();

            double cpuTemp = r.Next(45, 90);
            int cpuLoad = r.Next(0, 100);
            int ram = r.Next(20, 95);
            int disk = r.Next(40, 98);
            int net = r.Next(0, 3);
            double volt = Math.Round(4.7 + r.NextDouble() * 0.6, 2);
            double caseTemp = r.Next(30, 60);

            string state = "OK";
            if (cpuTemp > 75 || ram > 85 || disk > 90) state = "Warning";
            if (cpuTemp > 85 || disk > 95) state = "Critical";

            return new SystemHealth(cpuTemp, cpuLoad, ram, disk, net, volt, caseTemp, state, DateTime.Now);
        }

        /// <summary>
        /// Clic sur Rafraîchir : génère un état, l'envoie au controller, puis affiche le dernier état
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var generated = GenerateRandomHealth();
            var health = controller.AjouterEtat(generated);
            DisplayHealth(health);
        }

        /// <summary>
        /// Affiche les données dans les labels
        /// </summary>
        private void DisplayHealth(SystemHealth health)
        {
            ResetColors(); // remet tout à zéro avant d'appliquer les couleurs

            lblCpuTemp.Text = $"{health.CpuTemp} °C";
            lblCpuLoad.Text = $"{health.CpuLoad} %";
            lblRam.Text = $"{health.RamUsage} %";
            lblDisk.Text = $"{health.DiskUsage} %";
            lblNetwork.Text = GetNetworkStateText(health.NetworkState);
            lblVoltage.Text = $"{health.Voltage} V";
            lblCaseTemp.Text = $"{health.CaseTemp} °C";
            lblTimestamp.Text = health.Timestamp.ToString("dd/MM/yyyy HH:mm:ss");

            lblGlobalState.Text = health.GlobalState;

            // --- Colorisation globale ---
            switch (health.GlobalState)
            {
                case "OK":
                    lblGlobalState.BackColor = Color.LightGreen;
                    break;

                case "Warning":
                    lblGlobalState.BackColor = Color.Orange;
                   
                    ColorizeWarning(health);
                    break;
                case "Critical":
                    lblGlobalState.BackColor = Color.Red;
                    ColorizeCritical(health);
                    break;
            }
        }

        private void ResetColors()
        {
            lblCpuTemp.BackColor = Color.White;
            lblCpuLoad.BackColor = Color.White;
            lblRam.BackColor = Color.White;
            lblDisk.BackColor = Color.White;
            lblNetwork.BackColor = Color.White;
            lblVoltage.BackColor = Color.White;
            lblCaseTemp.BackColor = Color.White;
        }

        private void ColorizeWarning(SystemHealth h)
        {
            if (h.CpuTemp > 75)
                lblCpuTemp.BackColor = Color.Orange;

            if (h.CpuLoad > 80)
                lblCpuLoad.BackColor = Color.Orange;

            if (h.RamUsage > 85)
                lblRam.BackColor = Color.Orange;

            if (h.DiskUsage > 90)
                lblDisk.BackColor = Color.Orange;

            if (h.NetworkState == 2)
                lblNetwork.BackColor = Color.Orange;

            if (h.Voltage < 4.8)
                lblVoltage.BackColor = Color.Orange;

            if (h.CaseTemp > 50)
                lblCaseTemp.BackColor = Color.Orange;
        }

        private void ColorizeCritical(SystemHealth h)
        {
            if (h.CpuTemp > 85)
                lblCpuTemp.BackColor = Color.Red;

            if (h.CpuLoad > 95)
                lblCpuLoad.BackColor = Color.Red;

            if (h.RamUsage > 95)
                lblRam.BackColor = Color.Red;

            if (h.DiskUsage > 95)
                lblDisk.BackColor = Color.Red;

            if (h.NetworkState == 0)
                lblNetwork.BackColor = Color.Red;

            if (h.Voltage < 4.6)
                lblVoltage.BackColor = Color.Red;

            if (h.CaseTemp > 55)
                lblCaseTemp.BackColor = Color.Red;
        }

        private string GetNetworkStateText(int state)
        {
            return state switch
            {
                0 => "Hors ligne",
                1 => "En ligne",
                2 => "Latence élevée",
                _ => "Inconnu"
            };
        }
    }
}
