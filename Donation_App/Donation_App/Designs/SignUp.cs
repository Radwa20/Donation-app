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
    public partial class SignUp : Form
    {
        string selelctImagePath = "";
        bool validAge = false;
        string projImgPath = Environment.CurrentDirectory + "\\Images";

        Encryption Encryption=new Encryption();
        public SignUp()
        {
            InitializeComponent();
        }

        static bool IsValidCountry(_Country countryToCheck)
        {
            List<_Country> countries = new List<_Country>
        {
        _Country.Egypt, _Country.Sudan, _Country.Saudi_Arabia, _Country.Tunisia,_Country.Somalia, _Country.Algeria,
        _Country.Iraq, _Country.Syria, _Country.Yemen, _Country.Libya,_Country. Jordan, _Country.Palestine,_Country. Bahrain,
           _Country.Qatar, _Country.Oman,_Country.Kuwait

        };

            bool genderExists = countries.Contains(countryToCheck);
            return genderExists;
        }
        static bool IsValidGender(_Gender genderToCheck)
        {
            List<_Gender> gender = new List<_Gender>
            {
              _Gender.Male,_Gender.Female
            };

            bool genderExists = gender.Contains(genderToCheck);
            return genderExists;
        }
        static bool IsValidEmail(string email)
        {
            string pattern = @"^\w+@gmail.com$";
            Regex regex = new Regex(pattern);
            bool valid = regex.IsMatch(email);
            return valid;
        }
        static bool IsValidName(string name)
        {
            string pattern = @"^[a-zA-Z]+$";
            bool valid = Regex.IsMatch(name, pattern);
            return valid;
        }
        static bool ValidatePhoneNumber(_Country country, string phoneNumber)
        {
            bool isValid = false;

            switch (country)
            {
                case _Country.Sudan:
                    isValid = ValidateRegex(phoneNumber, @"^09\d{9}$");
                    break;
                case _Country.Saudi_Arabia:
                    isValid = ValidateRegex(phoneNumber, @"^05\d{8}$");
                    break;
                case _Country.Tunisia:
                    isValid = ValidateRegex(phoneNumber, @"^[2-9]\d{7}$");
                    break;
                case _Country.Somalia:
                    isValid = ValidateRegex(phoneNumber, @"^[6-9]\d{9}$");
                    break;
                case _Country.Algeria:
                    isValid = ValidateRegex(phoneNumber, @"^05[56789]\d{7}$");
                    break;
                case _Country.Morocco:
                    isValid = ValidateRegex(phoneNumber, @"^06\d{8}$");
                    break;
                case _Country.Iraq:
                    isValid = ValidateRegex(phoneNumber, @"^07\d{9}$");
                    break;
                case _Country.Syria:
                    isValid = ValidateRegex(phoneNumber, @"^09\d{9}$");
                    break;
                case _Country.Yemen:
                    isValid = ValidateRegex(phoneNumber, @"^[167]\d{10}$");
                    break;
                case _Country.Libya:
                    isValid = ValidateRegex(phoneNumber, @"^09\d{8}$");
                    break;
                case _Country.Jordan:
                    isValid = ValidateRegex(phoneNumber, @"^07\d{7}$");
                    break;
                case _Country.Palestine:
                    isValid = ValidateRegex(phoneNumber, @"^05\d{8}$");
                    break;
                case _Country.Bahrain:
                    isValid = ValidateRegex(phoneNumber, @"^3\d{8}$");
                    break;
                case _Country.Qatar:
                    isValid = ValidateRegex(phoneNumber, @"^[35679]\d{8}$");
                    break;
                case _Country.Oman:
                    isValid = ValidateRegex(phoneNumber, @"^9\d{8}$");
                    break;
                case _Country.Kuwait:
                    isValid = ValidateRegex(phoneNumber, @"^[56]\d{8}$");
                    break;
                case _Country.Egypt:
                    isValid = ValidateRegex(phoneNumber, @"^(01[0-2]|015)[0-9]{8}$");
                    break;
                default:
                    break;
            }

            return isValid;
        }
        static bool ValidateRegex(string input, string pattern)
        {
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
        private bool IsValidPassword(string pass)
        {
            bool valid = !pass.Contains('-') && pass.Length >= 8 && pass.Length <= 10;
            return valid;
        }
       
        private void Home_btn_Click_1(object sender, EventArgs e)
        {
            UHome uHome = new UHome();
            uHome.Show();
            this.Hide();
        }

        private void browsebt_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                donorimagebx.ImageLocation = dialog.FileName;
                selelctImagePath = dialog.FileName;
            }
        }

        private void SignUp_bt_Click_1(object sender, EventArgs e)
        {
            DbClass DB = new DbClass();

            Donor donor = new Donor();


            donor.FirstName = Fnametxt.Text;
            donor.LastName = Lnametxt.Text;
            donor.Gender = (_Gender)combo_genderbx.SelectedIndex;
            donor.Email = emailtxt.Text;
            //donor.Password = passwordtxt.Text;
            string enteredPassword = passwordtxt.Text;
            string hashedPassword = Encryption.Hash(enteredPassword);
            donor.Password= hashedPassword;
            donor.Country = (_Country)combo_countrybx.SelectedIndex;
            donor.PhoneNumber = phontxt.Text;
            donor.DonorImage = "NoImg";


            var user_rpt_Accoubt = DB.Donors.Where(x => x.Email == emailtxt.Text).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(Fnametxt.Text))
            {
                MessageBox.Show("Enter Your First Name");
            }
            else if (!IsValidName(Fnametxt.Text))
            {
                MessageBox.Show(" First name not Valid -_- ");
            }
            else if (string.IsNullOrWhiteSpace(Lnametxt.Text))
            {
                MessageBox.Show("Enter Your Last Name");
            }
            else if (!IsValidName(Lnametxt.Text))
            {
                MessageBox.Show(" Last name not Valid -_- ");
            }
            else if (!IsValidGender((_Gender)combo_genderbx.SelectedIndex))
            {
                MessageBox.Show("please choose from Gender Box ^_^ ");
            }
            else if (string.IsNullOrWhiteSpace(emailtxt.Text))
            {
                MessageBox.Show("Enter Your Email");
            }
            else if (!IsValidEmail(emailtxt.Text))
            {
                MessageBox.Show(" Email not Valid  -_- ");
            }
            else if (user_rpt_Accoubt != null)
            {
                MessageBox.Show("This Email Is Already Exists!");
            }
            else if (string.IsNullOrWhiteSpace(passwordtxt.Text))
            {
                MessageBox.Show("Enter Your Password");
            }
            else if (!IsValidPassword(passwordtxt.Text))
            {
                MessageBox.Show("Invaild Password Please Enter Password with Length from 8 to 10   -_- ");
            }
            else if (!IsValidCountry((_Country)combo_countrybx.SelectedIndex))
            {
                MessageBox.Show("please choose from Country Box ^_^ ");
            }
            else if (string.IsNullOrWhiteSpace(phontxt.Text))
            {
                MessageBox.Show("Enter Your Phone Number");
            }
            else if (!ValidatePhoneNumber((_Country)combo_countrybx.SelectedIndex, phontxt.Text))
            {
                MessageBox.Show($"Phone Number is invalid for {donor.Country}.");
            }
            else if (int.TryParse(agetxt.Text, out int age) && (age >= 18 && age <= 70)
                && !string.IsNullOrWhiteSpace(agetxt.Text))
            {
                donor.Age = age;
                validAge = true;
            }
            else
            {
                MessageBox.Show("Invalid age input. Please enter a valid integer.");
            }


            if (IsValidEmail(emailtxt.Text) &&
                IsValidName(Fnametxt.Text) &&
                IsValidPassword(passwordtxt.Text) &&
                IsValidName(Lnametxt.Text) &&
                ValidatePhoneNumber((_Country)combo_countrybx.SelectedIndex, phontxt.Text) &&
                IsValidCountry((_Country)combo_countrybx.SelectedIndex) &&
                IsValidGender((_Gender)combo_genderbx.SelectedIndex) &&
                validAge)

            {

                DB.Donors.Add(donor);
                DB.SaveChanges();
                if (!string.IsNullOrWhiteSpace(selelctImagePath))
                {
                    string newImagePath = projImgPath + "\\" + donor.Email + "_.jpg";
                    File.Copy(selelctImagePath, newImagePath);
                    donor.DonorImage = newImagePath;
                    DB.SaveChanges();
                }
                MessageBox.Show($"WELCOME {donor.FirstName} ^_^ ");
                LogIn l = new LogIn();
                l.Show();
                this.Hide();


            }


        }
    }
}
