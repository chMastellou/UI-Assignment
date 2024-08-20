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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.help_8571582;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.help_8571522;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Construct the relative path to the CHM file
            // string relativePath = @"help\Game_Sound_Museum_Help.chm";
            //string fullPath = System.IO.Path.Combine(Application.StartupPath, relativePath);
            string fullPath = "file://C://Users//chmas//Desktop//Αλληλεπίδραση-Ανθρώπου-Υπολογιστή//UI-Assignment//Music_Showcase//help//Game_Sound_Museum_Help.chm";
            //string relativePath = @"..\..\..\..\UI-Assignment-v2\Music_Showcase\help\Game_Sound_Museum_Help.chm";
            //string fullPath = Path.Combine(Application.StartupPath, relativePath);

            try
            {
                // Open the CHM file using the full path
            //  System.Diagnostics.Process.Start(fullPath);
                //helpProvider1.HelpNamespace = fullPath;
                Help.ShowHelp(this, fullPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
