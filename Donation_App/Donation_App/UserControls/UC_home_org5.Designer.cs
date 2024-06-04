namespace Donation_App.UserControls
{
    partial class UC_home_org5
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_home_org5));
            panel1 = new Panel();
            pic_box = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_box).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pic_box);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 552);
            panel1.TabIndex = 2;
            // 
            // pic_box
            // 
            pic_box.BackColor = Color.Transparent;
            pic_box.Dock = DockStyle.Fill;
            pic_box.Image = (Image)resources.GetObject("pic_box.Image");
            pic_box.Location = new Point(0, 0);
            pic_box.Name = "pic_box";
            pic_box.Size = new Size(1411, 552);
            pic_box.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_box.TabIndex = 0;
            pic_box.TabStop = false;
            // 
            // UC_home_org5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_home_org5";
            Size = new Size(1411, 552);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_box).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pic_box;
    }
}
