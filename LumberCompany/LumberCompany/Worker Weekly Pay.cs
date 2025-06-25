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
    public partial class Worker_Weekly_Pay : Form
    {
        public Worker_Weekly_Pay()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Seng306Project; User id = sa ; Password = q ;Integrated Security=True;");
        SqlDataAdapter da;

        private void viewWorkerWeeklyPay()
        {
            string query = @"
                SELECT
                *
            FROM
                Worker_Weekly_Pay WWP
        ";

            da = new SqlDataAdapter(query, baglan);

            DataTable tablo = new DataTable();
            baglan.Open();
            da.Fill(tablo);
            baglan.Close();

            dataGridView1.DataSource = tablo;
        }


        private void Worker_Weekly_Pay_Load(object sender, EventArgs e)
        {
            viewWorkerWeeklyPay();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
