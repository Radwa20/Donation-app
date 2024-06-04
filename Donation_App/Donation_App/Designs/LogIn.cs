using Donation_App.Models;
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
    public partial class LogIn : Form
    {
        public static string Emaill;
        public static bool Uopen = false;

        Encryption Encryption=new Encryption();
        public LogIn()
        {
            InitializeComponent();
        }

       
        private void LogIn_bt_Click_1(object sender, EventArgs e)
        {
            DbClass db = new DbClass();
            if (!string.IsNullOrWhiteSpace(emailtxt.Text) && !string.IsNullOrWhiteSpace(passtxt.Text))
            {
                string enteredPassword = passtxt.Text;
                string enteredPasswordHash = Encryption.Hash(enteredPassword);

                var userAccount = db.Donors.Where(x => x.Email == emailtxt.Text && x.Password == enteredPasswordHash).FirstOrDefault();
                var orgAccount = db.Organizations.Where(x => x.OrgEmail == emailtxt.Text && x.OrgPassword == passtxt.Text).FirstOrDefault();


                if (userAccount != null)
                {
                    Emaill = emailtxt.Text;
                    Uopen = true;
                    Donor selected = db.Donors.Where(a => a.Email == Emaill).FirstOrDefault();
                    UAFHOME g1 = new UAFHOME(selected);
                    g1.Show();
                    this.Hide();
                    MessageBox.Show($"Welcome {userAccount.FirstName} ^_^ ");
                }
                else if (orgAccount != null)
                {
                    OrganizationInfo g1 = new OrganizationInfo(emailtxt.Text);
                    g1.Show();
                    this.Hide();
                    MessageBox.Show($"Welcome {orgAccount.Name} ^_^ ");
                }

                else
                    MessageBox.Show("can not be found!");
            }
            else if (string.IsNullOrWhiteSpace(emailtxt.Text))
                MessageBox.Show("Please Enter Your Email ^_^");
            else if (string.IsNullOrWhiteSpace(passtxt.Text))
                MessageBox.Show("Please Enter Your Password ^_^");
        }

        private void reset_bt_Click_1(object sender, EventArgs e)
        {
            emailtxt.Text = String.Empty;
            passtxt.Text = String.Empty;
        }

        private void backHome_btn_Click_1(object sender, EventArgs e)
        {
            UHome home1 = new UHome();
            home1.Show();
            this.Hide();
        }

        private void SignUp_ln_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp sign_Up = new SignUp();

            sign_Up.Show();
            this.Hide();
        }
    }
}
