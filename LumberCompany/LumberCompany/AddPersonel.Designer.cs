namespace LumberCompany
{
    partial class AddPersonel
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            Nametxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            HourlyWagetxt = new TextBox();
            label5 = new Label();
            Traveltxt = new TextBox();
            IPPtxt = new TextBox();
            label6 = new Label();
            Foodtxt = new TextBox();
            label7 = new Label();
            PersonelcomboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(312, 278);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(92, 28);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(33, 278);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(87, 28);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(130, 22);
            label1.TabIndex = 2;
            label1.Text = "Name Surname:";
            label1.Click += label1_Click;
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(10, 43);
            Nametxt.Margin = new Padding(3, 2, 3, 2);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(204, 23);
            Nametxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(119, 22);
            label2.TabIndex = 4;
            label2.Text = "Personel Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 123);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 6;
            label3.Text = "Start Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 184);
            label4.Name = "label4";
            label4.Size = new Size(111, 22);
            label4.TabIndex = 8;
            label4.Text = "Hourly Wage:";
            // 
            // HourlyWagetxt
            // 
            HourlyWagetxt.Location = new Point(10, 207);
            HourlyWagetxt.Margin = new Padding(3, 2, 3, 2);
            HourlyWagetxt.Name = "HourlyWagetxt";
            HourlyWagetxt.Size = new Size(110, 23);
            HourlyWagetxt.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(294, 20);
            label5.Name = "label5";
            label5.Size = new Size(139, 22);
            label5.TabIndex = 10;
            label5.Text = "Travel Allowance";
            // 
            // Traveltxt
            // 
            Traveltxt.Location = new Point(295, 43);
            Traveltxt.Margin = new Padding(3, 2, 3, 2);
            Traveltxt.Name = "Traveltxt";
            Traveltxt.Size = new Size(110, 23);
            Traveltxt.TabIndex = 11;
            // 
            // IPPtxt
            // 
            IPPtxt.Location = new Point(295, 94);
            IPPtxt.Margin = new Padding(3, 2, 3, 2);
            IPPtxt.Name = "IPPtxt";
            IPPtxt.Size = new Size(110, 23);
            IPPtxt.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(294, 72);
            label6.Name = "label6";
            label6.Size = new Size(36, 22);
            label6.TabIndex = 13;
            label6.Text = "IPP";
            // 
            // Foodtxt
            // 
            Foodtxt.Location = new Point(295, 146);
            Foodtxt.Margin = new Padding(3, 2, 3, 2);
            Foodtxt.Name = "Foodtxt";
            Foodtxt.Size = new Size(110, 23);
            Foodtxt.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(294, 123);
            label7.Name = "label7";
            label7.Size = new Size(47, 22);
            label7.TabIndex = 15;
            label7.Text = "Food";
            // 
            // PersonelcomboBox1
            // 
            PersonelcomboBox1.FormattingEnabled = true;
            PersonelcomboBox1.Items.AddRange(new object[] { "Worker", "Administrative" });
            PersonelcomboBox1.Location = new Point(10, 95);
            PersonelcomboBox1.Margin = new Padding(3, 2, 3, 2);
            PersonelcomboBox1.Name = "PersonelcomboBox1";
            PersonelcomboBox1.Size = new Size(133, 23);
            PersonelcomboBox1.TabIndex = 16;
            PersonelcomboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(10, 146);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(222, 29);
            dateTimePicker1.TabIndex = 17;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(173, 278);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(87, 28);
            button3.TabIndex = 18;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AddPersonel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            BackgroundImage = Properties.Resources.file_xluptXRv7RhG2RfPHn6hAE1U;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(465, 338);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(PersonelcomboBox1);
            Controls.Add(label7);
            Controls.Add(Foodtxt);
            Controls.Add(label6);
            Controls.Add(IPPtxt);
            Controls.Add(Traveltxt);
            Controls.Add(label5);
            Controls.Add(HourlyWagetxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nametxt);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddPersonel";
            Text = "AddPersonel";
            Load += AddPersonel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox Nametxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox HourlyWagetxt;
        private Label label5;
        private TextBox Traveltxt;
        private TextBox IPPtxt;
        private Label label6;
        private TextBox Foodtxt;
        private Label label7;
        private ComboBox PersonelcomboBox1;
        private DateTimePicker dateTimePicker1;
        private Button button3;
    }
}