namespace Donation_App.Designs
{
    partial class OrganizationInfo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            name = new Label();
            OrgName = new Label();
            panel2 = new Panel();
            Donors = new Label();
            label2 = new Label();
            panel3 = new Panel();
            Amount = new Label();
            label4 = new Label();
            Today = new Button();
            thisWeek = new Button();
            thisMonth = new Button();
            custom = new Button();
            orgDetails = new DataGridView();
            donorEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            donationBindingSource = new BindingSource(components);
            goHome = new Button();
            checkDonations = new ComboBox();
            panel4 = new Panel();
            label3 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orgDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)donationBindingSource).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(105, 158, 101);
            panel1.Controls.Add(name);
            panel1.Controls.Add(OrgName);
            panel1.Location = new Point(30, 25);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 89);
            panel1.TabIndex = 0;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            name.ForeColor = Color.White;
            name.Location = new Point(3, 52);
            name.Name = "name";
            name.Size = new Size(231, 27);
            name.TabIndex = 1;
            name.Text = "Organization Name";
            // 
            // OrgName
            // 
            OrgName.AutoSize = true;
            OrgName.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            OrgName.ForeColor = Color.White;
            OrgName.Location = new Point(0, 0);
            OrgName.Name = "OrgName";
            OrgName.Size = new Size(262, 27);
            OrgName.TabIndex = 0;
            OrgName.Text = "Name Of Organization";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(105, 158, 101);
            panel2.Controls.Add(Donors);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(33, 316);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 92);
            panel2.TabIndex = 1;
            // 
            // Donors
            // 
            Donors.AutoSize = true;
            Donors.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Donors.ForeColor = Color.White;
            Donors.Location = new Point(3, 52);
            Donors.Name = "Donors";
            Donors.Size = new Size(105, 27);
            Donors.TabIndex = 1;
            Donors.Text = "0 Person";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(215, 27);
            label2.TabIndex = 0;
            label2.Text = "Amount Of Donors";
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.AutoSize = true;
            panel3.BackColor = Color.FromArgb(105, 158, 101);
            panel3.Controls.Add(Amount);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(30, 171);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(265, 92);
            panel3.TabIndex = 2;
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Amount.ForeColor = Color.White;
            Amount.Location = new Point(3, 52);
            Amount.Name = "Amount";
            Amount.Size = new Size(75, 27);
            Amount.TabIndex = 1;
            Amount.Text = "0 EGP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(250, 27);
            label4.TabIndex = 0;
            label4.Text = "Amount Of Donations";
            // 
            // Today
            // 
            Today.Anchor = AnchorStyles.Top;
            Today.AutoSize = true;
            Today.BackColor = Color.FromArgb(105, 158, 101);
            Today.FlatAppearance.BorderColor = Color.FromArgb(105, 158, 101);
            Today.FlatStyle = FlatStyle.Flat;
            Today.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Today.ForeColor = Color.White;
            Today.Location = new Point(652, 16);
            Today.Margin = new Padding(3, 4, 3, 4);
            Today.Name = "Today";
            Today.Size = new Size(162, 39);
            Today.TabIndex = 3;
            Today.Text = " Today";
            Today.UseVisualStyleBackColor = false;
            Today.Click += Today_Click;
            // 
            // thisWeek
            // 
            thisWeek.Anchor = AnchorStyles.Top;
            thisWeek.AutoSize = true;
            thisWeek.BackColor = Color.FromArgb(105, 158, 101);
            thisWeek.FlatAppearance.BorderColor = Color.FromArgb(105, 158, 101);
            thisWeek.FlatStyle = FlatStyle.Flat;
            thisWeek.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thisWeek.ForeColor = Color.White;
            thisWeek.Location = new Point(803, 16);
            thisWeek.Margin = new Padding(3, 4, 3, 4);
            thisWeek.Name = "thisWeek";
            thisWeek.Size = new Size(160, 39);
            thisWeek.TabIndex = 6;
            thisWeek.Text = "This Week";
            thisWeek.UseVisualStyleBackColor = false;
            thisWeek.Click += thisWeek_Click;
            // 
            // thisMonth
            // 
            thisMonth.Anchor = AnchorStyles.Top;
            thisMonth.AutoSize = true;
            thisMonth.BackColor = Color.FromArgb(105, 158, 101);
            thisMonth.FlatAppearance.BorderColor = Color.FromArgb(105, 158, 101);
            thisMonth.FlatStyle = FlatStyle.Flat;
            thisMonth.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thisMonth.ForeColor = Color.White;
            thisMonth.Location = new Point(943, 16);
            thisMonth.Margin = new Padding(3, 4, 3, 4);
            thisMonth.Name = "thisMonth";
            thisMonth.Size = new Size(162, 39);
            thisMonth.TabIndex = 7;
            thisMonth.Text = "This month";
            thisMonth.UseVisualStyleBackColor = false;
            thisMonth.Click += thisMonth_Click;
            // 
            // custom
            // 
            custom.Anchor = AnchorStyles.Top;
            custom.AutoSize = true;
            custom.BackColor = Color.FromArgb(105, 158, 101);
            custom.FlatAppearance.BorderColor = Color.FromArgb(105, 158, 101);
            custom.FlatStyle = FlatStyle.Flat;
            custom.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            custom.ForeColor = Color.White;
            custom.Location = new Point(511, 16);
            custom.Margin = new Padding(3, 4, 3, 4);
            custom.Name = "custom";
            custom.Size = new Size(154, 39);
            custom.TabIndex = 8;
            custom.Text = "Custom";
            custom.UseVisualStyleBackColor = false;
            custom.Click += custom_Click;
            // 
            // orgDetails
            // 
            orgDetails.AllowUserToAddRows = false;
            orgDetails.AllowUserToDeleteRows = false;
            orgDetails.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(105, 158, 101);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            orgDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            orgDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orgDetails.AutoGenerateColumns = false;
            orgDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orgDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            orgDetails.BackgroundColor = SystemColors.Control;
            orgDetails.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(105, 158, 101);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            orgDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            orgDetails.ColumnHeadersHeight = 30;
            orgDetails.Columns.AddRange(new DataGridViewColumn[] { donorEmailDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn });
            orgDetails.DataSource = donationBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(105, 158, 101);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            orgDetails.DefaultCellStyle = dataGridViewCellStyle3;
            orgDetails.GridColor = SystemColors.ControlLight;
            orgDetails.Location = new Point(487, 199);
            orgDetails.Margin = new Padding(3, 4, 3, 4);
            orgDetails.Name = "orgDetails";
            orgDetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(105, 158, 101);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            orgDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            orgDetails.RowHeadersVisible = false;
            orgDetails.RowHeadersWidth = 62;
            orgDetails.RowTemplate.Height = 25;
            orgDetails.Size = new Size(747, 329);
            orgDetails.TabIndex = 9;
            // 
            // donorEmailDataGridViewTextBoxColumn
            // 
            donorEmailDataGridViewTextBoxColumn.DataPropertyName = "DonorEmail";
            donorEmailDataGridViewTextBoxColumn.HeaderText = "DonorEmail";
            donorEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            donorEmailDataGridViewTextBoxColumn.Name = "donorEmailDataGridViewTextBoxColumn";
            donorEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donationBindingSource
            // 
            donationBindingSource.DataSource = typeof(Models.Donation);
            // 
            // goHome
            // 
            goHome.AutoSize = true;
            goHome.BackColor = Color.FromArgb(120, 74, 94);
            goHome.FlatAppearance.BorderColor = Color.FromArgb(105, 158, 101);
            goHome.FlatStyle = FlatStyle.Flat;
            goHome.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            goHome.ForeColor = Color.White;
            goHome.Location = new Point(36, 557);
            goHome.Margin = new Padding(3, 4, 3, 4);
            goHome.Name = "goHome";
            goHome.Size = new Size(135, 52);
            goHome.TabIndex = 10;
            goHome.Text = "Log Out";
            goHome.UseVisualStyleBackColor = false;
            goHome.Click += goHome_Click;
            // 
            // checkDonations
            // 
            checkDonations.FormattingEnabled = true;
            checkDonations.Items.AddRange(new object[] { "0 To 500", "501 To 1000", "More..." });
            checkDonations.Location = new Point(387, 8);
            checkDonations.Margin = new Padding(3, 4, 3, 4);
            checkDonations.Name = "checkDonations";
            checkDonations.Size = new Size(153, 28);
            checkDonations.TabIndex = 11;
            checkDonations.SelectedIndexChanged += checkDonations_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.AutoScroll = true;
            panel4.AutoSize = true;
            panel4.BackColor = Color.FromArgb(105, 158, 101);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(checkDonations);
            panel4.Location = new Point(511, 91);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(594, 43);
            panel4.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 9);
            label3.Name = "label3";
            label3.Size = new Size(214, 23);
            label3.TabIndex = 0;
            label3.Text = "Amount of donations";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(105, 158, 101);
            button1.FlatAppearance.BorderColor = Color.FromArgb(105, 158, 101);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(526, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(154, 39);
            button1.TabIndex = 8;
            button1.Text = "Custom";
            button1.UseVisualStyleBackColor = false;
            button1.Click += custom_Click;
            // 
            // OrganizationInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._909261;
            ClientSize = new Size(1452, 740);
            Controls.Add(panel4);
            Controls.Add(goHome);
            Controls.Add(orgDetails);
            Controls.Add(button1);
            Controls.Add(custom);
            Controls.Add(thisMonth);
            Controls.Add(thisWeek);
            Controls.Add(Today);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrganizationInfo";
            Text = "OrganizationInfo";
            Load += OrganizationInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orgDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)donationBindingSource).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label OrgName;
        private Label name;
        private Panel panel2;
        private Label Donors;
        private Label label2;
        private Panel panel3;
        private Label Amount;
        private Label label4;
        private Button Today;
        private Button lastMonth;
        private Button thisWeek;
        private Button thisMonth;
        private Button custom;
        private DataGridView orgDetails;
        private Button goHome;
        private DataGridViewTextBoxColumn donorEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private BindingSource donationBindingSource;
        private ComboBox checkDonations;
        private Panel panel4;
        private Label label3;
        private Button button1;
    }
}