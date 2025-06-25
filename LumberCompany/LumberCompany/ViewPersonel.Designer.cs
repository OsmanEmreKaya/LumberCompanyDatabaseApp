namespace LumberCompany
{
    partial class ViewPersonel
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
            idtextBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            staffcountlbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(975, 24);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(84, 32);
            button1.TabIndex = 1;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // idtextBox1
            // 
            idtextBox1.Location = new Point(928, 25);
            idtextBox1.Margin = new Padding(3, 2, 3, 2);
            idtextBox1.Name = "idtextBox1";
            idtextBox1.Size = new Size(28, 23);
            idtextBox1.TabIndex = 2;
            idtextBox1.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(248, 60);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(810, 422);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = Properties.Resources.file_xluptXRv7RhG2RfPHn6hAE1U;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(10, 168);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(198, 38);
            button2.TabIndex = 3;
            button2.Text = "Delete Personel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = Properties.Resources.file_xluptXRv7RhG2RfPHn6hAE1U;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(10, 110);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(198, 37);
            button3.TabIndex = 4;
            button3.Text = "Add Personel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Castellar", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(217, 26);
            label1.TabIndex = 5;
            label1.Text = "Personel Page";
            // 
            // staffcountlbl
            // 
            staffcountlbl.AutoSize = true;
            staffcountlbl.BackColor = Color.Transparent;
            staffcountlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            staffcountlbl.ForeColor = Color.White;
            staffcountlbl.Location = new Point(10, 234);
            staffcountlbl.Name = "staffcountlbl";
            staffcountlbl.Size = new Size(193, 25);
            staffcountlbl.TabIndex = 7;
            staffcountlbl.Text = "Current Staff Count:";
            // 
            // ViewPersonel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.file_xluptXRv7RhG2RfPHn6hAE1U;
            ClientSize = new Size(1069, 491);
            Controls.Add(staffcountlbl);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(idtextBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewPersonel";
            Text = "ViewPersonel";
            Load += ViewPersonel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox idtextBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label staffcountlbl;
    }
}