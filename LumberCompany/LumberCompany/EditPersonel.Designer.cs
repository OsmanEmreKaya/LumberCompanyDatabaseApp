namespace LumberCompany
{
    partial class EditPersonel
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
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            PersonelcomboBox1 = new ComboBox();
            label7 = new Label();
            Foodtxt = new TextBox();
            label6 = new Label();
            IPPtxt = new TextBox();
            Traveltxt = new TextBox();
            label5 = new Label();
            HourlyWagetxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Nametxt = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            idtextBox1 = new TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(179, 282);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(87, 28);
            button3.TabIndex = 35;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(10, 149);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(222, 29);
            dateTimePicker1.TabIndex = 34;
            // 
            // PersonelcomboBox1
            // 
            PersonelcomboBox1.FormattingEnabled = true;
            PersonelcomboBox1.Items.AddRange(new object[] { "Worker", "Administrative" });
            PersonelcomboBox1.Location = new Point(12, 99);
            PersonelcomboBox1.Margin = new Padding(3, 2, 3, 2);
            PersonelcomboBox1.Name = "PersonelcomboBox1";
            PersonelcomboBox1.Size = new Size(133, 23);
            PersonelcomboBox1.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(300, 127);
            label7.Name = "label7";
            label7.Size = new Size(47, 22);
            label7.TabIndex = 32;
            label7.Text = "Food";
            // 
            // Foodtxt
            // 
            Foodtxt.Location = new Point(301, 149);
            Foodtxt.Margin = new Padding(3, 2, 3, 2);
            Foodtxt.Name = "Foodtxt";
            Foodtxt.Size = new Size(110, 23);
            Foodtxt.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(300, 76);
            label6.Name = "label6";
            label6.Size = new Size(36, 22);
            label6.TabIndex = 30;
            label6.Text = "IPP";
            // 
            // IPPtxt
            // 
            IPPtxt.Location = new Point(301, 98);
            IPPtxt.Margin = new Padding(3, 2, 3, 2);
            IPPtxt.Name = "IPPtxt";
            IPPtxt.Size = new Size(110, 23);
            IPPtxt.TabIndex = 29;
            // 
            // Traveltxt
            // 
            Traveltxt.Location = new Point(301, 46);
            Traveltxt.Margin = new Padding(3, 2, 3, 2);
            Traveltxt.Name = "Traveltxt";
            Traveltxt.Size = new Size(110, 23);
            Traveltxt.TabIndex = 28;
            Traveltxt.TextChanged += Traveltxt_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(300, 23);
            label5.Name = "label5";
            label5.Size = new Size(139, 22);
            label5.TabIndex = 27;
            label5.Text = "Travel Allowance";
            // 
            // HourlyWagetxt
            // 
            HourlyWagetxt.Location = new Point(12, 211);
            HourlyWagetxt.Margin = new Padding(3, 2, 3, 2);
            HourlyWagetxt.Name = "HourlyWagetxt";
            HourlyWagetxt.Size = new Size(110, 23);
            HourlyWagetxt.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 188);
            label4.Name = "label4";
            label4.Size = new Size(111, 22);
            label4.TabIndex = 25;
            label4.Text = "Hourly Wage:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 24;
            label3.Text = "Start Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(119, 22);
            label2.TabIndex = 23;
            label2.Text = "Personel Type:";
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(17, 46);
            Nametxt.Margin = new Padding(3, 2, 3, 2);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(204, 23);
            Nametxt.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(130, 22);
            label1.TabIndex = 21;
            label1.Text = "Name Surname:";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(39, 282);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(87, 28);
            button2.TabIndex = 20;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(318, 282);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(92, 28);
            button1.TabIndex = 19;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // idtextBox1
            // 
            idtextBox1.Location = new Point(382, 211);
            idtextBox1.Margin = new Padding(3, 2, 3, 2);
            idtextBox1.Name = "idtextBox1";
            idtextBox1.Size = new Size(28, 23);
            idtextBox1.TabIndex = 36;
            idtextBox1.Visible = false;
            // 
            // EditPersonel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.file_xluptXRv7RhG2RfPHn6hAE1U;
            ClientSize = new Size(469, 338);
            Controls.Add(idtextBox1);
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
            Name = "EditPersonel";
            Text = "EditPersonel";
            Load += EditPersonel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private DateTimePicker dateTimePicker1;
        private ComboBox PersonelcomboBox1;
        private Label label7;
        private TextBox Foodtxt;
        private Label label6;
        private TextBox IPPtxt;
        private TextBox Traveltxt;
        private Label label5;
        private TextBox HourlyWagetxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox Nametxt;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox idtextBox1;
    }
}