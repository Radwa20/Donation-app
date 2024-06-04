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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Donation_App.Designs
{
    public partial class GeneralInfo : Form
    {
        DbClass dbClass = new DbClass();
        private Donor donor;
        private bool check = false;


        public GeneralInfo(Donor donor)
        {
            InitializeComponent();
            this.donor = donor;
        }

        private void GeneralInfo_Load(object sender, EventArgs e)
        {

            ShowEmail_lbl.Text = LogIn.Emaill;
            string targetEmail = this.donor.Email;
            Donor user = dbClass.Donors.FirstOrDefault(d => d.Email == targetEmail);
            if (user != null)
            {
                UserName.Text = $"{user.FirstName} {user.LastName}";
                UserPic.ImageLocation = user.DonorImage;
            }
            using (var dbContext = new DbClass())
            {
                var query = from Donation in dbContext.Donations
                            join Organization in dbContext.Organizations on Donation.OrganizationEmail equals Organization.OrgEmail
                            where Donation.DonorEmail == LogIn.Emaill
                            select new
                            {
                                Organization = Organization.Name,
                                Amount = Donation.Amount,
                                Date = Donation.Date
                            };
                userActivites.DataSource = query.ToList();
            }
        }

        private void General_btn_Click_1(object sender, EventArgs e)
        {

            if (check == true)
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

        private void EditProfile_btn_Click_2(object sender, EventArgs e)
        {

            if (check == true)
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

        private void DeleteAccount_btn_Click(object sender, EventArgs e)
        {
            if (check == true)
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
                    check = true;

                    MessageBox.Show("User data deleted successfully.");
                }

                else
                {
                    MessageBox.Show("OK Happy to stay with us ^-^");
                }
            }
        }

        private void Home_btn_Click_1(object sender, EventArgs e)
        {

            if (check == true)
            {
                UHome u1 = new UHome();
                u1.Show();
                this.Hide();
            }
            else
            {
                Donor selected = dbClass.Donors.Where(a => a.Email == LogIn.Emaill).FirstOrDefault();
                UAFHOME home = new UAFHOME(selected);
                home.Show();
                this.Hide();
            }
        }
    }
}
