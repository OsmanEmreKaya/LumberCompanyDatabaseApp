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
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LumberCompany
{
    public partial class EditPersonel : Form
    {
        private int staffId;
        private string department;
        private DateTime startDate;
        private decimal hourly;
        private decimal travelAllowance;
        private string ipp;
        private string food;
        private string name;


        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Seng306Project; User id = sa ; Password = q ;Integrated Security=True;");
        SqlCommand cmd;
        public EditPersonel(Form parentForm, int staffId, string department, DateTime startDate, decimal hourly, decimal travelAllowance, string ipp, string food, string name)
        {
            this.staffId = staffId;
            this.department = department;
            this.startDate = startDate;
            this.hourly = hourly;
            this.travelAllowance = travelAllowance;
            this.ipp = ipp;
            this.food = food;
            this.name = name;

            // Initialize form components and populate controls with the passed-in values
            InitializeComponent();
            PopulateFormFields();
        }

        private void PopulateFormFields()
        {
            idtextBox1.Text = staffId.ToString();
            Nametxt.Text = name;
            dateTimePicker1.Value = startDate;
            HourlyWagetxt.Text = hourly.ToString();
            Traveltxt.Text = travelAllowance.ToString();
            IPPtxt.Text = ipp;
            Foodtxt.Text = food;
            PersonelcomboBox1.Text = department;


        }

        private void EditPersonel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Staff SET Department=@Department, Start_Date=@Start_Date, Hourly=@Hourly, Travel_Allowance=@Travel_Allowance, IPP=@IPP, Food=@Food, Name=@Name WHERE Staff_Id=@Staff_Id";
            cmd = new SqlCommand(sorgu, baglan);

            if (!string.IsNullOrEmpty(Nametxt.Text) &&
                !string.IsNullOrEmpty(HourlyWagetxt.Text) &&
                !string.IsNullOrEmpty(Traveltxt.Text) &&
                !string.IsNullOrEmpty(IPPtxt.Text) &&
                !string.IsNullOrEmpty(Foodtxt.Text))
            {
                cmd.Parameters.AddWithValue("@Staff_Id", Convert.ToInt32(idtextBox1.Text));
                cmd.Parameters.AddWithValue("@Department", PersonelcomboBox1.Text);
                cmd.Parameters.AddWithValue("@Start_Date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Hourly", Convert.ToDecimal(HourlyWagetxt.Text));
                cmd.Parameters.AddWithValue("@Travel_Allowance", Convert.ToDecimal(Traveltxt.Text));
                cmd.Parameters.AddWithValue("@IPP", Convert.ToDecimal(IPPtxt.Text));
                cmd.Parameters.AddWithValue("@Food", Foodtxt.Text);
                cmd.Parameters.AddWithValue("@Name", Nametxt.Text);

                try
                {
                    baglan.Open();
                    cmd.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Staff record updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the record: " + ex.Message);
                }
                finally
                {
                    if (baglan.State == ConnectionState.Open)
                    {
                        baglan.Close();
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Name, Hourly Wage, Travel Allowance, IPP, and Food can't be empty");
            }
        }

        private void Traveltxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

