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
    public partial class Exhibition : Form
    {
        public Exhibition()
        {
            InitializeComponent();
            albumCover.Load("https://i.imgur.com/WBxSO79.jpeg");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                albumCover.Load(textBox5.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            titleCheck.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((titleCheck.Visible == false) || (artistCheck.Visible == false) || (albumCheck.Visible == false) || (genreCheck.Visible == false) || (videogameCheck.Visible == false) || (descCheck.Visible == false))
            {
                MessageBox.Show("Βεβαιωθείτε ότι έχετε συμπληρώσει όλες τις απαραίτητες πληροφορίες", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Το κομμάτι προστέθηκε στην έκθεση του μουσείου", "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            artistCheck.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            albumCheck.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            genreCheck.Visible = true;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            videogameCheck.Visible = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            descCheck.Visible = true;
        }
    }
}
