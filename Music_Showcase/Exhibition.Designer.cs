namespace Music_Showcase
{
    partial class Exhibition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            albumCover = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label7 = new Label();
            titleCheck = new PictureBox();
            videogameCheck = new PictureBox();
            genreCheck = new PictureBox();
            albumCheck = new PictureBox();
            artistCheck = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)albumCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)titleCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videogameCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genreCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)albumCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)artistCheck).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 23.7913036F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(392, 51);
            label1.TabIndex = 0;
            label1.Text = "ΔΙΑΧΕΙΡΙΣΗ ΕΚΘΕΣΗΣ";
            // 
            // albumCover
            // 
            albumCover.Location = new Point(668, 74);
            albumCover.Name = "albumCover";
            albumCover.Size = new Size(350, 350);
            albumCover.SizeMode = PictureBoxSizeMode.StretchImage;
            albumCover.TabIndex = 1;
            albumCover.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.8956518F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 87);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 2;
            label2.Text = "Τίτλος τραγουδιού";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.0173912F);
            textBox1.Location = new Point(38, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 29);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.0173912F);
            textBox2.Location = new Point(38, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 29);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.8956518F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 164);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 4;
            label3.Text = "Καλλιτέχνης";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.8956518F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(38, 331);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 6;
            label4.Text = "Είδος";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10.0173912F);
            textBox4.Location = new Point(38, 273);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(225, 29);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.8956518F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(38, 245);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 8;
            label5.Text = "Άλμπουμ";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 161);
            textBox5.Location = new Point(668, 464);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(350, 29);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label6.ForeColor = Color.White;
            label6.Location = new Point(668, 436);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 11;
            label6.Text = "Εξώφυλλο";
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 161);
            button1.ForeColor = Color.FromArgb(72, 46, 109);
            button1.Location = new Point(38, 556);
            button1.Name = "button1";
            button1.Size = new Size(225, 59);
            button1.TabIndex = 12;
            button1.Text = "ΠΡΟΣΘΗΚΗ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.0173912F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ποπ", "Ροκ", "Τζαζ", "Κλασική", "Μέταλ" });
            comboBox1.Location = new Point(38, 359);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 29);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.0173912F);
            textBox3.Location = new Point(38, 446);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(225, 29);
            textBox3.TabIndex = 15;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11.8956518F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(38, 418);
            label7.Name = "label7";
            label7.Size = new Size(136, 25);
            label7.TabIndex = 14;
            label7.Text = "Βιντεοπαιχνίδι";
            // 
            // titleCheck
            // 
            titleCheck.BackColor = Color.Transparent;
            titleCheck.Image = Properties.Resources.check_1053156;
            titleCheck.Location = new Point(286, 106);
            titleCheck.Margin = new Padding(3, 4, 3, 4);
            titleCheck.Name = "titleCheck";
            titleCheck.Size = new Size(35, 35);
            titleCheck.SizeMode = PictureBoxSizeMode.StretchImage;
            titleCheck.TabIndex = 16;
            titleCheck.TabStop = false;
            titleCheck.Visible = false;
            // 
            // videogameCheck
            // 
            videogameCheck.BackColor = Color.Transparent;
            videogameCheck.Image = Properties.Resources.check_1053156;
            videogameCheck.Location = new Point(286, 440);
            videogameCheck.Margin = new Padding(3, 4, 3, 4);
            videogameCheck.Name = "videogameCheck";
            videogameCheck.Size = new Size(35, 35);
            videogameCheck.SizeMode = PictureBoxSizeMode.StretchImage;
            videogameCheck.TabIndex = 17;
            videogameCheck.TabStop = false;
            videogameCheck.Visible = false;
            // 
            // genreCheck
            // 
            genreCheck.BackColor = Color.Transparent;
            genreCheck.Image = Properties.Resources.check_1053156;
            genreCheck.Location = new Point(286, 353);
            genreCheck.Margin = new Padding(3, 4, 3, 4);
            genreCheck.Name = "genreCheck";
            genreCheck.Size = new Size(35, 35);
            genreCheck.SizeMode = PictureBoxSizeMode.StretchImage;
            genreCheck.TabIndex = 18;
            genreCheck.TabStop = false;
            genreCheck.Visible = false;
            // 
            // albumCheck
            // 
            albumCheck.BackColor = Color.Transparent;
            albumCheck.Image = Properties.Resources.check_1053156;
            albumCheck.Location = new Point(286, 267);
            albumCheck.Margin = new Padding(3, 4, 3, 4);
            albumCheck.Name = "albumCheck";
            albumCheck.Size = new Size(35, 35);
            albumCheck.SizeMode = PictureBoxSizeMode.StretchImage;
            albumCheck.TabIndex = 19;
            albumCheck.TabStop = false;
            albumCheck.Visible = false;
            // 
            // artistCheck
            // 
            artistCheck.BackColor = Color.Transparent;
            artistCheck.Image = Properties.Resources.check_1053156;
            artistCheck.Location = new Point(286, 186);
            artistCheck.Margin = new Padding(3, 4, 3, 4);
            artistCheck.Name = "artistCheck";
            artistCheck.Size = new Size(35, 35);
            artistCheck.SizeMode = PictureBoxSizeMode.StretchImage;
            artistCheck.TabIndex = 20;
            artistCheck.TabStop = false;
            artistCheck.Visible = false;
            // 
            // Exhibition
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.half_res_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1060, 689);
            Controls.Add(artistCheck);
            Controls.Add(albumCheck);
            Controls.Add(genreCheck);
            Controls.Add(videogameCheck);
            Controls.Add(titleCheck);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(albumCover);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Exhibition";
            Text = "Exhibition";
            ((System.ComponentModel.ISupportInitialize)albumCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)titleCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)videogameCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)genreCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)albumCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)artistCheck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox albumCover;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label7;
        private PictureBox titleCheck;
        private PictureBox videogameCheck;
        private PictureBox genreCheck;
        private PictureBox albumCheck;
        private PictureBox artistCheck;
    }
}