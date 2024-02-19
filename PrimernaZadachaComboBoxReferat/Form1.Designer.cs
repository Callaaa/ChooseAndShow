namespace PrimernaZadachaComboBoxReferat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            lblAge = new Label();
            lblName = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Italic);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 63);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 37);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Italic);
            textBox1.Location = new Point(319, 64);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 36);
            textBox1.TabIndex = 1;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Italic);
            lblAge.Location = new Point(319, 31);
            lblAge.Margin = new Padding(4, 0, 4, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(64, 29);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Italic);
            lblName.Location = new Point(26, 31);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(81, 29);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 243);
            Controls.Add(lblName);
            Controls.Add(lblAge);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Choose Name";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label lblAge;
        private Label lblName;
    }
}
