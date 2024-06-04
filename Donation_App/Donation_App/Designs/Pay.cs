using Donation_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donation_App.Designs
{
    public partial class Pay : Form
    {
        private string orgeml;
       
        public Pay(string Email)
        {
            InitializeComponent();
            orgeml=Email;
        }
      
        
        static bool IsValidAmount(string _value)
        {
            bool isValid = int.TryParse(_value, out int number) && number <=15000 && number>=5;
            return isValid;
        }
        static bool IsValidCardNumber(string _value)
        {
            bool isValid =  _value.Length==16 && long.TryParse(_value, out long number) ;
            return isValid;
        }

        static bool IsValidCvc(string _value)
        {
            bool isValid = _value.Length == 3 && int.TryParse(_value, out int number);  
            return isValid;
        }

        static bool IsValidName(string name)
        {
            string pattern = @"^[a-zA-Z]+(?: [a-zA-Z]+)*$";
            bool valid = Regex.IsMatch(name, pattern);
            return valid;
        }
        static bool IsValidExDate(DateTime d1)
        {
           
            return d1 >= DateTime.Now;
            
        }

        private void paybtn_Click_1(object sender, EventArgs e)
        {
            DbClass dbClass = new DbClass();
            Donation donation = new Donation();
            donation.OrganizationEmail = orgeml;
            donation.DonorEmail = LogIn.Emaill;

            if (IsValidAmount(amount_txt.Text))
            {
                donation.Amount = int.Parse(amount_txt.Text);
            }
            donation.Card_Name = card_nametxt.Text;
            donation.Card_number = card_txt.Text;
            donation.CVC = cvc_txt.Text;
            donation.Expiration_date = datebx.Value;



            if (string.IsNullOrWhiteSpace(amount_txt.Text))
            {
                MessageBox.Show("Enter Your Amount");
            }
            else if (!IsValidAmount(amount_txt.Text))
            {
                MessageBox.Show("Invalid Amount");
            }

            else if (string.IsNullOrWhiteSpace(card_nametxt.Text))
            {
                MessageBox.Show("Enter Your Card Name");
            }
            else if (!IsValidName(card_nametxt.Text))
            {
                MessageBox.Show("Invalid Name");
            }

            else if (string.IsNullOrWhiteSpace(card_txt.Text))
            {
                MessageBox.Show("Enter Your Card Number");
            }
            else if (!IsValidCardNumber(card_txt.Text))
            {
                MessageBox.Show("Invalid Card Number");
            }

            else if (string.IsNullOrWhiteSpace(cvc_txt.Text))
            {
                MessageBox.Show("Enter Your CVC");
            }
            else if (!IsValidCvc(cvc_txt.Text))
            {
                MessageBox.Show("Invalid CVC");
            }

            else if (!IsValidExDate(datebx.Value))
            {
                MessageBox.Show("Choose your expiration Date!");
            }
            else if (IsValidAmount(amount_txt.Text) && IsValidName(card_nametxt.Text)
                 && IsValidCardNumber(card_txt.Text) && IsValidCvc(cvc_txt.Text) && IsValidExDate(datebx.Value))
            {
                dbClass.Donations.Add(donation);
                dbClass.SaveChanges();

                MessageBox.Show("Saved ^_^ ");
                Donor selected = dbClass.Donors.Where(a => a.Email == LogIn.Emaill).FirstOrDefault();
                UAFHOME home = new UAFHOME(selected);
                home.Show();
                this.Close();
            }
        }

        private void back_btn_Click_1(object sender, EventArgs e)
        {
            if (EgyptianRc.egyptianRc == true)
            {
                EgyptianRc _1 = new EgyptianRc();
                _1.Show();
                this.Hide();
            }
            if (Baheya.baheya == true)
            {
                Baheya _2 = new Baheya();
                _2.Show();
                this.Hide();
            }
            if (Resala.resala == true)
            {
                Resala _4 = new Resala();
                _4.Show();
                this.Hide();
            }
            if (Alorman.alorman == true)
            {
                Alorman _3 = new Alorman();
                _3.Show();
                this.Hide();
            }
            if (FoodBank.egyptianfoodbank == true)
            {
                FoodBank _5 = new FoodBank();
                _5.Show();
                this.Hide();
            }
            if (Magdiyacoub.magdiyacoub == true)
            {
                Magdiyacoub _6 = new Magdiyacoub();
                _6.Show();
                this.Hide();
            }

            EgyptianRc.egyptianRc = false;
            Baheya.baheya = false;
            Alorman.alorman = false;
            Resala.resala = false;
            FoodBank.egyptianfoodbank = false;
            Magdiyacoub.magdiyacoub = false;
        }

        private void Pay_Load_1(object sender, EventArgs e)
        {
            dEmail_lb.Text = LogIn.Emaill;

        }
    }
}
