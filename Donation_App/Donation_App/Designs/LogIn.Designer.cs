namespace Donation_App.Designs
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.email_lb = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.Label();
            this.LogIn_bt = new System.Windows.Forms.Button();
            this.reset_bt = new System.Windows.Forms.Button();
            this.newDonor_lb = new System.Windows.Forms.Label();
            this.SignUp_ln = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.backHome_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email_lb
            // 
            this.email_lb.AutoSize = true;
            this.email_lb.BackColor = System.Drawing.Color.Transparent;
            this.email_lb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email_lb.Location = new System.Drawing.Point(580, 332);
            this.email_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email_lb.Name = "email_lb";
            this.email_lb.Size = new System.Drawing.Size(88, 34);
            this.email_lb.TabIndex = 1;
            this.email_lb.Text = "Email";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(830, 332);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(2);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(296, 31);
            this.emailtxt.TabIndex = 2;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(830, 445);
            this.passtxt.Margin = new System.Windows.Forms.Padding(2);
            this.passtxt.MaxLength = 10;
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(296, 31);
            this.passtxt.TabIndex = 4;
            // 
            // passwordtxt
            // 
            this.passwordtxt.AutoSize = true;
            this.passwordtxt.BackColor = System.Drawing.Color.Transparent;
            this.passwordtxt.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordtxt.Location = new System.Drawing.Point(571, 440);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(140, 34);
            this.passwordtxt.TabIndex = 3;
            this.passwordtxt.Text = "Password";
            // 
            // LogIn_bt
            // 
            this.LogIn_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(158)))), ((int)(((byte)(101)))));
            this.LogIn_bt.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogIn_bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogIn_bt.Location = new System.Drawing.Point(968, 679);
            this.LogIn_bt.Margin = new System.Windows.Forms.Padding(2);
            this.LogIn_bt.Name = "LogIn_bt";
            this.LogIn_bt.Size = new System.Drawing.Size(176, 65);
            this.LogIn_bt.TabIndex = 5;
            this.LogIn_bt.Text = "Log In";
            this.LogIn_bt.UseVisualStyleBackColor = false;
            this.LogIn_bt.Click += new System.EventHandler(this.LogIn_bt_Click_1);
            // 
            // reset_bt
            // 
            this.reset_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(158)))), ((int)(((byte)(101)))));
            this.reset_bt.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset_bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reset_bt.Location = new System.Drawing.Point(1232, 680);
            this.reset_bt.Margin = new System.Windows.Forms.Padding(2);
            this.reset_bt.Name = "reset_bt";
            this.reset_bt.Size = new System.Drawing.Size(170, 65);
            this.reset_bt.TabIndex = 6;
            this.reset_bt.Text = "Reset";
            this.reset_bt.UseVisualStyleBackColor = false;
            this.reset_bt.Click += new System.EventHandler(this.reset_bt_Click_1);
            // 
            // newDonor_lb
            // 
            this.newDonor_lb.AutoSize = true;
            this.newDonor_lb.BackColor = System.Drawing.Color.Transparent;
            this.newDonor_lb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.newDonor_lb.Location = new System.Drawing.Point(698, 204);
            this.newDonor_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newDonor_lb.Name = "newDonor_lb";
            this.newDonor_lb.Size = new System.Drawing.Size(248, 43);
            this.newDonor_lb.TabIndex = 7;
            this.newDonor_lb.Text = "New Donor ?";
            // 
            // SignUp_ln
            // 
            this.SignUp_ln.AutoSize = true;
            this.SignUp_ln.BackColor = System.Drawing.Color.Transparent;
            this.SignUp_ln.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SignUp_ln.LinkColor = System.Drawing.Color.Crimson;
            this.SignUp_ln.Location = new System.Drawing.Point(1005, 204);
            this.SignUp_ln.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignUp_ln.Name = "SignUp_ln";
            this.SignUp_ln.Size = new System.Drawing.Size(151, 43);
            this.SignUp_ln.TabIndex = 8;
            this.SignUp_ln.TabStop = true;
            this.SignUp_ln.Text = "Sign Up";
            this.SignUp_ln.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUp_ln_LinkClicked_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(559, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Get Started From Log In Below";
            // 
            // backHome_btn
            // 
            this.backHome_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.backHome_btn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backHome_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backHome_btn.Location = new System.Drawing.Point(405, 679);
            this.backHome_btn.Margin = new System.Windows.Forms.Padding(2);
            this.backHome_btn.Name = "backHome_btn";
            this.backHome_btn.Size = new System.Drawing.Size(168, 66);
            this.backHome_btn.TabIndex = 10;
            this.backHome_btn.Text = "Home";
            this.backHome_btn.UseVisualStyleBackColor = false;
            this.backHome_btn.Click += new System.EventHandler(this.backHome_btn_Click_1);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1815, 925);
            this.Controls.Add(this.backHome_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUp_ln);
            this.Controls.Add(this.newDonor_lb);
            this.Controls.Add(this.reset_bt);
            this.Controls.Add(this.LogIn_bt);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.email_lb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label email_lb;
        private TextBox emailtxt;
        private TextBox passtxt;
        private Label passwordtxt;
        private Button LogIn_bt;
        private Button reset_bt;
        private Label newDonor_lb;
        private LinkLabel SignUp_ln;
        private Label label1;
        private Button backHome_btn;
    }
}