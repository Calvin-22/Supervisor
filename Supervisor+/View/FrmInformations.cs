using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supervisor.View
{
    public partial class FrmInformations : Form
    {
        public FrmInformations()
        {
            InitializeComponent();
        }

        private void lblLienSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.calvin-software-solutions.com/";

            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            System.Diagnostics.Process.Start(psi);
        }
    }
}
