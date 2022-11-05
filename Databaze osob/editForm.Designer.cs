namespace Databaze_osob
{
    partial class editForm
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
            this.nahratFotoButton = new System.Windows.Forms.Button();
            this.zenaRadioButton = new System.Windows.Forms.RadioButton();
            this.muzRadioButton = new System.Windows.Forms.RadioButton();
            this.datumTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ulozOsobuButton = new System.Windows.Forms.Button();
            this.poznamkaTextBox = new System.Windows.Forms.TextBox();
            this.prijmeniTextBox = new System.Windows.Forms.TextBox();
            this.jmenoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nahratFotoButton
            // 
            this.nahratFotoButton.Location = new System.Drawing.Point(492, 129);
            this.nahratFotoButton.Name = "nahratFotoButton";
            this.nahratFotoButton.Size = new System.Drawing.Size(128, 42);
            this.nahratFotoButton.TabIndex = 38;
            this.nahratFotoButton.Text = "Nahrát foto";
            this.nahratFotoButton.UseVisualStyleBackColor = true;
            this.nahratFotoButton.Click += new System.EventHandler(this.nahratFotoButton_Click);
            // 
            // zenaRadioButton
            // 
            this.zenaRadioButton.AutoSize = true;
            this.zenaRadioButton.Location = new System.Drawing.Point(325, 202);
            this.zenaRadioButton.Name = "zenaRadioButton";
            this.zenaRadioButton.Size = new System.Drawing.Size(63, 24);
            this.zenaRadioButton.TabIndex = 37;
            this.zenaRadioButton.Text = "Žena";
            this.zenaRadioButton.UseVisualStyleBackColor = true;
            // 
            // muzRadioButton
            // 
            this.muzRadioButton.AutoSize = true;
            this.muzRadioButton.Checked = true;
            this.muzRadioButton.Location = new System.Drawing.Point(229, 202);
            this.muzRadioButton.Name = "muzRadioButton";
            this.muzRadioButton.Size = new System.Drawing.Size(58, 24);
            this.muzRadioButton.TabIndex = 36;
            this.muzRadioButton.TabStop = true;
            this.muzRadioButton.Text = "Muž";
            this.muzRadioButton.UseVisualStyleBackColor = true;
            // 
            // datumTimePicker
            // 
            this.datumTimePicker.Location = new System.Drawing.Point(208, 36);
            this.datumTimePicker.Name = "datumTimePicker";
            this.datumTimePicker.Size = new System.Drawing.Size(224, 27);
            this.datumTimePicker.TabIndex = 35;
            // 
            // ulozOsobuButton
            // 
            this.ulozOsobuButton.Location = new System.Drawing.Point(273, 462);
            this.ulozOsobuButton.Name = "ulozOsobuButton";
            this.ulozOsobuButton.Size = new System.Drawing.Size(159, 44);
            this.ulozOsobuButton.TabIndex = 34;
            this.ulozOsobuButton.Text = "Uložit";
            this.ulozOsobuButton.UseVisualStyleBackColor = true;
            this.ulozOsobuButton.Click += new System.EventHandler(this.ulozOsobuButton_Click);
            // 
            // poznamkaTextBox
            // 
            this.poznamkaTextBox.Location = new System.Drawing.Point(78, 319);
            this.poznamkaTextBox.Multiline = true;
            this.poznamkaTextBox.Name = "poznamkaTextBox";
            this.poznamkaTextBox.Size = new System.Drawing.Size(579, 137);
            this.poznamkaTextBox.TabIndex = 33;
            // 
            // prijmeniTextBox
            // 
            this.prijmeniTextBox.Location = new System.Drawing.Point(208, 144);
            this.prijmeniTextBox.Name = "prijmeniTextBox";
            this.prijmeniTextBox.Size = new System.Drawing.Size(224, 27);
            this.prijmeniTextBox.TabIndex = 32;
            // 
            // jmenoTextBox
            // 
            this.jmenoTextBox.Location = new System.Drawing.Point(208, 90);
            this.jmenoTextBox.Name = "jmenoTextBox";
            this.jmenoTextBox.Size = new System.Drawing.Size(224, 27);
            this.jmenoTextBox.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(78, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Poznánka:";
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPictureBox.Location = new System.Drawing.Point(455, 36);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(202, 228);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 29;
            this.fotoPictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(79, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Pohlaví:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(78, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Datum narození:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(78, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Příjmení";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(78, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Jméno:";
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 518);
            this.Controls.Add(this.nahratFotoButton);
            this.Controls.Add(this.zenaRadioButton);
            this.Controls.Add(this.muzRadioButton);
            this.Controls.Add(this.datumTimePicker);
            this.Controls.Add(this.ulozOsobuButton);
            this.Controls.Add(this.poznamkaTextBox);
            this.Controls.Add(this.prijmeniTextBox);
            this.Controls.Add(this.jmenoTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editace osoby";
            this.Load += new System.EventHandler(this.editForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button nahratFotoButton;
        private RadioButton zenaRadioButton;
        private RadioButton muzRadioButton;
        private DateTimePicker datumTimePicker;
        private Button ulozOsobuButton;
        private TextBox poznamkaTextBox;
        private TextBox prijmeniTextBox;
        private TextBox jmenoTextBox;
        private Label label6;
        private PictureBox fotoPictureBox;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}