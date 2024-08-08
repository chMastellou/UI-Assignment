using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Music_Showcase
{
    public partial class Book_Tickets : Form
    {
        private string date;
        private string seat;
        private double discount;

        public Book_Tickets()
        {
            InitializeComponent();
            date = dateTimePicker1.Text;
            seat = seatBox.Text;
        }

        private void zoneSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatBox.Text = zoneSelection.Text + seatNo.Value;
            if (zoneCheck.Visible == false) { zoneCheck.Visible = true; }
        }

        private void seatNo_ValueChanged(object sender, EventArgs e)
        {
            seatBox.Text = zoneSelection.Text + seatNo.Value;
            if (numberCheck.Visible == false) { numberCheck.Visible = true; }
        }

        private void Book_Tickets_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker1.Text;
            if (dateCheck.Visible == false) { dateCheck.Visible = true; }
        }

        private void seatBox_TextChanged(object sender, EventArgs e)
        {
            seat = seatBox.Text;
        }

        private void discountSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (discountSelection.Text)
            {
                case "0% - ΚΑΝΟΝΙΚΟ":
                    discount = 0.0;
                    break;
                case "25% - ΦΟΙΤΗΤΙΚΟ / ΑΝΩ ΤΩΝ 65 ΕΤΩΝ":
                    discount = 0.25;
                    break;
                case "50% - ΑΜΕΑ":
                    discount = 0.5;
                    break;
            }
            if (discCheck.Visible == false) { discCheck.Visible = true; }
        }

        private void payment_Click(object sender, EventArgs e)
        {
            if ((dateCheck.Visible == false) || (zoneCheck.Visible == false) || (numberCheck.Visible == false) || (discCheck.Visible == false))
            {
                MessageBox.Show("Βεβαιωθείτε ότι έχετε συμπληρώσει όλες τις απαραίτητες πληροφορίες", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Payment payment = new Payment(date, seat, discount);
                //payment.Show();
                //this.Hide();
                
            }
        }
    }
}
