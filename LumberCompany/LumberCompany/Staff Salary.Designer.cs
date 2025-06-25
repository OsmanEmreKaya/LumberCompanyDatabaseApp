namespace LumberCompany
{
    partial class Staff_Salary
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
            dataGridView1 = new DataGridView();
            avgsalarylbl = new Label();
            filtercombobox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 16;
            label1.Text = "Staff Salary List";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 56);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(827, 296);
            dataGridView1.TabIndex = 15;
            // 
            // avgsalarylbl
            // 
            avgsalarylbl.AutoSize = true;
            avgsalarylbl.BackColor = Color.White;
            avgsalarylbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            avgsalarylbl.Location = new Point(10, 370);
            avgsalarylbl.Name = "avgsalarylbl";
            avgsalarylbl.Size = new Size(84, 21);
            avgsalarylbl.TabIndex = 17;
            avgsalarylbl.Text = "Avg Salary";
            // 
            // filtercombobox
            // 
            filtercombobox.FormattingEnabled = true;
            filtercombobox.Items.AddRange(new object[] { "All", ">35000", "<35000" });
            filtercombobox.Location = new Point(705, 20);
            filtercombobox.Margin = new Padding(3, 2, 3, 2);
            filtercombobox.Name = "filtercombobox";
            filtercombobox.Size = new Size(133, 23);
            filtercombobox.TabIndex = 18;
            filtercombobox.Text = "Filter by Salary";
            filtercombobox.SelectedIndexChanged += filtercombobox_SelectedIndexChanged;
            // 
            // Staff_Salary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.file_xluptXRv7RhG2RfPHn6hAE1U;
            ClientSize = new Size(848, 417);
            Controls.Add(filtercombobox);
            Controls.Add(avgsalarylbl);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Staff_Salary";
            Text = "Staff_Salary";
            Load += Staff_Salary_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label avgsalarylbl;
        private ComboBox filtercombobox;
    }
}