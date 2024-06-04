using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donation_App.UserControls
{
    public partial class UC_about_org2 : UserControl
    {
        public UC_about_org2()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://baheya.org/ar",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/baheyafoundation/",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://twitter.com/BaheyaHospital",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/BaheyaFoundation",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/channel/UCqmBdlOIbImeCvgDlzK3n_Q",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }
    }
}
