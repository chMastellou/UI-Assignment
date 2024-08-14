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
    public partial class Cafe_Form : Form
    {
        public Cafe_Form()
        {
            InitializeComponent();
            tabControl1.SizeMode = TabSizeMode.Fixed;

            // Initial adjustment
            AdjustTabSize();

            // Handle Resize event to adjust tabs when the form is resized
            this.Resize += new EventHandler(Form_Resize);
        }
        private void Form_Resize(object sender, EventArgs e)
        {
            // Adjust tab size when the form is resized
            AdjustTabSize();
        }
        private void AdjustTabSize()
        {
            // Calculate the available width for each tab
            int availableWidth = tabControl1.Width - (tabControl1.Padding.X * 2);

            // Calculate the width of each tab
            int tabWidth = availableWidth / tabControl1.TabCount;

            // Ensure the calculated width is not less than a certain minimum value
            tabWidth = Math.Max(tabWidth, 50); // 50 is an arbitrary minimum width, adjust as needed

            // Set the width and height of the tabs
            tabControl1.ItemSize = new Size(tabWidth, 40); // Adjust height as needed
        }
        private void Cafe_Form_Load(object sender, EventArgs e)
        {

        }

        private void Cafe_Form_SizeChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
