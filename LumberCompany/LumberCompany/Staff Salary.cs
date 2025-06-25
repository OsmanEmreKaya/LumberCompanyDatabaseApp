using System.Data.SqlClient;
using System.Data;

namespace LumberCompany
{
    public partial class Staff_Salary : Form
    {
        public Staff_Salary()
        {
            InitializeComponent();
            filtercombobox.SelectedIndexChanged += filtercombobox_SelectedIndexChanged;
        }

        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Seng306Project; User id = sa ; Password = q ;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter da;

        private void viewStaffSalaryList()
        {
            string baseQuery = @"
              SELECT * 
FROM Staff_Salary SS 
";

            string filterQuery = "";


            if (filtercombobox.SelectedIndex == 1)
            {
                filterQuery = @"
                  WHERE SS.Monthly_Salary > (
                    SELECT 35000 
                  )";
            }
            else if (filtercombobox.SelectedIndex == 2)
            {
                filterQuery = @"
                  WHERE SS.Monthly_Salary < (
                    SELECT 35000 
                  )";
            }

            string finalQuery = baseQuery + filterQuery;

            da = new SqlDataAdapter(finalQuery, baglan);

            DataTable tablo = new DataTable();
            baglan.Open();
            da.Fill(tablo);
            baglan.Close();

            dataGridView1.DataSource = tablo;
        }

        private void updateAverageSalary()
        {
            string query = @"
              SELECT AVG(Monthly_Salary) 
              FROM Staff_Salary";

            cmd = new SqlCommand(query, baglan);
            baglan.Open();
            object result = cmd.ExecuteScalar();
            baglan.Close();

            if (result != DBNull.Value)
            {
                decimal avgMonthlySalary = Convert.ToDecimal(result);
                avgsalarylbl.Text = "Average Monthly Salary: " + avgMonthlySalary.ToString("C"); // "C" formats the number as currency
            }
            else
            {
                avgsalarylbl.Text = "Average Monthly Salary: $0.00";
            }
        }

        private void Staff_Salary_Load(object sender, EventArgs e)
        {
            viewStaffSalaryList();
            updateAverageSalary();
        }

        private void filtercombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewStaffSalaryList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
