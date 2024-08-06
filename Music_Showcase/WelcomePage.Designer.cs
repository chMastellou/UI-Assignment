namespace Music_Showcase
{
    partial class WelcomePage
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
            pictureBox9 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.Top;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.Cursor = Cursors.Hand;
            pictureBox9.Image = Properties.Resources.text_1722939596455;
            pictureBox9.Location = new Point(136, 256);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(768, 50);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 4;
            pictureBox9.TabStop = false;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.Download_free_Dark_Purple_Color_background_images;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1078, 773);
            Controls.Add(pictureBox9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WelcomePage";
            Text = "WelcomePage";
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox9;
    }
}