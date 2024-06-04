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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Donation_App.Designs
{
    public partial class EditInfo : Form
    {
        private bool ckeck = false;
        string selelctImagePath = "";
        string projImgPath = Environment.CurrentDirectory + "\\Images";

        DbClass dbClass = new DbClass();
        private Donor donor;
        public EditInfo(Donor donor)
        {
            InitializeComponent();
            this.donor = donor;
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


        private void DeleteAccount_btn_Click(object sender, EventArgs e)
        {
            if (ckeck == true)
            {
                UHome u1 = new UHome();
                u1.Show();
                this.Hide();
            }
            else

            {
                var user = dbClass.Donors.Find(LogIn.Emaill);
                var result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dbClass.Entry(user).Collection(u => u.Donations).Load();
                    dbClass.Donations.RemoveRange(user.Donations);
                    dbClass.Donors.Remove(user);
                    dbClass.SaveChanges();
                    MessageBox.Show("User data deleted successfully.");
                    ckeck = true;


                }

                else
                {
                    MessageBox.Show("OK Happy to stay with us ^-^");
                }
            }
        
        }

        private void EditProfile_btn_Click_1(object sender, EventArgs e)
        {

            if (ckeck == true)
            {
                UHome u1 = new UHome();
                u1.Show();
                this.Hide();
            }
            else
            {
                EditInfo editInfo = new EditInfo(donor);
                editInfo.Show();
                this.Hide();
            }
        }

        private void General_btn_Click_1(object sender, EventArgs e)
        {
            if (ckeck == true)
            {
                UHome u1 = new UHome();
                u1.Show();
                this.Hide();
            }
            else
            {
                GeneralInfo generalInfo = new GeneralInfo(donor);
                generalInfo.Show();
                this.Hide();
            }

        }

        private void EditInfo_Load_1(object sender, EventArgs e)
        {

            if (ckeck == true)
            {
                UHome u1 = new UHome();
                u1.Show();
                this.Hide();
            }
            else
            {
                string targetEmail = this.donor.Email;
                Donor user = dbClass.Donors.FirstOrDefault(d => d.Email == targetEmail);
                if (user != null)
                {
                    UserName.Text = $"{user.FirstName} {user.LastName}";
                }
            }
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            if (ckeck == true)
            {
                UHome u1 = new UHome();
                u1.Show();
                this.Hide();
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    picturex.ImageLocation = dialog.FileName;
                    selelctImagePath = dialog.FileName;
                }
            }
        }

        private void upbtn_Click(object sender, EventArgs e)
        {
            if (ckeck == true)
            {
                UHome u1 = new UHome();
                u1.Show();
                this.Hide();
            }

            else
            {
                string emailup = LogIn.Emaill;
                try
                {

                    var existingDonor = dbClass.Donors.FirstOrDefault(d => d.Email == emailup);
                    if (existingDonor != null)
                    {
                        existingDonor.DonorImage = picturex.ImageLocation;

                        dbClass.SaveChanges();
                        if (!string.IsNullOrEmpty(selelctImagePath))
                        {

                            string dest_path = Environment.CurrentDirectory + "\\Images" + existingDonor.Email + ".jpg";
                            try
                            {
                                File.Copy(selelctImagePath, dest_path);
                                existingDonor.DonorImage = dest_path;
                                dbClass.SaveChanges();
                                MessageBox.Show("Changes saved successfully!");
                            }
                            catch (IOException ex)
                            {
                                MessageBox.Show($"Error copying the image file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the donor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveChanges_btn_Click_1(object sender, EventArgs e)
        {

            if (ckeck == true)
            {
                UHome u1 = new UHome();
                u1.Show();
                this.Hide();
            }
            else
            {
                string emailup = LogIn.Emaill;

                var existingDonor = dbClass.Donors.FirstOrDefault(d => d.Email == emailup);
                if (existingDonor != null)
                {
                    existingDonor.FirstName = EnterNewFirstName.Text;
                    existingDonor.LastName = EnterNewLastName.Text;
                    existingDonor.Country = (_Country)compo_countrytxt.SelectedIndex;
                    existingDonor.PhoneNumber = EnterNewPhone.Text;

                    if (string.IsNullOrWhiteSpace(EnterNewFirstName.Text))
                    {
                        MessageBox.Show("Enter Your First Name");
                    }
                    else if (!IsValidName(EnterNewFirstName.Text))
                    {
                        MessageBox.Show(" First name not Valid -_- ");
                    }
                    else if (string.IsNullOrWhiteSpace(EnterNewLastName.Text))
                    {
                        MessageBox.Show("Enter Your Last Name");
                    }
                    else if (!IsValidName(EnterNewLastName.Text))
                    {
                        MessageBox.Show(" Last name not Valid -_- ");
                    }
                    else if (!IsValidCountry((_Country)compo_countrytxt.SelectedIndex))
                    {
                        MessageBox.Show("please choose from Country Box ^_^ ");
                    }
                    else if (string.IsNullOrWhiteSpace(EnterNewPhone.Text))
                    { 
                        MessageBox.Show("Enter Your Phone Number");
                    }
                    else if (!ValidatePhoneNumber((_Country)compo_countrytxt.SelectedIndex, EnterNewPhone.Text))
                    {
                        MessageBox.Show($"Phone Number is invalid for {donor.Country}.");
                    }

                    if (
                       IsValidName(EnterNewFirstName.Text) &&
                       IsValidName(EnterNewLastName.Text) &&
                       ValidatePhoneNumber((_Country)compo_countrytxt.SelectedIndex, EnterNewPhone.Text) &&
                       IsValidCountry((_Country)compo_countrytxt.SelectedIndex))
                    {
                        dbClass.SaveChanges();
                        MessageBox.Show("changes changed successfully!");
                    }
                }
            }
        }

        private void Reset_btn_Click_1(object sender, EventArgs e)
        {

            if (ckeck == true)
            {
                UHome u1 = new UHome();
                u1.Show();
                this.Hide();
            }
            else
            {

                EnterNewFirstName.Text = String.Empty;
                EnterNewLastName.Text = String.Empty;
                compo_countrytxt.Text = String.Empty;
                EnterNewPhone.Text = String.Empty;
            }
        }
    }
}
