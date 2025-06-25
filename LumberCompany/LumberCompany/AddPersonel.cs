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
using System.Xml.Linq;


namespace LumberCompany
{
    public partial class AddPersonel : Form
    {

        public AddPersonel()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Seng306Project; User id = sa ; Password = q ;Integrated Security=True;");
        SqlCommand cmd;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nametxt.Clear();
            Foodtxt.Clear();
            Traveltxt.Clear();
            IPPtxt.Clear();
            Foodtxt.Clear();
            HourlyWagetxt.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Staff (Department, Start_Date, Hourly, Travel_Allowance, IPP, Food, Name) VALUES (@Department, @Start_Date, @Hourly, @Travel_Allowance, @IPP, @Food, @Name)";
            SqlCommand cmd = new SqlCommand(sorgu, baglan);


            if (!string.IsNullOrEmpty(Nametxt.Text) &&
                PersonelcomboBox1.SelectedItem != null &&
                !string.IsNullOrEmpty(HourlyWagetxt.Text) &&
                !string.IsNullOrEmpty(Traveltxt.Text) &&
                !string.IsNullOrEmpty(IPPtxt.Text) &&
                !string.IsNullOrEmpty(Foodtxt.Text))
            {

                if (decimal.TryParse(HourlyWagetxt.Text, out decimal hourlyWage) &&
                    decimal.TryParse(Traveltxt.Text, out decimal travelAllowance) &&
                    decimal.TryParse(IPPtxt.Text, out decimal ipp))
                {
                    cmd.Parameters.AddWithValue("@Department", PersonelcomboBox1.Text);
                    cmd.Parameters.AddWithValue("@Start_Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Hourly", hourlyWage);
                    cmd.Parameters.AddWithValue("@Travel_Allowance", travelAllowance);
                    cmd.Parameters.AddWithValue("@IPP", ipp);
                    cmd.Parameters.AddWithValue("@Food", Foodtxt.Text);
                    cmd.Parameters.AddWithValue("@Name", Nametxt.Text);

                    try
                    {
                        baglan.Open();
                        cmd.ExecuteNonQuery();
                        baglan.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while inserting the record: " + ex.Message);
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
                    MessageBox.Show("Hourly Wage, Travel Allowance, and IPP must be valid decimal numbers.");
                }
            }
            else
            {
                MessageBox.Show("Boxes can't be empty.");
            }

            this.Close();
        }

        private void AddPersonel_Load(object sender, EventArgs e)
        {

        }
    }
}
