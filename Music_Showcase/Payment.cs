using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Showcase
{
    public partial class Payment : Form
    {

        public Payment(string date, string seat, double discount)
        {
            InitializeComponent();
            label7.Text = date;
            label8.Text = seat;

            switch (discount)
            {
                case 0.0:
                    label9.Text = "0%";
                    break;
                case 0.25:
                    label9.Text = "-25%";
                    break;
                case 0.5:
                    label9.Text = "-50%";
                    break;
            }
            double total = 20 - 20 * discount;
            label10.Text = total.ToString() + "€";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (nameCheck.Visible == false) { nameCheck.Visible = true; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (cardNumCheck.Visible == false) { cardNumCheck.Visible = true; }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (cvvCheck.Visible == false) { cvvCheck.Visible = true; }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (expDateCheck.Visible == false) { expDateCheck.Visible = true; }
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if ((nameCheck.Visible == false) || (cardNumCheck.Visible == false) || (cvvCheck.Visible == false) || (expDateCheck.Visible == false))
            {
                MessageBox.Show("Βεβαιωθείτε ότι έχετε συμπληρώσει όλες τις απαραίτητες πληροφορίες", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                MessageBox.Show("Η αγορά του εισιτηρίου σας έγινε με επιτυχία", "Ευχαριστούμε", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}



