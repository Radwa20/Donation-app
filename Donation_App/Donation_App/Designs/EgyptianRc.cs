﻿using Donation_App.Models;
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
    public partial class EgyptianRc : Form
    {
        
        public static bool egyptianRc = false;
        DbClass db = new DbClass();
        public EgyptianRc()
        {
            InitializeComponent();
            UC_home_org1 uC = new UC_home_org1();
            addUserControl(uC);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
       
       

        private void Donation_Button_Click(object sender, EventArgs e)
        {
            string Org1Email = "egyptianrc@gmail.org";
            egyptianRc = true;
            Pay pay = new Pay(Org1Email);
            pay.Show();
            this.Hide();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            UC_home_org1 uC = new UC_home_org1();
            addUserControl(uC);
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            UC_about_org1 uC = new UC_about_org1();
            addUserControl(uC);
        }

        private void back_btn_Click_1(object sender, EventArgs e)
        {
            Donor selected = db.Donors.Where(a => a.Email == LogIn.Emaill).FirstOrDefault();
            UAFHOME org1 = new UAFHOME(selected);
            org1.Show();
            this.Hide();
        }
    }
}
