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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void songTitle_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Width = flowLayoutPanel1.ClientSize.Width - control.Margin.Left - control.Margin.Right;
            }
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

    }
}
