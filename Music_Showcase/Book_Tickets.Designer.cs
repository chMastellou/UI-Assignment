namespace Music_Showcase
{
    partial class Book_Tickets
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
            zoneSelection = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            seatNo = new NumericUpDown();
            seatBox = new Label();
            label6 = new Label();
            discountSelection = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            zoneCheck = new PictureBox();
            numberCheck = new PictureBox();
            discCheck = new PictureBox();
            dateCheck = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seatNo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)zoneCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateCheck).BeginInit();
            SuspendLayout();
            // 
            // zoneSelection
            // 
            zoneSelection.Anchor = AnchorStyles.Top;
            zoneSelection.Font = new Font("Microsoft Sans Serif", 12F);
            zoneSelection.FormattingEnabled = true;
            zoneSelection.Items.AddRange(new object[] { "Α", "Β", "Γ", "Δ", "Ε" });
            zoneSelection.Location = new Point(37, 279);
            zoneSelection.Margin = new Padding(3, 4, 3, 4);
            zoneSelection.Name = "zoneSelection";
            zoneSelection.Size = new Size(186, 33);
            zoneSelection.TabIndex = 0;
            zoneSelection.Text = "Α";
            zoneSelection.SelectedIndexChanged += zoneSelection_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(33, 34);
            label1.Name = "label1";
            label1.Size = new Size(417, 54);
            label1.TabIndex = 1;
            label1.Text = "ΕΚΔΟΣΗ ΕΙΣΙΤΗΡΙΩΝ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.7739134F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(33, 243);
            label2.Name = "label2";
            label2.Size = new Size(77, 31);
            label2.TabIndex = 2;
            label2.Text = "ΖΩΝΗ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.7739134F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(33, 134);
            label3.Name = "label3";
            label3.Size = new Size(168, 31);
            label3.TabIndex = 3;
            label3.Text = "ΗΜΕΡΟΜΗΝΙΑ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(72, 46, 109);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(141, 670);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(211, 71);
            button1.TabIndex = 5;
            button1.Text = " ΠΛΗΡΩΜΗ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += payment_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.FvDtL_eXwB8wEMb;
            pictureBox1.Location = new Point(541, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(647, 873);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.CalendarForeColor = Color.White;
            dateTimePicker1.CalendarMonthBackground = Color.Transparent;
            dateTimePicker1.CalendarTitleBackColor = Color.Transparent;
            dateTimePicker1.CalendarTitleForeColor = Color.White;
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(37, 169);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(315, 34);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.7739134F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(33, 472);
            label4.Name = "label4";
            label4.Size = new Size(219, 31);
            label4.TabIndex = 8;
            label4.Text = "ΕΠΙΛΕΓΜΕΝΗ ΘΕΣΗ:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.7739134F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(33, 358);
            label5.Name = "label5";
            label5.Size = new Size(190, 31);
            label5.TabIndex = 10;
            label5.Text = "ΑΡΙΘΜΟΣ ΘΕΣΗΣ";
            // 
            // seatNo
            // 
            seatNo.Anchor = AnchorStyles.Top;
            seatNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            seatNo.Location = new Point(37, 394);
            seatNo.Margin = new Padding(3, 4, 3, 4);
            seatNo.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            seatNo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            seatNo.Name = "seatNo";
            seatNo.Size = new Size(186, 34);
            seatNo.TabIndex = 11;
            seatNo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            seatNo.ValueChanged += seatNo_ValueChanged;
            // 
            // seatBox
            // 
            seatBox.Anchor = AnchorStyles.Top;
            seatBox.AutoSize = true;
            seatBox.BackColor = Color.Transparent;
            seatBox.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 161);
            seatBox.Location = new Point(238, 472);
            seatBox.Name = "seatBox";
            seatBox.Size = new Size(41, 31);
            seatBox.TabIndex = 12;
            seatBox.Text = "Α1";
            seatBox.TextChanged += seatBox_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.7739134F);
            label6.Location = new Point(33, 540);
            label6.Name = "label6";
            label6.Size = new Size(117, 31);
            label6.TabIndex = 13;
            label6.Text = "ΕΚΠΤΩΣΗ:";
            // 
            // discountSelection
            // 
            discountSelection.Anchor = AnchorStyles.Top;
            discountSelection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountSelection.FormattingEnabled = true;
            discountSelection.Items.AddRange(new object[] { "0% - ΚΑΝΟΝΙΚΟ", "25% - ΦΟΙΤΗΤΙΚΟ / ΑΝΩ ΤΩΝ 65 ΕΤΩΝ", "50% - ΑΜΕΑ" });
            discountSelection.Location = new Point(146, 541);
            discountSelection.Margin = new Padding(3, 4, 3, 4);
            discountSelection.Name = "discountSelection";
            discountSelection.Size = new Size(269, 36);
            discountSelection.TabIndex = 14;
            discountSelection.Text = "0% - ΚΑΝΟΝΙΚΟ";
            discountSelection.SelectedIndexChanged += discountSelection_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.2554741F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.7445259F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.Size = new Size(1191, 881);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(zoneCheck);
            panel1.Controls.Add(numberCheck);
            panel1.Controls.Add(discCheck);
            panel1.Controls.Add(dateCheck);
            panel1.Controls.Add(discountSelection);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(zoneSelection);
            panel1.Controls.Add(seatBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(seatNo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 873);
            panel1.TabIndex = 7;
            // 
            // zoneCheck
            // 
            zoneCheck.Anchor = AnchorStyles.Top;
            zoneCheck.Image = Properties.Resources.check_1053156;
            zoneCheck.Location = new Point(243, 279);
            zoneCheck.Margin = new Padding(3, 4, 3, 4);
            zoneCheck.Name = "zoneCheck";
            zoneCheck.Size = new Size(34, 40);
            zoneCheck.SizeMode = PictureBoxSizeMode.StretchImage;
            zoneCheck.TabIndex = 18;
            zoneCheck.TabStop = false;
            zoneCheck.Visible = false;
            // 
            // numberCheck
            // 
            numberCheck.Anchor = AnchorStyles.Top;
            numberCheck.Image = Properties.Resources.check_1053156;
            numberCheck.Location = new Point(243, 394);
            numberCheck.Margin = new Padding(3, 4, 3, 4);
            numberCheck.Name = "numberCheck";
            numberCheck.Size = new Size(34, 40);
            numberCheck.SizeMode = PictureBoxSizeMode.StretchImage;
            numberCheck.TabIndex = 17;
            numberCheck.TabStop = false;
            numberCheck.Visible = false;
            // 
            // discCheck
            // 
            discCheck.Image = Properties.Resources.check_1053156;
            discCheck.Location = new Point(435, 541);
            discCheck.Margin = new Padding(3, 4, 3, 4);
            discCheck.Name = "discCheck";
            discCheck.Size = new Size(34, 40);
            discCheck.SizeMode = PictureBoxSizeMode.StretchImage;
            discCheck.TabIndex = 16;
            discCheck.TabStop = false;
            discCheck.Visible = false;
            // 
            // dateCheck
            // 
            dateCheck.Anchor = AnchorStyles.Top;
            dateCheck.Image = Properties.Resources.check_1053156;
            dateCheck.Location = new Point(369, 169);
            dateCheck.Margin = new Padding(3, 4, 3, 4);
            dateCheck.Name = "dateCheck";
            dateCheck.Size = new Size(34, 40);
            dateCheck.SizeMode = PictureBoxSizeMode.StretchImage;
            dateCheck.TabIndex = 15;
            dateCheck.TabStop = false;
            dateCheck.Visible = false;
            // 
            // Book_Tickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1191, 881);
            Controls.Add(tableLayoutPanel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Book_Tickets";
            Text = "Tickets";
            Load += Book_Tickets_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)seatNo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)zoneCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)discCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateCheck).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox zoneSelection;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private NumericUpDown seatNo;
        private Label seatBox;
        private Label label6;
        private ComboBox discountSelection;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox zoneCheck;
        private PictureBox numberCheck;
        private PictureBox discCheck;
        private PictureBox dateCheck;
    }
}