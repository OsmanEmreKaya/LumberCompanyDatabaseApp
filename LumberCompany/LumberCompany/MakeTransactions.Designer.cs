namespace LumberCompany
{
    partial class MakeTransactions
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
            Namecombo = new ComboBox();
            TypeIdcombo = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            Amounttxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Namecombo
            // 
            Namecombo.FormattingEnabled = true;
            Namecombo.Location = new Point(10, 108);
            Namecombo.Margin = new Padding(3, 2, 3, 2);
            Namecombo.Name = "Namecombo";
            Namecombo.Size = new Size(219, 23);
            Namecombo.TabIndex = 0;
            // 
            // TypeIdcombo
            // 
            TypeIdcombo.FormattingEnabled = true;
            TypeIdcombo.Location = new Point(10, 164);
            TypeIdcombo.Margin = new Padding(3, 2, 3, 2);
            TypeIdcombo.Name = "TypeIdcombo";
            TypeIdcombo.Size = new Size(133, 23);
            TypeIdcombo.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(10, 220);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // Amounttxt
            // 
            Amounttxt.Location = new Point(10, 279);
            Amounttxt.Margin = new Padding(3, 2, 3, 2);
            Amounttxt.Name = "Amounttxt";
            Amounttxt.Size = new Size(110, 23);
            Amounttxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 86);
            label1.Name = "label1";
            label1.Size = new Size(130, 22);
            label1.TabIndex = 4;
            label1.Text = "Name Surname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 142);
            label2.Name = "label2";
            label2.Size = new Size(52, 22);
            label2.TabIndex = 5;
            label2.Text = "Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 198);
            label3.Name = "label3";
            label3.Size = new Size(49, 22);
            label3.TabIndex = 6;
            label3.Text = "Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 256);
            label4.Name = "label4";
            label4.Size = new Size(76, 22);
            label4.TabIndex = 7;
            label4.Text = "Amount:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 19);
            label5.Name = "label5";
            label5.Size = new Size(212, 32);
            label5.TabIndex = 8;
            label5.Text = "Make Transaction";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.file_xluptXRv7RhG2RfPHn6hAE1U;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(308, 306);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(87, 26);
            button1.TabIndex = 9;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MakeTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.file_xluptXRv7RhG2RfPHn6hAE1U;
            ClientSize = new Size(405, 341);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Amounttxt);
            Controls.Add(dateTimePicker1);
            Controls.Add(TypeIdcombo);
            Controls.Add(Namecombo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MakeTransactions";
            Text = "MakeTransactions";
            Load += MakeTransactions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Namecombo;
        private ComboBox TypeIdcombo;
        private DateTimePicker dateTimePicker1;
        private TextBox Amounttxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}