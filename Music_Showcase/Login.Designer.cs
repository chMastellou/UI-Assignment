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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(78, 133);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
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
            label3.Location = new Point(78, 232);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 2;
            label3.Text = "Ιδιότητα";
            // 
            // usernameTextbox
            // 
            usernameTextbox.Font = new Font("Tahoma", 12F);
            usernameTextbox.Location = new Point(78, 161);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(290, 27);
            usernameTextbox.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DodgerBlue;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.MidnightBlue;
            loginButton.Location = new Point(131, 358);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(184, 37);
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
            userTypeBox.Location = new Point(78, 260);
            userTypeBox.Name = "userTypeBox";
            userTypeBox.Size = new Size(290, 27);
            userTypeBox.TabIndex = 6;
            userTypeBox.Text = "Επισκέπτης";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Untitled;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = Properties.Resources.Untitled;
            pictureBox1.Location = new Point(78, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(465, 456);
            Controls.Add(pictureBox1);
            Controls.Add(userTypeBox);
            Controls.Add(loginButton);
            Controls.Add(usernameTextbox);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}