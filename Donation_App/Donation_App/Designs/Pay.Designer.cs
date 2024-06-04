namespace Donation_App.Designs
{
    partial class Pay
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
            this.paybtn = new System.Windows.Forms.Button();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.card_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cvc_txt = new System.Windows.Forms.TextBox();
            this.CVC_lb = new System.Windows.Forms.Label();
            this.card_nametxt = new System.Windows.Forms.TextBox();
            this.card_numlb = new System.Windows.Forms.Label();
            this.date_lb = new System.Windows.Forms.Label();
            this.datebx = new System.Windows.Forms.DateTimePicker();
            this.useremail_lb = new System.Windows.Forms.Label();
            this.dEmail_lb = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paybtn
            // 
            this.paybtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.paybtn.Font = new System.Drawing.Font("Urdu Typesetting", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paybtn.ForeColor = System.Drawing.Color.White;
            this.paybtn.Location = new System.Drawing.Point(868, 584);
            this.paybtn.Margin = new System.Windows.Forms.Padding(2);
            this.paybtn.Name = "paybtn";
            this.paybtn.Size = new System.Drawing.Size(160, 74);
            this.paybtn.TabIndex = 1;
            this.paybtn.Text = "Pay";
            this.paybtn.UseVisualStyleBackColor = false;
            this.paybtn.Click += new System.EventHandler(this.paybtn_Click_1);
            // 
            // amount_txt
            // 
            this.amount_txt.ForeColor = System.Drawing.Color.LightCoral;
            this.amount_txt.Location = new System.Drawing.Point(651, 189);
            this.amount_txt.Margin = new System.Windows.Forms.Padding(2);
            this.amount_txt.MaxLength = 5;
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(304, 31);
            this.amount_txt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(391, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
            // 
            // card_txt
            // 
            this.card_txt.ForeColor = System.Drawing.Color.LightCoral;
            this.card_txt.Location = new System.Drawing.Point(651, 334);
            this.card_txt.Margin = new System.Windows.Forms.Padding(2);
            this.card_txt.MaxLength = 16;
            this.card_txt.Name = "card_txt";
            this.card_txt.PasswordChar = '*';
            this.card_txt.Size = new System.Drawing.Size(304, 31);
            this.card_txt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(391, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Card Number";
            // 
            // cvc_txt
            // 
            this.cvc_txt.ForeColor = System.Drawing.Color.LightCoral;
            this.cvc_txt.Location = new System.Drawing.Point(651, 404);
            this.cvc_txt.Margin = new System.Windows.Forms.Padding(2);
            this.cvc_txt.MaxLength = 3;
            this.cvc_txt.Name = "cvc_txt";
            this.cvc_txt.PasswordChar = '*';
            this.cvc_txt.Size = new System.Drawing.Size(304, 31);
            this.cvc_txt.TabIndex = 11;
            // 
            // CVC_lb
            // 
            this.CVC_lb.AutoSize = true;
            this.CVC_lb.BackColor = System.Drawing.Color.Transparent;
            this.CVC_lb.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CVC_lb.ForeColor = System.Drawing.Color.SeaGreen;
            this.CVC_lb.Location = new System.Drawing.Point(391, 404);
            this.CVC_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CVC_lb.Name = "CVC_lb";
            this.CVC_lb.Size = new System.Drawing.Size(66, 36);
            this.CVC_lb.TabIndex = 10;
            this.CVC_lb.Text = "CVC";
            // 
            // card_nametxt
            // 
            this.card_nametxt.ForeColor = System.Drawing.Color.LightCoral;
            this.card_nametxt.Location = new System.Drawing.Point(651, 268);
            this.card_nametxt.Margin = new System.Windows.Forms.Padding(2);
            this.card_nametxt.MaxLength = 20;
            this.card_nametxt.Name = "card_nametxt";
            this.card_nametxt.Size = new System.Drawing.Size(304, 31);
            this.card_nametxt.TabIndex = 13;
            // 
            // card_numlb
            // 
            this.card_numlb.AutoSize = true;
            this.card_numlb.BackColor = System.Drawing.Color.Transparent;
            this.card_numlb.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.card_numlb.ForeColor = System.Drawing.Color.SeaGreen;
            this.card_numlb.Location = new System.Drawing.Point(391, 262);
            this.card_numlb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.card_numlb.Name = "card_numlb";
            this.card_numlb.Size = new System.Drawing.Size(157, 36);
            this.card_numlb.TabIndex = 12;
            this.card_numlb.Text = "Card Name";
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.BackColor = System.Drawing.Color.Transparent;
            this.date_lb.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date_lb.ForeColor = System.Drawing.Color.SeaGreen;
            this.date_lb.Location = new System.Drawing.Point(391, 480);
            this.date_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(216, 36);
            this.date_lb.TabIndex = 14;
            this.date_lb.Text = "Expiration Date";
            // 
            // datebx
            // 
            this.datebx.Location = new System.Drawing.Point(655, 480);
            this.datebx.Margin = new System.Windows.Forms.Padding(2);
            this.datebx.Name = "datebx";
            this.datebx.Size = new System.Drawing.Size(300, 31);
            this.datebx.TabIndex = 15;
            // 
            // useremail_lb
            // 
            this.useremail_lb.AutoSize = true;
            this.useremail_lb.BackColor = System.Drawing.Color.Transparent;
            this.useremail_lb.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.useremail_lb.ForeColor = System.Drawing.Color.SeaGreen;
            this.useremail_lb.Location = new System.Drawing.Point(401, 74);
            this.useremail_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.useremail_lb.Name = "useremail_lb";
            this.useremail_lb.Size = new System.Drawing.Size(86, 36);
            this.useremail_lb.TabIndex = 16;
            this.useremail_lb.Text = "Email";
            // 
            // dEmail_lb
            // 
            this.dEmail_lb.AutoSize = true;
            this.dEmail_lb.BackColor = System.Drawing.Color.Transparent;
            this.dEmail_lb.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dEmail_lb.ForeColor = System.Drawing.Color.LightCoral;
            this.dEmail_lb.Location = new System.Drawing.Point(651, 74);
            this.dEmail_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dEmail_lb.Name = "dEmail_lb";
            this.dEmail_lb.Size = new System.Drawing.Size(201, 38);
            this.dEmail_lb.TabIndex = 17;
            this.dEmail_lb.Text = "Donor Email";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.back_btn.Font = new System.Drawing.Font("Urdu Typesetting", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(1159, 584);
            this.back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(162, 74);
            this.back_btn.TabIndex = 18;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click_1);
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Donation_App.Properties.Resources._909263;
            this.ClientSize = new System.Drawing.Size(1815, 925);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.dEmail_lb);
            this.Controls.Add(this.useremail_lb);
            this.Controls.Add(this.datebx);
            this.Controls.Add(this.date_lb);
            this.Controls.Add(this.card_nametxt);
            this.Controls.Add(this.card_numlb);
            this.Controls.Add(this.cvc_txt);
            this.Controls.Add(this.CVC_lb);
            this.Controls.Add(this.card_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paybtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pay";
            this.Text = "Pay";
            this.Load += new System.EventHandler(this.Pay_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button paybtn;
        private TextBox amount_txt;
        private Label label2;
        private TextBox card_txt;
        private Label label3;
        private TextBox cvc_txt;
        private Label CVC_lb;
        private TextBox card_nametxt;
        private Label card_numlb;
        private Label date_lb;
        private DateTimePicker datebx;
        private Label useremail_lb;
        private Label dEmail_lb;
        private Button back_btn;
    }
}