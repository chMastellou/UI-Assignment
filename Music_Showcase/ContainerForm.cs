using System.Windows.Forms;

namespace Music_Showcase
{
    public partial class Container : Form
    {
        private WelcomePage welcomePage;
        private PictureBox selectedPictureBox;

        // Dictionaries to store the images for each PictureBox
        private Dictionary<PictureBox, Image> nonSelectedImages;
        private Dictionary<PictureBox, Image> selectedImages;
        private Dictionary<PictureBox, Label> pictureBoxLabels;
        private Dictionary<PictureBox, Panel> pictureBoxPanels;

        public Container()
        {
            InitializeComponent();
            InitializePictureBoxes();

            this.welcomePage = new WelcomePage();

            if (GLOBALS.role == "Επισκέπτης")
            {
                // Απενεργοποίησε τη Διαχείριση Έκθεσης
                panel12.Enabled = false;
                panel12.Visible = false;
                LoadForm(welcomePage);
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
        private void InitializePictureBoxes()
        {
            // Initialize the dictionaries
            nonSelectedImages = new Dictionary<PictureBox, Image>();
            selectedImages = new Dictionary<PictureBox, Image>();
            pictureBoxLabels = new Dictionary<PictureBox, Label>();
            pictureBoxPanels = new Dictionary<PictureBox, Panel>();

            // Assuming you have three PictureBoxes: pictureBox1, pictureBox2, and pictureBox3
            // Add the non-selected and selected images for each PictureBox
            //Αρχείο
            nonSelectedImages[pictureBox2] = Properties.Resources.video_9327754;
            selectedImages[pictureBox2] = Properties.Resources.video_9327764;
            pictureBoxLabels[pictureBox2] = label1;
            pictureBoxPanels[pictureBox2] = panel3;

            //Καφέ
            nonSelectedImages[pictureBox3] = Properties.Resources.fasting_7255651;
            selectedImages[pictureBox3] = Properties.Resources.fasting_7301163;
            pictureBoxLabels[pictureBox3] = label2;
            pictureBoxPanels[pictureBox3] = panel4;
            //DJ
            nonSelectedImages[pictureBox4] = Properties.Resources.speaker_5204532;
            selectedImages[pictureBox4] = Properties.Resources.speaker_5204318;
            pictureBoxLabels[pictureBox4] = label3;
            pictureBoxPanels[pictureBox4] = panel5;
            //Διαχείριση Συσκευών
            nonSelectedImages[pictureBox5] = Properties.Resources.electronic_device_5772459;
            selectedImages[pictureBox5] = Properties.Resources.electronic_device_5772414;
            pictureBoxLabels[pictureBox5] = label4;
            pictureBoxPanels[pictureBox5] = panel6;
            //Εισητήρια
            nonSelectedImages[pictureBox6] = Properties.Resources.tag_6047453;
            selectedImages[pictureBox6] = Properties.Resources.tag_6047531;
            pictureBoxLabels[pictureBox6] = label5;
            pictureBoxPanels[pictureBox6] = panel7;
            //Διαχείριση Έκθεσης
            nonSelectedImages[pictureBox10] = Properties.Resources.projector_5723428;
            selectedImages[pictureBox10] = Properties.Resources.projector_5723558;
            pictureBoxLabels[pictureBox10] = label7;
            pictureBoxPanels[pictureBox10] = panel12;

            // Set the initial image
            pictureBox2.Image = nonSelectedImages[pictureBox2];
            pictureBox3.Image = nonSelectedImages[pictureBox3];
            pictureBox4.Image = nonSelectedImages[pictureBox4];
            pictureBox5.Image = nonSelectedImages[pictureBox5];
            pictureBox6.Image = nonSelectedImages[pictureBox6];
            pictureBox10.Image = nonSelectedImages[pictureBox10];

            // Add event handlers
            pictureBox2.MouseEnter += PictureBox_MouseEnter;
            pictureBox2.MouseLeave += PictureBox_MouseLeave;
            pictureBox2.Click += PictureBox_Click;

            pictureBox3.MouseEnter += PictureBox_MouseEnter;
            pictureBox3.MouseLeave += PictureBox_MouseLeave;
            pictureBox3.Click += PictureBox_Click;

            pictureBox4.MouseEnter += PictureBox_MouseEnter;
            pictureBox4.MouseLeave += PictureBox_MouseLeave;
            pictureBox4.Click += PictureBox_Click;

            pictureBox5.MouseEnter += PictureBox_MouseEnter;
            pictureBox5.MouseLeave += PictureBox_MouseLeave;
            pictureBox5.Click += PictureBox_Click;

            pictureBox6.MouseEnter += PictureBox_MouseEnter;
            pictureBox6.MouseLeave += PictureBox_MouseLeave;
            pictureBox6.Click += PictureBox_Click;

            pictureBox10.MouseEnter += PictureBox_MouseEnter;
            pictureBox10.MouseLeave += PictureBox_MouseLeave;
            pictureBox10.Click += PictureBox_Click;
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != selectedPictureBox)
            {
                pictureBox.Image = selectedImages[pictureBox];
                pictureBoxLabels[pictureBox].Visible = true;
                pictureBoxPanels[pictureBox].BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != selectedPictureBox)
            {
                pictureBox.Image = nonSelectedImages[pictureBox];
                pictureBoxLabels[pictureBox].Visible = false;
                pictureBoxPanels[pictureBox].BorderStyle = BorderStyle.None;
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (selectedPictureBox != null)
            {
                //το προηγούμενο κουμπί επιστρέφει στην αρχική του κατάσταση
                selectedPictureBox.Image = nonSelectedImages[selectedPictureBox];
                pictureBoxLabels[selectedPictureBox].Visible = false;
                pictureBoxPanels[selectedPictureBox].BorderStyle = BorderStyle.None;
            }

            selectedPictureBox = sender as PictureBox;
            selectedPictureBox.Image = selectedImages[selectedPictureBox];
            pictureBoxLabels[selectedPictureBox].Visible = true;
            pictureBoxPanels[selectedPictureBox].BorderStyle = BorderStyle.FixedSingle;

            if (selectedPictureBox == pictureBox2) //πήγαινε στο αρχείο
            {
                Video_File video_File = new Video_File();
                LoadForm(video_File);
            }
            else if (selectedPictureBox == pictureBox3) //πήγαινε στο καφέ - εστιατόριο
            {
                Cafe_Form cafe_form = new Cafe_Form();
                LoadForm(cafe_form);
            }
            else if (selectedPictureBox == pictureBox4) //πήγαινε στο DJ
            {
                DJ dj = new DJ();
                LoadForm(dj);
            }
            else if (selectedPictureBox == pictureBox5) //πήγαινε στη διαχείριση συσκευών
            {
                Device_Management dev_Manager = new Device_Management();
                LoadForm(dev_Manager);
            }
            else if (selectedPictureBox == pictureBox6) //πήγαινε στην αγορά εισητηρίων
            {
                Book_Tickets buy_Tickets = new Book_Tickets();
                LoadForm(buy_Tickets);
            } else if (selectedPictureBox == pictureBox10)
            {
                Exhibition exhibition = new Exhibition();
                LoadForm(exhibition);
            }

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

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            LoadForm(this.welcomePage);

            pictureBox2.Image = nonSelectedImages[pictureBox2];
            pictureBoxLabels[pictureBox2].Visible = false;
            pictureBoxPanels[pictureBox2].BorderStyle = BorderStyle.None;

            pictureBox3.Image = nonSelectedImages[pictureBox3];
            pictureBoxLabels[pictureBox3].Visible = false;
            pictureBoxPanels[pictureBox3].BorderStyle = BorderStyle.None;

            pictureBox4.Image = nonSelectedImages[pictureBox4];
            pictureBoxLabels[pictureBox4].Visible = false;
            pictureBoxPanels[pictureBox4].BorderStyle = BorderStyle.None;

            pictureBox5.Image = nonSelectedImages[pictureBox5];
            pictureBoxLabels[pictureBox5].Visible = false;
            pictureBoxPanels[pictureBox5].BorderStyle = BorderStyle.None;

            pictureBox6.Image = nonSelectedImages[pictureBox6];
            pictureBoxLabels[pictureBox6].Visible = false;
            pictureBoxPanels[pictureBox6].BorderStyle = BorderStyle.None;

        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

    }
}

