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
    public partial class UC_about_org4 : UserControl
    {
        public UC_about_org4()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://resala.org/",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/resala.charity.organization",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://twitter.com/Resalaeg",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/Resala.org",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/user/resala",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }
    }
}
