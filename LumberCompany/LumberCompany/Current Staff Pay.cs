using System.Data.SqlClient;
using System.Data;

namespace LumberCompany
{
    public partial class Current_Staff_Pay : Form
    {
        public Current_Staff_Pay()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Seng306Project; User id = sa ; Password = q ;Integrated Security=True;");
        SqlDataAdapter da;

        private void viewCSP()
        {
            baglan.Open();
            string query = @"
    SELECT 
        *
    FROM 
        Current_Staff_Pay CSP
;";

            da = new SqlDataAdapter(query, baglan);

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }

        private void updateTotalMoney()
        {
            string query = "SELECT SUM(Net_Pay) FROM Current_Staff_Pay";
            SqlCommand cmd = new SqlCommand(query, baglan);
            baglan.Open();
            object result = cmd.ExecuteScalar();
            baglan.Close();

            if (result != DBNull.Value)
            {
                decimal totalNetPay = Convert.ToDecimal(result);
                totalmoneylbl.Text = "Total Net Pay: " + totalNetPay.ToString("C"); // "C" formats the number as currency
            }
            else
            {
                totalmoneylbl.Text = "Total Net Pay: $0.00";
            }
        }

        private void Current_Staff_Pay_Load(object sender, EventArgs e)
        {
            viewCSP();
            updateTotalMoney();
        }

        private void totalmoneylbl_Click(object sender, EventArgs e)
        {

        }
    }
}
