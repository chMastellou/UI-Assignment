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
    }
}
