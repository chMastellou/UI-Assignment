namespace Music_Showcase
{
    partial class Login
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
            label2 = new Label();
            label3 = new Label();
            usernameTextbox = new TextBox();
            loginButton = new Button();
            userTypeBox = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(113, 332);
            label2.Name = "label2";
            label2.Size = new Size(129, 24);
            label2.TabIndex = 1;
            label2.Text = "Ψευδώνυμο";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(113, 464);
            label3.Name = "label3";
            label3.Size = new Size(96, 24);
            label3.TabIndex = 2;
            label3.Text = "Ιδιότητα";
            // 
            // usernameTextbox
            // 
            usernameTextbox.Font = new Font("Tahoma", 12F);
            usernameTextbox.Location = new Point(113, 370);
            usernameTextbox.Margin = new Padding(3, 4, 3, 4);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(331, 32);
            usernameTextbox.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Aqua;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.MidnightBlue;
            loginButton.Location = new Point(165, 642);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(210, 49);
            loginButton.TabIndex = 5;
            loginButton.Text = "ΕΙΣΟΔΟΣ";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // userTypeBox
            // 
            userTypeBox.Font = new Font("Tahoma", 12F);
            userTypeBox.FormattingEnabled = true;
            userTypeBox.Items.AddRange(new object[] { "Επισκέπτης", "Υπάλληλος" });
            userTypeBox.Location = new Point(113, 502);
            userTypeBox.Margin = new Padding(3, 4, 3, 4);
            userTypeBox.Name = "userTypeBox";
            userTypeBox.Size = new Size(331, 32);
            userTypeBox.TabIndex = 6;
            userTypeBox.Text = "Επισκέπτης";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.text_1722847228797;
            pictureBox1.InitialImage = Properties.Resources.Untitled;
            pictureBox1.Location = new Point(35, 158);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(495, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.log_out;
            pictureBox2.Location = new Point(503, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(425, 25);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 9;
            label1.Text = "Έξοδος";
            label1.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImage = Properties.Resources.Download_free_Dark_Purple_Color_background_images;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(564, 784);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(userTypeBox);
            Controls.Add(loginButton);
            Controls.Add(usernameTextbox);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox usernameTextbox;
        private Button loginButton;
        private ComboBox userTypeBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}