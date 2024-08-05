namespace Music_Showcase
{
    public partial class Container : Form
    {
        private Video_File video_file;

        public Container()
        {
            InitializeComponent();
            this.video_file = new Video_File();

            if (GLOBALS.role == "Επισκέπτης")
            {
                // Απενεργοποίησε τη Διαχείριση Έκθεσης
                panel12.Enabled = false;
                panel12.Visible = false;
                LoadForm(video_file);
            }
            else // Eίναι Υπάλληλος
            {
                // Απενεργοποίησε το Αρχείο
                panel3.Enabled = false;
                panel3.Visible = false;
                // Απενεργοποίησε την αγορά εισητηρίων
                panel7.Enabled = false;
                panel7.Visible = false;

            }
        }


        //video

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.video_9327764;
            label1.Visible = true;
            panel3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.video_9327754;
            label1.Visible = false;
            panel3.BorderStyle = BorderStyle.None;
        }
        //food

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.fasting_7301163;
            label2.Visible = true;
            panel4.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.fasting_7255651;
            label2.Visible = false;
            panel4.BorderStyle = BorderStyle.None;
        }
        //DJ

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.speaker_5204318;
            label3.Visible = true;
            panel5.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.speaker_5204532;
            label3.Visible = false;
            panel5.BorderStyle = BorderStyle.None;
        }
        //Device manager
        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.electronic_device_5772414;
            label4.Visible = true;
            panel6.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.electronic_device_5772459;
            label4.Visible = false;
            panel6.BorderStyle = BorderStyle.None;
        }
        //tickets
        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.tag_6047531;
            label5.Visible = true;
            panel7.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.tag_6047453;
            label5.Visible = false;
            panel7.BorderStyle = BorderStyle.None;
        }
        //Exibition_Management
        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.projector_5723558;
            label7.Visible = true;
            panel12.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.projector_5723428;
            label7.Visible = false;
            panel12.BorderStyle = BorderStyle.None;
        }

        private void Container_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Container_Load(object sender, EventArgs e)
        {
            label6.Text = GLOBALS.username;
            role_label.Text = GLOBALS.role;

        }
        /*
 Η συνάρτηση που διαχειρίζεται το container panel (panel1)
 Δίνει στο panel1 έλεγχο στην φόρμα που δέχεται ως παράμετρο
 */
        public void LoadForm(Form form)
        {
            //if (this.panel1.Controls.Count > 0) this.panel1.Controls.RemoveAt(0);
            if (form is Video_File)
            {
                Form f = form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.panel11.Controls.Add(f);
                this.panel11.Tag = f;
                f.BringToFront();
                f.Show();
            }
            else
            {
                if (this.panel11.Controls.Count > 0) this.panel11.Controls.RemoveAt(0); //Αφαίρεσε ότι υπάρχει στο panel11
                Form f = form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.panel11.Controls.Add(f);
                this.panel11.Tag = f;
                f.BringToFront();
                f.Show();
            }

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Αποσύνδεση και Επιστροφή στην φόρμα Εισαγωγής?", "Return to login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }
        //User button functionality
        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.user_8017294;
            panel8.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.user_8051049;
            panel8.BorderStyle = BorderStyle.None;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.user_8017294;
            panel8.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.user_8051049;
            panel8.BorderStyle = BorderStyle.None;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Αποσύνδεση και Επιστροφή στην φόρμα Εισαγωγής?", "Return to login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }

        //Άνοιξε Αρχείο
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //visual feedback
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel4.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel6.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;

            LoadForm(this.video_file);
            
            
        }
        //Άνοιξε Καφέ Εστιατόριο
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //visual feedback
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.FromArgb(0, 0, 64);
            panel5.BackColor = Color.Transparent;
            panel6.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;

            Cafe_Form cafe_form = new Cafe_Form();
            LoadForm(cafe_form);

        }
        // Άνοιξε DJ
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //visual feedback
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
            panel5.BackColor = Color.FromArgb(0, 0, 64);
            panel6.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;

            DJ dj = new DJ();
            LoadForm(dj);
            
        }
        // Άνοιξε Διαχείριση Συσκευών
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //visual feedback
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel6.BackColor = Color.FromArgb(0, 0, 64);
            panel7.BackColor = Color.Transparent;

            Dev_Manager dev_Manager = new Dev_Manager();
            LoadForm(dev_Manager);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //visual feedback
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel6.BackColor = Color.Transparent;
            panel7.BackColor = Color.FromArgb(0, 0, 64);

            Buy_tickets buy_Tickets = new Buy_tickets();
            LoadForm(buy_Tickets);


        }
    }
}

