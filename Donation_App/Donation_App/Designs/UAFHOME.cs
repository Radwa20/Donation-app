using Donation_App.Models;
using Donation_App.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donation_App.Designs
{
    public partial class UAFHOME : Form
    {
        private Donor donor;
        DbClass db = new DbClass();
        public UAFHOME(Donor donor)
        {
            InitializeComponent();
            this.donor = donor;

        }

        private void picuser_bx_Click(object sender, EventArgs e)
        {
            Donor selected = db.Donors.Where(a => a.Email == LogIn.Emaill).FirstOrDefault();
            GeneralInfo g = new GeneralInfo(selected);
            g.Show();
            this.Hide();
        }

        private void logout_btn_Click_1(object sender, EventArgs e)
        {

            UHome u = new UHome();
            u.Show();
            this.Hide();

        }

        private void probtn_Click_1(object sender, EventArgs e)
        {
            Donor selected = db.Donors.Where(a => a.Email == LogIn.Emaill).FirstOrDefault();
            GeneralInfo g = new GeneralInfo(selected);
            g.Show();
            this.Hide();
        }

        private void picuser_bx_Click_1(object sender, EventArgs e)
        {
            Donor selected = db.Donors.Where(a => a.Email == LogIn.Emaill).FirstOrDefault();
            GeneralInfo g = new GeneralInfo(selected);
            g.Show();
            this.Hide();
        }

        private void helalbtn_Click_1(object sender, EventArgs e)
        {
            if (LogIn.Uopen == true)
            {
                EgyptianRc Red_Crescent = new EgyptianRc();
                Red_Crescent.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please LogIn Frist ");
                LogIn lgn = new LogIn();
                lgn.Show();
                this.Hide();
            }
        }

        private void resalabtn_Click_1(object sender, EventArgs e)
        {
            if (LogIn.Uopen == true)
            {
                Resala resala = new Resala();
                resala.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please LogIn Frist ");
                LogIn lgn = new LogIn();
                lgn.Show();
                this.Hide();
            }
        }

        private void foodbank_btn_Click_1(object sender, EventArgs e)
        {
            if (LogIn.Uopen == true)
            {
                FoodBank Food_Bank = new FoodBank();
                Food_Bank.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please LogIn Frist ");
                LogIn lgn = new LogIn();
                lgn.Show();
                this.Hide();
            }
        }

        private void baheya_btn_Click_1(object sender, EventArgs e)
        {
            if (LogIn.Uopen == true)
            {
                Baheya Bahia = new Baheya();
                Bahia.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please LogIn Frist ");
                LogIn lgn = new LogIn();
                lgn.Show();
                this.Hide();
            }
        }

        private void orman_btn_Click_1(object sender, EventArgs e)
        {
            if (LogIn.Uopen == true)
            {
                Alorman Orman = new Alorman();
                Orman.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please LogIn Frist ");
                LogIn lgn = new LogIn();
                lgn.Show();
                this.Hide();
            }
        }

        private void magdy_btn_Click_1(object sender, EventArgs e)
        {
            if (LogIn.Uopen == true)
            {
                Magdiyacoub Magdy_Yaqoub = new Magdiyacoub();
                Magdy_Yaqoub.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please LogIn Frist ");
                LogIn lgn = new LogIn();
                lgn.Show();
                this.Hide();
            }
        }
        private void UAFHOME_Load_1(object sender, EventArgs e)
        {
            toppanel.BackColor = Color.FromArgb(100, 0, 0, 0);

            string targetEmail = this.donor.Email;
            Donor picdonor = db.Donors.Where(a => a.Email == targetEmail).FirstOrDefault();

            if (picdonor != null)
            {
                picuser_bx.ImageLocation = picdonor.DonorImage;
            }
        }

        private void contbtn_Click_1(object sender, EventArgs e)
        {
            emaillbl.Text = ": donationtogetherforhumanity@gmail.com";
            Color color = Color.LightGray;
            emaillbl.ForeColor = color;
        }

        private void emailpicbtn_Click_1(object sender, EventArgs e)
        {
            emaillbl.Text = ": donationtogetherforhumanity@gmail.com";
            Color color = Color.LightGray;
            emaillbl.ForeColor = color;
        }
    }
}
