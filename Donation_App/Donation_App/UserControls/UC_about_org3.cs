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
    public partial class UC_about_org3 : UserControl
    {
        public UC_about_org3()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.dar-alorman.com/Home",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/OrmanCharityAssociation",
                UseShellExecute = true,
            };

            Process.Start(psi);

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/ormancharityassociation?igshid=f39hpw6mpkdf",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://twitter.com/al_orman?lang=ar",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/channel/UCnNWucvVoxWq8kJxrSV5fvQ/videos",
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
