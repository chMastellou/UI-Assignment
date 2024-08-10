using AxWMPLib;
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
    public partial class Video_File : Form
    {
        List<Image> playButton_images;
        public Video_File()
        {
            InitializeComponent();
            playButton_images = new List<Image>();
            playButton_images = [Properties.Resources.play, Properties.Resources.pause];
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void ac_Click(object sender, EventArgs e)
        {
            ac.Image = Resources.EF;
            bg3.Image = Resources.bg3_desat;
            skyrim.Image = Resources.bear_desat;
            gow.Image = Resources.gow_desat;
            WindowsMediaPlayer.URL = @"https://youtu.be/_UGcwmafuR0?si=Bq0QxhZjLgMQNTIM";
        }
        
        private void bg3_Click(object sender, EventArgs e)
        {
            ac.Image = Resources.ac_desat;
            bg3.Image = Resources.BG;
            skyrim.Image = Resources.bear_desat;
            gow.Image = Resources.gow_desat;
            WindowsMediaPlayer.URL = @"https://youtu.be/xJtOTvtcpso?si=v3rbg7_z7LGaSOeY";
        }

        private void skyrim_Click(object sender, EventArgs e)
        {
            ac.Image = Resources.ac_desat;
            bg3.Image = Resources.bg3_desat;
            skyrim.Image = Resources.bear;
            gow.Image = Resources.gow_desat;
            WindowsMediaPlayer.URL = @"https://youtu.be/_EyLjDEn65U?si=id04r37f2FDZ6pBe";
        }

        private void gow_Click(object sender, EventArgs e)
        {
            ac.Image = Resources.ac_desat;
            bg3.Image = Resources.bg3_desat;
            skyrim.Image = Resources.bear_desat;
            gow.Image = Resources.MOM;
            WindowsMediaPlayer.URL = @"https://youtu.be/U4bhR_tMUkc?si=ljEIYF5rPemiwpta";
        }

       
    }
}
