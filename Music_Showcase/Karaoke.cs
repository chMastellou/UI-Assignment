using Music_Showcase.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Showcase
{
    public partial class Karaoke : Form
    {
        List<Image> up_images;
        List<Image> down_images;
        int score;
        public Karaoke()
        {
            InitializeComponent();
            up_images = new List<Image>();
            up_images = [Resources.arrows_up_7242725, Resources.up_desat];
            down_images = new List<Image>();
            down_images = [Resources.arrows_down_7242731, Resources.down_desat];
            username.Text = GLOBALS.username;
            score = 0;
        }

        private void up1_Click(object sender, EventArgs e)
        {
            if (up1.Image != up_images[0])
            {
                up1.Image = up_images[0];
                down1.Image = down_images[1];
            }
            else
            {
                up1.Image = up_images[1];
            }

            up1.Enabled = false;
            down1.Enabled = false;
        }

        private void down1_Click(object sender, EventArgs e)
        {
            if (down1.Image != down_images[0])
            {
                down1.Image = down_images[0];
                up1.Image = up_images[1];
            }
            else
            {
                down1.Image = down_images[1];
            }

            up1.Enabled = false;
            down1.Enabled = false;
        }

        private void up2_Click(object sender, EventArgs e)
        {
            if (up2.Image != up_images[0])
            {
                up2.Image = up_images[0];
                down2.Image = down_images[1];
            }
            else
            {
                up2.Image = up_images[1];
            }

            up2.Enabled = false;
            down2.Enabled = false;
        }

        private void down2_Click(object sender, EventArgs e)
        {
            if (down2.Image != down_images[0])
            {
                down2.Image = down_images[0];
                up2.Image = up_images[1];
            }
            else
            {
                down2.Image = down_images[1];
            }

            up2.Enabled = false;
            down2.Enabled = false;
        }

        private void up3_Click(object sender, EventArgs e)
        {
            if (up3.Image != up_images[0])
            {
                up3.Image = up_images[0];
                down3.Image = down_images[1];
            }
            else
            {
                up3.Image = up_images[1];
            }

            up3.Enabled = false;
            down3.Enabled = false;
        }

        private void down3_Click(object sender, EventArgs e)
        {
            if (down3.Image != down_images[0])
            {
                down3.Image = down_images[0];
                up3.Image = up_images[1];
            }
            else
            {
                down3.Image = down_images[1];
            }

            up3.Enabled = false;
            down3.Enabled = false;
        }

        private void up4_Click(object sender, EventArgs e)
        {
            if (up4.Image != up_images[0])
            {
                up4.Image = up_images[0];
                down4.Image = down_images[1];
            }
            else
            {
                up4.Image = up_images[1];
            }

            up4.Enabled = false;
            down4.Enabled = false;
        }

        private void down4_Click(object sender, EventArgs e)
        {
            if (down4.Image != down_images[0])
            {
                down4.Image = down_images[0];
                up4.Image = up_images[1];
            }
            else
            {
                down4.Image = down_images[1];
            }

            up4.Enabled = false;
            down4.Enabled = false;
        }

        private void up5_Click(object sender, EventArgs e)
        {
            if (up5.Image != up_images[0])
            {
                up5.Image = up_images[0];
                down5.Image = down_images[1];
            }
            else
            {
                up5.Image = up_images[1];
            }

            up5.Enabled = false;
            down5.Enabled = false;
        }

        private void down5_Click(object sender, EventArgs e)
        {
            if (down5.Image != down_images[0])
            {
                down5.Image = down_images[0];
                up5.Image = up_images[1];
            }
            else
            {
                down5.Image = down_images[1];
            }

            up5.Enabled = false;
            down5.Enabled = false;
        }

        private void checkScore()
        {
            if ((up1.Image == up_images[0]) || (down1.Image == down_images[1]))
            {

                
            }

            if ((up2.Image == up_images[0]) || (down2.Image == down_images[1]))
            {
                
            }

            if ((up3.Image == up_images[0]) || (down3.Image == down_images[1]))
            {
                
            }

            if ((up4.Image == up_images[0]) || (down4.Image == down_images[1]))
            {
                
            }

            if ((up5.Image == up_images[0]) || (down5.Image == down_images[1]))
            {
                
            }
        }

    }
}
