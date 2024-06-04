namespace Donation_App.Designs
{
    partial class UHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UHome));
            toppanel = new Panel();
            labelname = new Label();
            signupbtn = new Button();
            loginbtn = new RJControls.RJButton();
            panelcontainer = new Panel();
            emaillbl = new Label();
            label1 = new Label();
            emaill = new Label();
            emailpicbtn = new RJControls.RJButton();
            foodbank_btn = new RJControls.RJButton();
            contbtn = new Button();
            baheya_btn = new RJControls.RJButton();
            magdy_btn = new RJControls.RJButton();
            orman_btn = new RJControls.RJButton();
            resalabtn = new RJControls.RJButton();
            helalbtn = new RJControls.RJButton();
            toppanel.SuspendLayout();
            panelcontainer.SuspendLayout();
            SuspendLayout();
            // 
            // toppanel
            // 
            toppanel.BackColor = SystemColors.ControlDarkDark;
            toppanel.Controls.Add(labelname);
            toppanel.Controls.Add(signupbtn);
            toppanel.Controls.Add(loginbtn);
            toppanel.Dock = DockStyle.Top;
            toppanel.Location = new Point(0, 0);
            toppanel.Name = "toppanel";
            toppanel.Size = new Size(1452, 86);
            toppanel.TabIndex = 1;
            // 
            // labelname
            // 
            labelname.Anchor = AnchorStyles.Top;
            labelname.AutoSize = true;
            labelname.BackColor = Color.Transparent;
            labelname.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelname.ForeColor = SystemColors.ControlLight;
            labelname.Location = new Point(327, 9);
            labelname.Name = "labelname";
            labelname.Size = new Size(799, 59);
            labelname.TabIndex = 13;
            labelname.Text = "Donation Together For Humanity";
            // 
            // signupbtn
            // 
            signupbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            signupbtn.BackColor = Color.Transparent;
            signupbtn.BackgroundImage = (Image)resources.GetObject("signupbtn.BackgroundImage");
            signupbtn.BackgroundImageLayout = ImageLayout.Zoom;
            signupbtn.FlatAppearance.BorderSize = 0;
            signupbtn.FlatStyle = FlatStyle.Popup;
            signupbtn.Location = new Point(1265, 33);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(41, 29);
            signupbtn.TabIndex = 10;
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click_1;
            // 
            // loginbtn
            // 
            loginbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginbtn.BackColor = Color.FromArgb(105, 158, 101);
            loginbtn.BackgroundColor = Color.FromArgb(105, 158, 101);
            loginbtn.BorderColor = Color.PaleVioletRed;
            loginbtn.BorderRadius = 20;
            loginbtn.BorderSize = 0;
            loginbtn.FlatAppearance.BorderSize = 0;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(1322, 26);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(101, 38);
            loginbtn.TabIndex = 12;
            loginbtn.Text = "Log in";
            loginbtn.TextColor = Color.White;
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // panelcontainer
            // 
            panelcontainer.BackColor = Color.Transparent;
            panelcontainer.Controls.Add(emaillbl);
            panelcontainer.Controls.Add(label1);
            panelcontainer.Controls.Add(emaill);
            panelcontainer.Controls.Add(emailpicbtn);
            panelcontainer.Controls.Add(foodbank_btn);
            panelcontainer.Controls.Add(contbtn);
            panelcontainer.Controls.Add(baheya_btn);
            panelcontainer.Controls.Add(magdy_btn);
            panelcontainer.Controls.Add(orman_btn);
            panelcontainer.Controls.Add(resalabtn);
            panelcontainer.Controls.Add(helalbtn);
            panelcontainer.Dock = DockStyle.Fill;
            panelcontainer.Location = new Point(0, 86);
            panelcontainer.Name = "panelcontainer";
            panelcontainer.Size = new Size(1452, 654);
            panelcontainer.TabIndex = 12;
            // 
            // emaillbl
            // 
            emaillbl.AutoSize = true;
            emaillbl.ForeColor = Color.White;
            emaillbl.Location = new Point(170, 627);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(0, 20);
            emaillbl.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(176, 630);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 16;
            // 
            // emaill
            // 
            emaill.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            emaill.AutoSize = true;
            emaill.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            emaill.ForeColor = SystemColors.ControlLight;
            emaill.Location = new Point(170, 630);
            emaill.Name = "emaill";
            emaill.Size = new Size(0, 21);
            emaill.TabIndex = 15;
            // 
            // emailpicbtn
            // 
            emailpicbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            emailpicbtn.BackColor = Color.Transparent;
            emailpicbtn.BackgroundColor = Color.Transparent;
            emailpicbtn.BackgroundImage = (Image)resources.GetObject("emailpicbtn.BackgroundImage");
            emailpicbtn.BackgroundImageLayout = ImageLayout.Zoom;
            emailpicbtn.BorderColor = Color.PaleVioletRed;
            emailpicbtn.BorderRadius = 20;
            emailpicbtn.BorderSize = 0;
            emailpicbtn.FlatAppearance.BorderSize = 0;
            emailpicbtn.FlatStyle = FlatStyle.Flat;
            emailpicbtn.ForeColor = Color.Silver;
            emailpicbtn.Location = new Point(16, 615);
            emailpicbtn.Name = "emailpicbtn";
            emailpicbtn.Size = new Size(40, 35);
            emailpicbtn.TabIndex = 13;
            emailpicbtn.TextColor = Color.Silver;
            emailpicbtn.UseVisualStyleBackColor = false;
            emailpicbtn.Click += emailpicbtn_Click_1;
            // 
            // foodbank_btn
            // 
            foodbank_btn.BackColor = Color.FromArgb(224, 210, 209);
            foodbank_btn.BackgroundColor = Color.FromArgb(224, 210, 209);
            foodbank_btn.BackgroundImage = (Image)resources.GetObject("foodbank_btn.BackgroundImage");
            foodbank_btn.BackgroundImageLayout = ImageLayout.Center;
            foodbank_btn.BorderColor = Color.PaleVioletRed;
            foodbank_btn.BorderRadius = 20;
            foodbank_btn.BorderSize = 0;
            foodbank_btn.FlatAppearance.BorderSize = 0;
            foodbank_btn.FlatStyle = FlatStyle.Flat;
            foodbank_btn.ForeColor = Color.White;
            foodbank_btn.Location = new Point(100, 377);
            foodbank_btn.Name = "foodbank_btn";
            foodbank_btn.Size = new Size(302, 171);
            foodbank_btn.TabIndex = 14;
            foodbank_btn.TextColor = Color.White;
            foodbank_btn.UseVisualStyleBackColor = false;
            foodbank_btn.Click += foodbank_btn_Click_1;
            // 
            // contbtn
            // 
            contbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            contbtn.FlatAppearance.BorderSize = 0;
            contbtn.FlatAppearance.MouseDownBackColor = Color.Black;
            contbtn.FlatAppearance.MouseOverBackColor = Color.Black;
            contbtn.FlatStyle = FlatStyle.Flat;
            contbtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            contbtn.ForeColor = Color.Silver;
            contbtn.Location = new Point(45, 622);
            contbtn.Name = "contbtn";
            contbtn.Size = new Size(125, 29);
            contbtn.TabIndex = 14;
            contbtn.Text = "Contact us";
            contbtn.UseVisualStyleBackColor = false;
            contbtn.Click += contbtn_Click_1;
            // 
            // baheya_btn
            // 
            baheya_btn.Anchor = AnchorStyles.Top;
            baheya_btn.BackColor = Color.FromArgb(224, 210, 209);
            baheya_btn.BackgroundColor = Color.FromArgb(224, 210, 209);
            baheya_btn.BackgroundImage = (Image)resources.GetObject("baheya_btn.BackgroundImage");
            baheya_btn.BackgroundImageLayout = ImageLayout.Center;
            baheya_btn.BorderColor = Color.PaleVioletRed;
            baheya_btn.BorderRadius = 20;
            baheya_btn.BorderSize = 0;
            baheya_btn.FlatAppearance.BorderSize = 0;
            baheya_btn.FlatStyle = FlatStyle.Flat;
            baheya_btn.ForeColor = Color.White;
            baheya_btn.Location = new Point(580, 377);
            baheya_btn.Name = "baheya_btn";
            baheya_btn.Size = new Size(302, 171);
            baheya_btn.TabIndex = 13;
            baheya_btn.TextColor = Color.White;
            baheya_btn.UseVisualStyleBackColor = false;
            baheya_btn.Click += baheya_btn_Click_1;
            // 
            // magdy_btn
            // 
            magdy_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            magdy_btn.BackColor = Color.FromArgb(224, 210, 209);
            magdy_btn.BackgroundColor = Color.FromArgb(224, 210, 209);
            magdy_btn.BackgroundImage = (Image)resources.GetObject("magdy_btn.BackgroundImage");
            magdy_btn.BackgroundImageLayout = ImageLayout.Stretch;
            magdy_btn.BorderColor = Color.PaleVioletRed;
            magdy_btn.BorderRadius = 20;
            magdy_btn.BorderSize = 0;
            magdy_btn.FlatAppearance.BorderSize = 0;
            magdy_btn.FlatStyle = FlatStyle.Flat;
            magdy_btn.ForeColor = Color.White;
            magdy_btn.Location = new Point(1051, 377);
            magdy_btn.Name = "magdy_btn";
            magdy_btn.Size = new Size(302, 171);
            magdy_btn.TabIndex = 12;
            magdy_btn.TextColor = Color.White;
            magdy_btn.UseVisualStyleBackColor = false;
            magdy_btn.Click += magdy_btn_Click_1;
            // 
            // orman_btn
            // 
            orman_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            orman_btn.BackColor = Color.FromArgb(224, 210, 209);
            orman_btn.BackgroundColor = Color.FromArgb(224, 210, 209);
            orman_btn.BackgroundImage = (Image)resources.GetObject("orman_btn.BackgroundImage");
            orman_btn.BackgroundImageLayout = ImageLayout.Center;
            orman_btn.BorderColor = Color.PaleVioletRed;
            orman_btn.BorderRadius = 20;
            orman_btn.BorderSize = 0;
            orman_btn.FlatAppearance.BorderSize = 0;
            orman_btn.FlatStyle = FlatStyle.Flat;
            orman_btn.ForeColor = Color.White;
            orman_btn.Location = new Point(1051, 122);
            orman_btn.Name = "orman_btn";
            orman_btn.Size = new Size(302, 171);
            orman_btn.TabIndex = 11;
            orman_btn.TextColor = Color.White;
            orman_btn.UseVisualStyleBackColor = false;
            orman_btn.Click += orman_btn_Click_1;
            // 
            // resalabtn
            // 
            resalabtn.Anchor = AnchorStyles.Top;
            resalabtn.BackColor = Color.FromArgb(224, 210, 209);
            resalabtn.BackgroundColor = Color.FromArgb(224, 210, 209);
            resalabtn.BackgroundImage = (Image)resources.GetObject("resalabtn.BackgroundImage");
            resalabtn.BackgroundImageLayout = ImageLayout.Stretch;
            resalabtn.BorderColor = Color.PaleVioletRed;
            resalabtn.BorderRadius = 20;
            resalabtn.BorderSize = 0;
            resalabtn.FlatAppearance.BorderSize = 0;
            resalabtn.FlatStyle = FlatStyle.Flat;
            resalabtn.ForeColor = Color.White;
            resalabtn.Location = new Point(580, 122);
            resalabtn.Name = "resalabtn";
            resalabtn.Size = new Size(302, 171);
            resalabtn.TabIndex = 10;
            resalabtn.TextColor = Color.White;
            resalabtn.UseVisualStyleBackColor = false;
            resalabtn.Click += resalabtn_Click_1;
            // 
            // helalbtn
            // 
            helalbtn.BackColor = Color.FromArgb(224, 210, 209);
            helalbtn.BackgroundColor = Color.FromArgb(224, 210, 209);
            helalbtn.BackgroundImage = (Image)resources.GetObject("helalbtn.BackgroundImage");
            helalbtn.BackgroundImageLayout = ImageLayout.Center;
            helalbtn.BorderColor = Color.PaleVioletRed;
            helalbtn.BorderRadius = 20;
            helalbtn.BorderSize = 0;
            helalbtn.FlatAppearance.BorderSize = 0;
            helalbtn.FlatStyle = FlatStyle.Flat;
            helalbtn.ForeColor = Color.White;
            helalbtn.Location = new Point(100, 122);
            helalbtn.Name = "helalbtn";
            helalbtn.Size = new Size(302, 171);
            helalbtn.TabIndex = 9;
            helalbtn.TextColor = Color.White;
            helalbtn.UseVisualStyleBackColor = false;
            helalbtn.Click += helalbtn_Click_1;
            // 
            // UHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1452, 740);
            Controls.Add(panelcontainer);
            Controls.Add(toppanel);
            MinimumSize = new Size(798, 597);
            Name = "UHome";
            Text = "UHome";
            Load += UHome_Load;
            toppanel.ResumeLayout(false);
            toppanel.PerformLayout();
            panelcontainer.ResumeLayout(false);
            panelcontainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel toppanel;
        private Panel panelcontainer;
        private RJControls.RJButton loginbtn;
        private Button signupbtn;
        private Label labelname;
        private RJControls.RJButton foodbank_btn;
        private RJControls.RJButton baheya_btn;
        private RJControls.RJButton magdy_btn;
        private RJControls.RJButton orman_btn;
        private RJControls.RJButton resalabtn;
        private RJControls.RJButton helalbtn;
        private RJControls.RJButton emailpicbtn;
        private Button contbtn;
        private Label emaill;
        private Label label1;
        private Label emaillbl;
        private RJControls.RJButton logoutbtn;
        private RJControls.RJButton logout_btn;
    }
}