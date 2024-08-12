namespace Music_Showcase
{
    partial class Cafe_Form
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
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(357, 70);
            label1.Name = "label1";
            label1.Size = new Size(144, 38);
            label1.TabIndex = 0;
            label1.Text = "Cafe Form";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.InactiveCaptionText;
            checkedListBox1.BorderStyle = BorderStyle.FixedSingle;
            checkedListBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBox1.ForeColor = SystemColors.InactiveBorder;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Άσπρο", "Κόκκινο", "Κίτρινο", "Πορτοκαλί", "Πράσινο", "Τιρκουάζ", "Ρόζ", "Μοβ", "Μπλε", "Γαλάζιο" });
            checkedListBox1.Location = new Point(347, 240);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(178, 292);
            checkedListBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(339, 180);
            label2.Name = "label2";
            label2.Size = new Size(186, 31);
            label2.TabIndex = 2;
            label2.Text = "Χρώμα Φώτων:";
            // 
            // Cafe_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1078, 773);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cafe_Form";
            Text = "Cefe_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label label2;
    }
}