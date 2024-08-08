using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Music_Showcase
{
    public partial class Device_Management : Form
    {
        List<Image> sound_images;
        List<Image> speaker_images;
        List<Image> projector_images;
        List<Image> playButton_images;
        List<Image> projection_images;
        List<Image> laptop_images;
        List<Image> headphones_images;
        List<Image> mic_images;
        List<Image> ceiling_lights_img;
        List<Image> floor_lights_img;
        System.Windows.Forms.Timer marqueeTimer;

        public Device_Management()
        {
            InitializeComponent();
            sound_images = new List<Image>();
            sound_images = [Properties.Resources.sound_on, Properties.Resources.sound_off];
            speaker_images = new List<Image>();
            speaker_images = [Properties.Resources.speaker_on, Properties.Resources.speaker_off];
            projector_images = new List<Image>();
            projector_images = [Properties.Resources.projector_on, Properties.Resources.projector_off];
            playButton_images = new List<Image>();
            playButton_images = [Properties.Resources.play, Properties.Resources.pause];
            projection_images = new List<Image>();
            projection_images = [Properties.Resources.projection_on, Properties.Resources.projection_off];
            laptop_images = new List<Image>();
            laptop_images = [Properties.Resources.laptop_on, Properties.Resources.laptop_off];
            headphones_images = new List<Image>();
            headphones_images = [Properties.Resources.headphones_on, Properties.Resources.headphones_off];
            mic_images = new List<Image>();
            mic_images = [Properties.Resources.mic_on, Properties.Resources.mic_off];
            ceiling_lights_img = new List<Image>();
            ceiling_lights_img = [Properties.Resources.ceiling_lights_on, Properties.Resources.ceiling_lights_off];
            floor_lights_img = new List<Image>();
            floor_lights_img = [Properties.Resources.floor_lights_on, Properties.Resources.floor_lights_off];
        }


        private void frontLeftSpeaker_Click(object sender, EventArgs e)
        {
            if (frontLeftSound.Image != sound_images[0])
            {
                frontLeftSound.Image = sound_images[0];
                frontLeftSpeaker.Image = speaker_images[0];
                FLstate.Text = "Ανοιχτό";
            }
            else
            {
                frontLeftSound.Image = sound_images[1];
                frontLeftSpeaker.Image = speaker_images[1];
                FLstate.Text = "Κλειστό";
            }
        }

        private void frontRightSpeaker_Click(object sender, EventArgs e)
        {
            if (frontRightSound.Image != sound_images[0])
            {
                frontRightSound.Image = sound_images[0];
                frontRightSpeaker.Image = speaker_images[0];
                FRstate.Text = "Ανοιχτό";
            }
            else
            {
                frontRightSound.Image = sound_images[1];
                frontRightSpeaker.Image = speaker_images[1];
                FRstate.Text = "Κλειστό";
            }
        }

        private void backLeftSpeaker_Click(object sender, EventArgs e)
        {
            if (backLeftSound.Image != sound_images[0])
            {
                backLeftSound.Image = sound_images[0];
                backLeftSpeaker.Image = speaker_images[0];
                BLstate.Text = "Ανοιχτό";
            }
            else
            {
                backLeftSound.Image = sound_images[1];
                backLeftSpeaker.Image = speaker_images[1];
                BLstate.Text = "Κλειστό";
            }
        }

        private void backRightSpeaker_Click(object sender, EventArgs e)
        {
            if (backRightSound.Image != sound_images[0])
            {
                backRightSound.Image = sound_images[0];
                backRightSpeaker.Image = speaker_images[0];
                BRstate.Text = "Ανοιχτό";
            }
            else
            {
                backRightSound.Image = sound_images[1];
                backRightSpeaker.Image = speaker_images[1];
                BRstate.Text = "Κλειστό";
            }
        }

        private void projector_Click(object sender, EventArgs e)
        {
            if (projector.Image != projector_images[0])
            {
                projector.Image = projector_images[0];
                projectorState.Text = "Ενεργοποιημένος";
                projectionPanel.Visible = true;
                movieSelection.Enabled = true;
                movieSelection.ResetText();
                moviePoster.Image = null;
                marquee.Clear();
                playButton.Enabled = false;
            }
            else
            {
                projector.Image = projector_images[1];
                projectorState.Text = "Απενεργοποιημένος";
                projectionPanel.Visible = false;
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (playButton.Image != playButton_images[1])
            {
                playButton.Image = playButton_images[1];
                projection.Image = projection_images[0];
            }
            else
            {
                playButton.Image = playButton_images[0];
                projection.Image = projection_images[1];
            }
        }

        private void movie_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (movieSelection.Text)
            {
                case "Black Dynamite (2009)":
                    moviePoster.Image = Properties.Resources.black_dyn;
                    break;
                case "Airplane! (1980)":
                    moviePoster.Image = Properties.Resources.airplane;
                    break;
                case "Shakespeare In Love (1998)":
                    moviePoster.Image = Properties.Resources.shakespeare;
                    break;
                case "The Blues Brothers (1980)":
                    moviePoster.Image = Properties.Resources.blues_brothers;
                    break;
            }
            movieSelection.Enabled = false;
            marquee.Text = "ΠΑΙΖΕ ΤΩΡΑ: " + movieSelection.Text.ToUpper();
            marqueeTimer = new System.Windows.Forms.Timer();
            marqueeTimer.Interval = 200;
            marqueeTimer.Tick += marqueeTimer_Tick;
            marqueeTimer.Start();
            playButton.Enabled = true;
        }


        private void marqueeTimer_Tick(object sender, EventArgs e)
        {
            if (marquee.Text == string.Empty)
            {
                marquee.Text = "ΠΑΙΖΕΙ ΤΩΡΑ: " + movieSelection.Text.ToUpper();
            }

            marquee.Text = marquee.Text.Substring(1);
        }

        private void power_Click(object sender, EventArgs e)
        {
            if (laptop.Image != laptop_images[0])
            {
                laptop.Image = laptop_images[0];
                headphones.Enabled = true;
                mic.Enabled = true;
            }
            else
            {
                laptop.Image = laptop_images[1];
                mic.Image = mic_images[1];
                headphones.Image = headphones_images[1];
                headphones.Enabled = false;
                mic.Enabled = false;
            }
        }
        

        private void mic_Click(object sender, EventArgs e)
        {
            if (mic.Image != mic_images[0])
            {
                mic.Image = mic_images[0];
            }
            else
            {
                mic.Image = mic_images[1];
            }
        }

        private void headphones_Click(object sender, EventArgs e)
        {
            if (headphones.Image != headphones_images[0])
            {
                headphones.Image = headphones_images[0];
            }
            else
            {
                headphones.Image = headphones_images[1];
            }
        }


        private void thermometer_ValueChanged(object sender, EventArgs e)
        {
            temp.Text = thermometer.Value + "°";
        }

        private void ceiling_lights_Click(object sender, EventArgs e)
        {
            if (ceiling_lights.Image != ceiling_lights_img[0])
            {
                ceiling_lights.Image = ceiling_lights_img[0];
            }
            else
            {
                ceiling_lights.Image = ceiling_lights_img[1];
            }
        }

        private void floor_lights_Click(object sender, EventArgs e)
        {
            if (floor_lights.Image != floor_lights_img[0])
            {
                floor_lights.Image = floor_lights_img[0];
            }
            else
            {
                floor_lights.Image = floor_lights_img[1];
            }
        }
        
    }
}
