using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LumberCompany
{
    public partial class AttendanceList : Form
    {
        public AttendanceList()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Seng306Project; User id = sa ; Password = q ;Integrated Security=True;");
        SqlDataAdapter da;

        private void viewAttendanceList()
        {
            string query = @"
                SELECT 
                    A.Date,
                    S.Staff_Id,
                    S.Name,
                    A.Did_come
                FROM 
                    Attendance A
                JOIN 
                    Staff S ON A.Staff_Id = S.Staff_Id";

            da = new SqlDataAdapter(query, baglan);

            DataTable tablo = new DataTable();
            baglan.Open();
            da.Fill(tablo);
            baglan.Close();

            dataGridView1.DataSource = tablo;
        }

        private void AttendanceList_Load(object sender, EventArgs e)
        {
            viewAttendanceList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchAttendance(textBox1.Text);
        }

        private void searchAttendance(string searchText)
        {
            string query = @"
                SELECT 
                    A.Date,
                    S.Staff_Id,
                    S.Name,
                    A.Did_come
                FROM 
                    Attendance A
                JOIN 
                    Staff S ON A.Staff_Id = S.Staff_Id
                WHERE 
                    S.Staff_Id LIKE '%' + @search + '%' OR
                    S.Name LIKE '%' + @search + '%'";

            da = new SqlDataAdapter(query, baglan);
            da.SelectCommand.Parameters.AddWithValue("@search", searchText.Replace("'", "\""));

            DataTable tablo = new DataTable();
            baglan.Open();
            da.Fill(tablo);
            baglan.Close();

            dataGridView1.DataSource = tablo;
        }
    }
}
