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
    public partial class UC_about_org1 : UserControl
    {
        public UC_about_org1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_about_org_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://x.com/EG_Red_Crescent?t=dqfl8OIPBRh5Rpikf94QFA&s=09",
                UseShellExecute = true,
            };

            Process.Start(psi);

            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.egyptianrc.org/Arabic/home",
                UseShellExecute = true,
            };

            Process.Start(psi);

            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://instagram.com/egyptianredcrescent?igshid=NGVhN2U2NjQ0Yg==",
                UseShellExecute = true,
            };

            Process.Start(psi);

            
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/user/EgyptianRC1",
                UseShellExecute = true,
            };

            Process.Start(psi);

            
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/EgyptianRedCrescent",
                UseShellExecute = true,
            };

            Process.Start(psi);

           
        }
    }
}
