﻿namespace Donation_App.Designs
{
    partial class FoodBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodBank));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.top_panel = new System.Windows.Forms.Panel();
            this.about_btn = new Donation_App.RJControls.RJButton();
            this.back_btn = new Donation_App.RJControls.RJButton();
            this.home_btn = new Donation_App.RJControls.RJButton();
            this.Donation_Button = new Donation_App.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 129);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1815, 796);
            this.panelContainer.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.top_panel.Controls.Add(this.about_btn);
            this.top_panel.Controls.Add(this.back_btn);
            this.top_panel.Controls.Add(this.home_btn);
            this.top_panel.Controls.Add(this.Donation_Button);
            this.top_panel.Controls.Add(this.pictureBox1);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1815, 129);
            this.top_panel.TabIndex = 19;
            // 
            // about_btn
            // 
            this.about_btn.BackColor = System.Drawing.Color.Transparent;
            this.about_btn.BackgroundColor = System.Drawing.Color.Transparent;
            this.about_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(114)))), ((int)(((byte)(58)))));
            this.about_btn.BorderRadius = 30;
            this.about_btn.BorderSize = 2;
            this.about_btn.FlatAppearance.BorderSize = 0;
            this.about_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.about_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(114)))), ((int)(((byte)(58)))));
            this.about_btn.Location = new System.Drawing.Point(1015, 71);
            this.about_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(202, 58);
            this.about_btn.TabIndex = 18;
            this.about_btn.Text = "About Us";
            this.about_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(114)))), ((int)(((byte)(58)))));
            this.about_btn.UseVisualStyleBackColor = false;
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(114)))), ((int)(((byte)(58)))));
            this.back_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(114)))), ((int)(((byte)(58)))));
            this.back_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.back_btn.BorderRadius = 30;
            this.back_btn.BorderSize = 0;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(1635, 28);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(104, 59);
            this.back_btn.TabIndex = 17;
            this.back_btn.Text = "Back";
            this.back_btn.TextColor = System.Drawing.Color.White;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click_1);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_btn.BackgroundColor = System.Drawing.Color.Transparent;
            this.home_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(114)))), ((int)(((byte)(58)))));
            this.home_btn.BorderRadius = 30;
            this.home_btn.BorderSize = 2;
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.home_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(114)))), ((int)(((byte)(58)))));
            this.home_btn.Location = new System.Drawing.Point(824, 72);
            this.home_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(192, 55);
            this.home_btn.TabIndex = 17;
            this.home_btn.Text = "Home";
            this.home_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(114)))), ((int)(((byte)(58)))));
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // Donation_Button
            // 
            this.Donation_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(114)))), ((int)(((byte)(58)))));
            this.Donation_Button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(114)))), ((int)(((byte)(58)))));
            this.Donation_Button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Donation_Button.BorderRadius = 30;
            this.Donation_Button.BorderSize = 0;
            this.Donation_Button.FlatAppearance.BorderSize = 0;
            this.Donation_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Donation_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Donation_Button.ForeColor = System.Drawing.Color.White;
            this.Donation_Button.Location = new System.Drawing.Point(520, 28);
            this.Donation_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Donation_Button.Name = "Donation_Button";
            this.Donation_Button.Size = new System.Drawing.Size(228, 59);
            this.Donation_Button.TabIndex = 13;
            this.Donation_Button.Text = "Donation Now";
            this.Donation_Button.TextColor = System.Drawing.Color.White;
            this.Donation_Button.UseVisualStyleBackColor = false;
            this.Donation_Button.Click += new System.EventHandler(this.Donation_Button_Click);
            // 
            // FoodBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 925);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.top_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FoodBank";
            this.Text = "ORG5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.top_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContainer;
        private PictureBox pictureBox1;
        private Panel top_panel;
        private RJControls.RJButton Donation_Button;
        private RJControls.RJButton back_btn;
        private RJControls.RJButton about_btn;
        private RJControls.RJButton home_btn;
    }
}