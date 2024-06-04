namespace Donation_App.UserControls
{
    partial class UC_home_org1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_home_org1));
            pic = new Panel();
            pictureBox = new PictureBox();
            pic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pic
            // 
            pic.BackgroundImageLayout = ImageLayout.Stretch;
            pic.Controls.Add(pictureBox);
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(1470, 715);
            pic.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(2, 2, 2, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1470, 715);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // UC_home_org1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pic);
            Name = "UC_home_org1";
            Size = new Size(1470, 715);
            pic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pic;
        private PictureBox pictureBox;
    }
}
