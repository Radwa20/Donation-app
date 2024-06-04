using Donation_App.Models;
using Microsoft.Data.SqlClient;
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
    public partial class OrganizationInfo : Form
    {
        DbClass db = new DbClass();
        private string orgEmail;

        public OrganizationInfo(string orgEmail)
        {
            InitializeComponent();
            this.orgEmail = orgEmail;
        }

        private void goHome_Click(object sender, EventArgs e)
        {
            UHome oHome = new UHome();
            oHome.Show();
            this.Hide();


        }

        private void OrganizationInfo_Load(object sender, EventArgs e)
        {
            var donors = from don in db.Donations
                         where don.OrganizationEmail == orgEmail
                         select new { don.DonorEmail, don.Date, don.Amount };

            orgDetails.DataSource = donors.ToList();



            using (DbClass context = new DbClass())
            {
                var Name = from dd in context.Organizations where dd.OrgEmail == orgEmail select dd.Name;
                name.Text = Name.ToList<string>()[0];
            }


            using (DbClass context = new DbClass())
            {
                var sumAmount = context.Donations.Where(dd => dd.OrganizationEmail == orgEmail)
                                                .Sum(dd => dd.Amount);

                Amount.Text = $"{sumAmount:N0} EGP";


            }
            using (DbClass context = new DbClass())
            {
                var distinctDonorsCount = context.Donations.Where(dd => dd.OrganizationEmail == orgEmail)
                                             .Select(dd => dd.DonorEmail)
                                             .Distinct()
                                             .Count();

                Donors.Text = $"{distinctDonorsCount:N0} Person";
            }
        }

        private void custom_Click(object sender, EventArgs e)
        {
            var donors = from don in db.Donations
                         where don.OrganizationEmail == orgEmail
                         select new { don.DonorEmail, don.Date, don.Amount };
            orgDetails.DataSource = donors.ToList();
        }

        private void Today_Click(object sender, EventArgs e)
        {
            DateTime todaysDate = DateTime.Today;

            var donors = from don in db.Donations
                         where don.OrganizationEmail == orgEmail
                         where don.Date.Date == todaysDate
                         select new { don.DonorEmail, don.Date, don.Amount };

            orgDetails.DataSource = donors.ToList();
        }

        private void thisWeek_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(6);

            var donors = from don in db.Donations
                         where don.OrganizationEmail == orgEmail
                         where don.Date.Date >= startOfWeek && don.Date.Date <= endOfWeek
                         select new { don.DonorEmail, don.Date, don.Amount };
            orgDetails.DataSource = donors.ToList();
        }

        private void thisMonth_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

            var donors = from don in db.Donations
                         where don.OrganizationEmail == orgEmail
                         where don.Date.Date >= startOfMonth && don.Date.Date <= endOfMonth
                         select new { don.DonorEmail, don.Date, don.Amount };
            orgDetails.DataSource = donors.ToList();
        }
        private void checkDonations_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = checkDonations.SelectedItem.ToString();

            if (selectedCategory == "0 To 500")
            {
                updateOrgDetails1(selectedCategory);
            }
            if (selectedCategory == "501 To 1000")
            {
                updateOrgDetails2(selectedCategory);
            }
            if (selectedCategory == "More...")
            {
                updateOrgDetails3(selectedCategory);
            }
        }
        private void updateOrgDetails1(string selectedCategory)
        {
            var donors = from don in db.Donations
                         where don.OrganizationEmail == orgEmail
                         where don.Amount >= 0 && don.Amount <= 500
                         select new { don.DonorEmail, don.Date, don.Amount };
            orgDetails.DataSource = donors.ToList();

        }
        private void updateOrgDetails2(string selectedCategory)
        {
            var donors = from don in db.Donations
                         where don.OrganizationEmail == orgEmail
                         where don.Amount >= 501 && don.Amount <= 1000
                         select new { don.DonorEmail, don.Date, don.Amount };
            orgDetails.DataSource = donors.ToList();

        }
        private void updateOrgDetails3(string selectedCategory)
        {
            var donors = from don in db.Donations
                         where don.OrganizationEmail == orgEmail
                         where don.Amount >= 1001
                         select new { don.DonorEmail, don.Date, don.Amount };
            orgDetails.DataSource = donors.ToList();
        }

       
    }
}
