namespace Donation_App.Designs
{
    partial class GeneralInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            DeleteAccount_btn = new Button();
            Home_btn = new Button();
            EditProfile_btn = new Button();
            General_btn = new Button();
            panel2 = new Panel();
            Email = new Label();
            donationBindingSource = new BindingSource(components);
            UserName = new Label();
            ShowEmail_lbl = new Label();
            UserPic = new PictureBox();
            userActivites = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)donationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userActivites).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(105, 158, 101);
            panel1.Controls.Add(DeleteAccount_btn);
            panel1.Controls.Add(Home_btn);
            panel1.Controls.Add(EditProfile_btn);
            panel1.Controls.Add(General_btn);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 740);
            panel1.TabIndex = 0;
            // 
            // DeleteAccount_btn
            // 
            DeleteAccount_btn.BackColor = Color.FromArgb(105, 158, 101);
            DeleteAccount_btn.Dock = DockStyle.Bottom;
            DeleteAccount_btn.FlatAppearance.BorderSize = 0;
            DeleteAccount_btn.FlatStyle = FlatStyle.Flat;
            DeleteAccount_btn.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteAccount_btn.ForeColor = Color.White;
            DeleteAccount_btn.Location = new Point(0, 664);
            DeleteAccount_btn.Margin = new Padding(3, 4, 3, 4);
            DeleteAccount_btn.Name = "DeleteAccount_btn";
            DeleteAccount_btn.Size = new Size(239, 76);
            DeleteAccount_btn.TabIndex = 5;
            DeleteAccount_btn.Text = "Delete Account";
            DeleteAccount_btn.UseVisualStyleBackColor = false;
            DeleteAccount_btn.Click += DeleteAccount_btn_Click;
            // 
            // Home_btn
            // 
            Home_btn.BackColor = Color.FromArgb(105, 158, 101);
            Home_btn.Dock = DockStyle.Top;
            Home_btn.FlatAppearance.BorderSize = 0;
            Home_btn.FlatStyle = FlatStyle.Flat;
            Home_btn.Font = new Font("Century Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            Home_btn.ForeColor = Color.White;
            Home_btn.Location = new Point(0, 344);
            Home_btn.Margin = new Padding(3, 4, 3, 4);
            Home_btn.Name = "Home_btn";
            Home_btn.Size = new Size(239, 118);
            Home_btn.TabIndex = 4;
            Home_btn.Text = "Home";
            Home_btn.UseVisualStyleBackColor = false;
            Home_btn.Click += Home_btn_Click_1;
            // 
            // EditProfile_btn
            // 
            EditProfile_btn.BackColor = Color.FromArgb(105, 158, 101);
            EditProfile_btn.Dock = DockStyle.Top;
            EditProfile_btn.FlatAppearance.BorderSize = 0;
            EditProfile_btn.FlatStyle = FlatStyle.Flat;
            EditProfile_btn.Font = new Font("Century Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            EditProfile_btn.ForeColor = Color.White;
            EditProfile_btn.Location = new Point(0, 230);
            EditProfile_btn.Margin = new Padding(3, 4, 3, 4);
            EditProfile_btn.Name = "EditProfile_btn";
            EditProfile_btn.Size = new Size(239, 114);
            EditProfile_btn.TabIndex = 2;
            EditProfile_btn.Text = "Edit Profile";
            EditProfile_btn.UseVisualStyleBackColor = false;
            EditProfile_btn.Click += EditProfile_btn_Click_2;
            // 
            // General_btn
            // 
            General_btn.BackColor = Color.FromArgb(105, 158, 101);
            General_btn.Dock = DockStyle.Top;
            General_btn.FlatAppearance.BorderSize = 0;
            General_btn.FlatStyle = FlatStyle.Flat;
            General_btn.Font = new Font("Century Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            General_btn.ForeColor = Color.White;
            General_btn.Location = new Point(0, 118);
            General_btn.Margin = new Padding(3, 4, 3, 4);
            General_btn.Name = "General_btn";
            General_btn.Size = new Size(239, 112);
            General_btn.TabIndex = 1;
            General_btn.Text = "General";
            General_btn.UseVisualStyleBackColor = false;
            General_btn.Click += General_btn_Click_1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 118);
            panel2.TabIndex = 0;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = Color.Transparent;
            Email.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Email.Location = new Point(314, 230);
            Email.Name = "Email";
            Email.Size = new Size(125, 47);
            Email.TabIndex = 2;
            Email.Text = "Email";
            // 
            // donationBindingSource
            // 
            donationBindingSource.DataSource = typeof(Models.Donation);
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.BackColor = Color.Transparent;
            UserName.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserName.Location = new Point(295, 48);
            UserName.Name = "UserName";
            UserName.Size = new Size(260, 56);
            UserName.TabIndex = 10;
            UserName.Text = "UserName";
            // 
            // ShowEmail_lbl
            // 
            ShowEmail_lbl.AutoSize = true;
            ShowEmail_lbl.BackColor = Color.Transparent;
            ShowEmail_lbl.FlatStyle = FlatStyle.Flat;
            ShowEmail_lbl.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            ShowEmail_lbl.Location = new Point(467, 230);
            ShowEmail_lbl.Name = "ShowEmail_lbl";
            ShowEmail_lbl.Size = new Size(228, 47);
            ShowEmail_lbl.TabIndex = 11;
            ShowEmail_lbl.Text = "ShowEmail";
            // 
            // UserPic
            // 
            UserPic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UserPic.BackColor = Color.Transparent;
            UserPic.Location = new Point(1074, 16);
            UserPic.Margin = new Padding(3, 4, 3, 4);
            UserPic.Name = "UserPic";
            UserPic.Size = new Size(314, 274);
            UserPic.SizeMode = PictureBoxSizeMode.Zoom;
            UserPic.TabIndex = 12;
            UserPic.TabStop = false;
            // 
            // userActivites
            // 
            userActivites.BackgroundColor = Color.FromArgb(105, 158, 101);
            userActivites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userActivites.Location = new Point(314, 370);
            userActivites.Margin = new Padding(2);
            userActivites.Name = "userActivites";
            userActivites.RowHeadersWidth = 62;
            userActivites.RowTemplate.Height = 33;
            userActivites.Size = new Size(804, 237);
            userActivites.TabIndex = 13;
            // 
            // GeneralInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._909261;
            ClientSize = new Size(1452, 740);
            Controls.Add(userActivites);
            Controls.Add(UserPic);
            Controls.Add(ShowEmail_lbl);
            Controls.Add(UserName);
            Controls.Add(Email);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GeneralInfo";
            Text = "GeneralInfo";
            Load += GeneralInfo_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)donationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)userActivites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button EditProfile_btn;
        private Button General_btn;
        private Panel panel2;
        private Button Home_btn;
        private Button DeleteAccount_btn;
        private Label Email;
        private Label UserName;
        private Label ShowEmail_lbl;
        private PictureBox UserPic;
        private BindingSource donationBindingSource;
        private DataGridView userActivites;
    }
}