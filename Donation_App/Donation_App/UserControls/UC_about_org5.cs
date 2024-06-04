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
    public partial class UC_about_org5 : UserControl
    {
        public UC_about_org5()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.efb.eg/?utm_source=google&utm_medium=search&utm_campaign=foodbank_ar_eg&gad_source=1&gclid=CjwKCAiAg9urBhB_EiwAgw88mT9kjZGFuT5fUxiuI710Pp3i79b64NEM76w63zm6fx9koJ8G2zsxcxoCogQQAvD_BwE",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/egyfoodbank/",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://twitter.com/EgyFoodBank",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/EgyFoodBank",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/user/egyfoodbank",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }
    }
}
