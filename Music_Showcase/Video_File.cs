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
            skyrim.Image = Resources.skyrim_desat;
            gow.Image = Resources.gow_desat;
            WindowsMediaPlayer.URL = @"https://youtu.be/xJtOTvtcpso?si=hRTSg0eNyLKXEw2J";
        }
        
        private void bg3_Click(object sender, EventArgs e)
        {
            ac.Image = Resources.ac_desat;
            bg3.Image = Resources.BG;
            skyrim.Image = Resources.skyrim_desat;
            gow.Image = Resources.gow_desat;
        }

        private void skyrim_Click(object sender, EventArgs e)
        {
            ac.Image = Resources.ac_desat;
            bg3.Image = Resources.bg3_desat;
            skyrim.Image = Resources.DB;
            gow.Image = Resources.gow_desat;
        }

        private void gow_Click(object sender, EventArgs e)
        {
            ac.Image = Resources.ac_desat;
            bg3.Image = Resources.bg3_desat;
            skyrim.Image = Resources.skyrim_desat;
            gow.Image = Resources.MOM;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (playButton.Image != playButton_images[1])
            {
                playButton.Image = playButton_images[1];
            }
            else
            {
                playButton.Image = playButton_images[0];
            }
        }
    }
}
