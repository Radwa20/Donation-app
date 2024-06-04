namespace Donation_App.Designs
{
    partial class EditInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInfo));
            panel1 = new Panel();
            DeleteAccount_btn = new Button();
            EditProfile_btn = new Button();
            General_btn = new Button();
            panel2 = new Panel();
            SaveChanges_btn = new Button();
            Reset_btn = new Button();
            label1 = new Label();
            UserName = new Label();
            EnterNewFirstName = new TextBox();
            LastName_lbl = new Label();
            EnterNewLastName = new TextBox();
            Phone_lbl = new Label();
            EnterNewPhone = new TextBox();
            editcountry_txt = new Label();
            compo_countrytxt = new ComboBox();
            picturex = new PictureBox();
            browsebtn = new Button();
            upbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturex).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(105, 158, 101);
            panel1.Controls.Add(DeleteAccount_btn);
            panel1.Controls.Add(EditProfile_btn);
            panel1.Controls.Add(General_btn);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 740);
            panel1.TabIndex = 1;
            // 
            // DeleteAccount_btn
            // 
            DeleteAccount_btn.BackColor = Color.FromArgb(105, 158, 101);
            DeleteAccount_btn.Dock = DockStyle.Bottom;
            DeleteAccount_btn.FlatAppearance.BorderSize = 0;
            DeleteAccount_btn.FlatStyle = FlatStyle.Flat;
            DeleteAccount_btn.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteAccount_btn.ForeColor = Color.White;
            DeleteAccount_btn.Location = new Point(0, 664);
            DeleteAccount_btn.Margin = new Padding(3, 4, 3, 4);
            DeleteAccount_btn.Name = "DeleteAccount_btn";
            DeleteAccount_btn.Size = new Size(323, 76);
            DeleteAccount_btn.TabIndex = 5;
            DeleteAccount_btn.Text = "Delete Account";
            DeleteAccount_btn.UseVisualStyleBackColor = false;
            DeleteAccount_btn.Click += DeleteAccount_btn_Click;
            // 
            // EditProfile_btn
            // 
            EditProfile_btn.BackColor = Color.FromArgb(105, 158, 101);
            EditProfile_btn.Dock = DockStyle.Top;
            EditProfile_btn.FlatAppearance.BorderSize = 0;
            EditProfile_btn.FlatStyle = FlatStyle.Flat;
            EditProfile_btn.Font = new Font("Century Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            EditProfile_btn.ForeColor = Color.White;
            EditProfile_btn.Location = new Point(0, 280);
            EditProfile_btn.Margin = new Padding(3, 4, 3, 4);
            EditProfile_btn.Name = "EditProfile_btn";
            EditProfile_btn.Size = new Size(323, 146);
            EditProfile_btn.TabIndex = 2;
            EditProfile_btn.Text = "Edit Profile";
            EditProfile_btn.UseVisualStyleBackColor = false;
            EditProfile_btn.Click += EditProfile_btn_Click_1;
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
            General_btn.Size = new Size(323, 162);
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
            panel2.Size = new Size(323, 118);
            panel2.TabIndex = 0;
            // 
            // SaveChanges_btn
            // 
            SaveChanges_btn.BackColor = Color.FromArgb(105, 158, 101);
            SaveChanges_btn.FlatAppearance.BorderSize = 0;
            SaveChanges_btn.FlatStyle = FlatStyle.Flat;
            SaveChanges_btn.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SaveChanges_btn.ForeColor = Color.White;
            SaveChanges_btn.Location = new Point(623, 630);
            SaveChanges_btn.Margin = new Padding(3, 4, 3, 4);
            SaveChanges_btn.Name = "SaveChanges_btn";
            SaveChanges_btn.Size = new Size(170, 40);
            SaveChanges_btn.TabIndex = 6;
            SaveChanges_btn.Text = "Save Changes";
            SaveChanges_btn.UseVisualStyleBackColor = false;
            SaveChanges_btn.Click += SaveChanges_btn_Click_1;
            // 
            // Reset_btn
            // 
            Reset_btn.BackColor = Color.FromArgb(105, 158, 101);
            Reset_btn.FlatAppearance.BorderSize = 0;
            Reset_btn.FlatStyle = FlatStyle.Flat;
            Reset_btn.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Reset_btn.ForeColor = Color.White;
            Reset_btn.Location = new Point(1031, 630);
            Reset_btn.Margin = new Padding(3, 4, 3, 4);
            Reset_btn.Name = "Reset_btn";
            Reset_btn.Size = new Size(170, 40);
            Reset_btn.TabIndex = 7;
            Reset_btn.Text = "Reset";
            Reset_btn.UseVisualStyleBackColor = false;
            Reset_btn.Click += Reset_btn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(445, 226);
            label1.Name = "label1";
            label1.Size = new Size(188, 40);
            label1.TabIndex = 8;
            label1.Text = "First Name";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.BackColor = Color.Transparent;
            UserName.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            UserName.Location = new Point(410, 50);
            UserName.Name = "UserName";
            UserName.Size = new Size(242, 51);
            UserName.TabIndex = 9;
            UserName.Text = "UserName";
            // 
            // EnterNewFirstName
            // 
            EnterNewFirstName.Location = new Point(661, 226);
            EnterNewFirstName.Margin = new Padding(3, 4, 3, 4);
            EnterNewFirstName.Name = "EnterNewFirstName";
            EnterNewFirstName.Size = new Size(350, 27);
            EnterNewFirstName.TabIndex = 10;
            // 
            // LastName_lbl
            // 
            LastName_lbl.AutoSize = true;
            LastName_lbl.BackColor = Color.Transparent;
            LastName_lbl.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LastName_lbl.Location = new Point(445, 323);
            LastName_lbl.Name = "LastName_lbl";
            LastName_lbl.Size = new Size(190, 40);
            LastName_lbl.TabIndex = 11;
            LastName_lbl.Text = "Last Name";
            // 
            // EnterNewLastName
            // 
            EnterNewLastName.Location = new Point(661, 336);
            EnterNewLastName.Margin = new Padding(3, 4, 3, 4);
            EnterNewLastName.Name = "EnterNewLastName";
            EnterNewLastName.Size = new Size(350, 27);
            EnterNewLastName.TabIndex = 12;
            // 
            // Phone_lbl
            // 
            Phone_lbl.AutoSize = true;
            Phone_lbl.BackColor = Color.Transparent;
            Phone_lbl.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Phone_lbl.Location = new Point(445, 520);
            Phone_lbl.Name = "Phone_lbl";
            Phone_lbl.Size = new Size(120, 40);
            Phone_lbl.TabIndex = 13;
            Phone_lbl.Text = "Phone";
            // 
            // EnterNewPhone
            // 
            EnterNewPhone.Location = new Point(665, 520);
            EnterNewPhone.Margin = new Padding(3, 4, 3, 4);
            EnterNewPhone.MaxLength = 11;
            EnterNewPhone.Name = "EnterNewPhone";
            EnterNewPhone.Size = new Size(350, 27);
            EnterNewPhone.TabIndex = 14;
            // 
            // editcountry_txt
            // 
            editcountry_txt.AutoSize = true;
            editcountry_txt.BackColor = Color.Transparent;
            editcountry_txt.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            editcountry_txt.Location = new Point(445, 413);
            editcountry_txt.Name = "editcountry_txt";
            editcountry_txt.Size = new Size(147, 40);
            editcountry_txt.TabIndex = 15;
            editcountry_txt.Text = "Country";
            // 
            // compo_countrytxt
            // 
            compo_countrytxt.FormattingEnabled = true;
            compo_countrytxt.Items.AddRange(new object[] { "Egypt", "Sudan", "Saudi_Arabia", "Tunisia", "Somalia", "Algeria", "Morocco", "Iraq", "Syria", "Yemen", "Libya", "Jordan", "Palestine", "Bahrain", "Qatar", "Oman", "Kuwait" });
            compo_countrytxt.Location = new Point(661, 424);
            compo_countrytxt.Margin = new Padding(2);
            compo_countrytxt.Name = "compo_countrytxt";
            compo_countrytxt.Size = new Size(346, 28);
            compo_countrytxt.TabIndex = 16;
            // 
            // picturex
            // 
            picturex.BackColor = Color.Transparent;
            picturex.BorderStyle = BorderStyle.Fixed3D;
            picturex.Location = new Point(1158, 50);
            picturex.Margin = new Padding(2, 2, 2, 2);
            picturex.Name = "picturex";
            picturex.Size = new Size(223, 170);
            picturex.SizeMode = PictureBoxSizeMode.Zoom;
            picturex.TabIndex = 18;
            picturex.TabStop = false;
            // 
            // browsebtn
            // 
            browsebtn.BackColor = Color.RosyBrown;
            browsebtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            browsebtn.ForeColor = Color.White;
            browsebtn.Location = new Point(1170, 236);
            browsebtn.Margin = new Padding(2, 2, 2, 2);
            browsebtn.Name = "browsebtn";
            browsebtn.Size = new Size(90, 44);
            browsebtn.TabIndex = 19;
            browsebtn.Text = "Browse";
            browsebtn.UseVisualStyleBackColor = false;
            browsebtn.Click += browsebtn_Click;
            // 
            // upbtn
            // 
            upbtn.BackColor = Color.FromArgb(105, 158, 101);
            upbtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            upbtn.ForeColor = Color.White;
            upbtn.Location = new Point(1302, 236);
            upbtn.Margin = new Padding(2, 2, 2, 2);
            upbtn.Name = "upbtn";
            upbtn.Size = new Size(90, 44);
            upbtn.TabIndex = 20;
            upbtn.Text = "Update";
            upbtn.UseVisualStyleBackColor = false;
            upbtn.Click += upbtn_Click;
            // 
            // EditInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1452, 740);
            Controls.Add(upbtn);
            Controls.Add(browsebtn);
            Controls.Add(picturex);
            Controls.Add(compo_countrytxt);
            Controls.Add(editcountry_txt);
            Controls.Add(EnterNewPhone);
            Controls.Add(Phone_lbl);
            Controls.Add(EnterNewLastName);
            Controls.Add(LastName_lbl);
            Controls.Add(EnterNewFirstName);
            Controls.Add(UserName);
            Controls.Add(label1);
            Controls.Add(Reset_btn);
            Controls.Add(SaveChanges_btn);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditInfo";
            Text = "EditInfo";
            Load += EditInfo_Load_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picturex).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button DeleteAccount_btn;
        private Button EditProfile_btn;
        private Button General_btn;
        private Panel panel2;
        private Button SaveChanges_btn;
        private Button Reset_btn;
        private Label label1;
        private Label UserName;
        private TextBox EnterNewFirstName;
        private Label LastName_lbl;
        private TextBox EnterNewLastName;
        private Label Phone_lbl;
        private TextBox EnterNewPhone;
        private Label editcountry_txt;
        private ComboBox compo_countrytxt;
        private PictureBox picturex;
        private Button browsebtn;
        private Button upbtn;
    }
}