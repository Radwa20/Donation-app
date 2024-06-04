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
    public partial class UC_about_org6 : UserControl
    {
        public UC_about_org6()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.myf-egypt.org/ar/",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/magdi_yacoub_foundation/?hl=en",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://twitter.com/myfegy?lang=en",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/Myfegypt/",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/user/MYFegypt",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }
    }
}
