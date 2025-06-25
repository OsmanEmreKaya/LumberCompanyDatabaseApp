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
    public partial class MakeTransactions : Form
    {
        public MakeTransactions()
        {
            
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Seng306Project; User id = sa ; Password = q ;Integrated Security=True;");
        SqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Transactions (Staff_Id, Type, Date, Amount) VALUES (@Staff_Id, @Type, @Date, @Amount)";
            SqlCommand cmd = new SqlCommand(sorgu, baglan);

            if (!string.IsNullOrEmpty(Namecombo.Text) &&
                !string.IsNullOrEmpty(TypeIdcombo.Text) &&
                !string.IsNullOrEmpty(Amounttxt.Text))
            {
                if (decimal.TryParse(Amounttxt.Text, out decimal amount))
                {
                    if (TypeIdcombo.SelectedItem is Class1 selectedCategory)
                    {
                        cmd.Parameters.AddWithValue("@Type", selectedCategory.Type);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Type", DBNull.Value);
                    }

                    if (Namecombo.SelectedItem is Class2 selectedStatus)
                    {
                        cmd.Parameters.AddWithValue("@Staff_Id", selectedStatus.Staff_id);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Staff_Id", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Amount", amount);

                    try
                    {
                        baglan.Open();
                        cmd.ExecuteNonQuery();
                        baglan.Close();
                        MessageBox.Show("Transaction inserted successfully.");
                        this.Close(); // Close the form after successful insertion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while inserting the transaction: " + ex.Message);
                    }
                    finally
                    {
                        if (baglan.State == ConnectionState.Open)
                        {
                            baglan.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Amount must be a valid decimal number.");
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled.");
            }
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

                TypeIdcombo.Items.Add(task);
            }

            TypeIdcombo.DisplayMember = "Description";
            TypeIdcombo.ValueMember = "Type";

            dataReader.Close();
            baglan.Close();
        }

        private void AddtoNameCm()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff", baglan);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Class2 task = new Class2();
                task.Staff_id = dataReader[0].ToString();
                task.Name = dataReader[7].ToString();

                Namecombo.Items.Add(task);
            }

            Namecombo.DisplayMember = "Name";
            Namecombo.ValueMember = "Staff_id";

            dataReader.Close();
            baglan.Close();
        }

        private void MakeTransactions_Load(object sender, EventArgs e)
        {
            AddtoCm();
            AddtoNameCm();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
