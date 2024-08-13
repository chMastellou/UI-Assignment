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
    public partial class DJ : Form
    {

        public DJ()
        {
            InitializeComponent();
            AttachClickEventToButtons();


        }

        private void ToggleButtonText(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (button.Text == "ON")
                {
                    button.Text = "";
                }
                else
                {
                    button.Text = "ON";
                }
            }
        }
        private void AttachClickEventToButtons()
        {
            foreach (Control control in tableLayoutPanel3.Controls) // Assuming your buttons are in a FlowLayoutPanel
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Click += new EventHandler(ToggleButtonText);
                }
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void flowLayoutPanel1_SizeChanged_1(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Width = flowLayoutPanel1.ClientSize.Width - control.Margin.Left - control.Margin.Right;
            }
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int value = Int32.Parse(textBox1.Text);
                    if (value < 220 || value > 400)
                    {
                        DialogResult result = MessageBox.Show("Μόνο ακαίραιοι στην κλίμακα 220-400 επιτρέπονται!", "ΟΚ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        trackBar1.Value = value;
                    }
                }
                catch (FormatException)
                {
                    DialogResult result = MessageBox.Show("Μόνο ακαίραιοι στην κλίμακα 220-400 επιτρέπονται!", "ΟΚ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.magnifying_glass_12875450;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.magnifying_glass_12875481;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Text = "Αναζήτηση..";
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            label58.Text = trackBar2.Value.ToString() + "%";
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.play_button_9546366;
            label60.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.play_button_9545687;
            label60.Visible = false;
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox5.Text == string.Empty)
            {
                textBox5.Text = "Τίτλος Τραγουδιού Όνομα Καλλιτέχνη ΒPM: 230";
            }
            textBox5.Text = textBox5.Text.Substring(1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (label3.Text == string.Empty)
            {
                label3.Text = "Τίτλος Τραγουδιού Όνομα Καλλιτέχνη ΒPM: 230";
            }
            label3.Text = label3.Text.Substring(1);
        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.microphone_9126943;
            label4.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.microphone_9126928;
            label4.Visible = false;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            label61.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            label61.Visible = false;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            label62.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            label62.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
