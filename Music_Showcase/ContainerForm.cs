namespace Music_Showcase
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();


        }

        private void Container_Load(object sender, EventArgs e)
        {

        }

        private void Container_Load_1(object sender, EventArgs e)
        {

        }

        private void userTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Container_Load_2(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
