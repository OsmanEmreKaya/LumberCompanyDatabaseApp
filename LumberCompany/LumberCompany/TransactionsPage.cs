using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LumberCompany
{
    public partial class TransactionsPage : Form
    {
        public TransactionsPage()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Seng306Project; User id = sa ; Password = q ;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter da;

        private void viewTransactions(string filter = "")
        {
            baglan.Open();

            string query = @"SELECT t.Transaction_Id, t.Staff_Id, s.Name, s.Department, tt.Description, t.Date, t.Amount 
                FROM Transactions t 
                LEFT JOIN Staff s ON t.Staff_Id = s.Staff_Id 
                LEFT JOIN Transaction_Type tt ON t.Type = tt.Type
               ";

            if (!string.IsNullOrEmpty(filter))
            {
                query += " WHERE t.Type = @Type";
            }



            da = new SqlDataAdapter(query, baglan);

            if (!string.IsNullOrEmpty(filter))
            {
                da.SelectCommand.Parameters.AddWithValue("@Type", filter);
            }

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }

        private void AddtoCm()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Transaction_Type", baglan);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Class1 task = new Class1();
                task.Type = dataReader[0].ToString();
                task.Description = dataReader[1].ToString();

                filtercombobox.Items.Add(task);
            }

            filtercombobox.DisplayMember = "Description";
            filtercombobox.ValueMember = "Type";

            dataReader.Close();
            baglan.Close();
        }

        private void TransactionsPage_Load(object sender, EventArgs e)
        {
            viewTransactions();
            AddtoCm();
        }

        private void filtercombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtercombobox.SelectedIndex == 0) // "All" is selected
            {
                viewTransactions(); // Call viewTransactions without passing any filter
            }
            else if (filtercombobox.SelectedItem != null)
            {
                var selectedType = (Class1)filtercombobox.SelectedItem;
                viewTransactions(selectedType.Type); // Call viewTransactions with the selected filter
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


