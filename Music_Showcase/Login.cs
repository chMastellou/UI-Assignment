using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Showcase
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(usernameTextbox.Text))
            {
                GLOBALS.username = usernameTextbox.Text;
                GLOBALS.role = userTypeBox.Text;
                Container container = new Container();
                container.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Δεν έχετε επιλέξει ψευδώνυμο!", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Exit button
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.log_out_full;
            label1.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.log_out;
            label1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
