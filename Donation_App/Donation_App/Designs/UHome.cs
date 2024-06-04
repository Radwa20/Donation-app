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
    public partial class UHome : Form
    {

        public UHome()
        {
            InitializeComponent();

        }



        private void loginbtn_Click(object sender, EventArgs e)
        {
            LogIn lgn = new LogIn();
            lgn.Show();
            this.Hide();
        }

        private void signupbtn_Click_1(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            s.Show();
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

        private void UHome_Load(object sender, EventArgs e)
        {
            toppanel.BackColor = Color.FromArgb(100, 0, 0, 0);

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
