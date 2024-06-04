using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donation_App.UserControls
{
    public partial class UC_home_org3 : UserControl
    {
        public UC_home_org3()
        {
            InitializeComponent();
        }
        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if (imageNumber == 10)
            {
                imageNumber = 1;
            }
            pic_box.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void slidPic_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
