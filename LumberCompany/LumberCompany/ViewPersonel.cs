using System.Data.SqlClient;
using System.Data;

namespace LumberCompany
{
    public partial class ViewPersonel : Form
    {
        public ViewPersonel()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Seng306Project; User id = sa ; Password = q ;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter da;

        private void viewStaffList()
        {
            baglan.Open();

            // Create the SqlDataAdapter with the SELECT query for the Staff table
            da = new SqlDataAdapter("SELECT Staff_Id, Department, Start_Date, Hourly, Travel_Allowance, IPP, Food, Name FROM Staff", baglan);

            // Create a DataTable to hold the query results
            DataTable tablo = new DataTable();

            // Fill the DataTable with the results of the query
            da.Fill(tablo);

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = tablo;

            // Close the database connection
            baglan.Close();
        }

        private void updateStaffCount()
        {
            string query = "SELECT COUNT(*) FROM Staff";
            cmd = new SqlCommand(query, baglan);
            baglan.Open();
            int count = (int)cmd.ExecuteScalar();
            baglan.Close();

            staffcountlbl.Text = "Total Staff: " + count.ToString();
        }

        private void ViewPersonel_Load(object sender, EventArgs e)
        {
            viewStaffList();
            updateStaffCount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewStaffList();
            updateStaffCount();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve the values from the selected row
                int staffId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Staff_Id"].Value);
                string department = dataGridView1.Rows[e.RowIndex].Cells["Department"].Value.ToString();
                DateTime startDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Start_Date"].Value);
                decimal hourly = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Hourly"].Value);
                decimal travelAllowance = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Travel_Allowance"].Value);
                string ipp = dataGridView1.Rows[e.RowIndex].Cells["IPP"].Value.ToString();
                string food = dataGridView1.Rows[e.RowIndex].Cells["Food"].Value.ToString();
                string name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();

                // Create and show the edit form, passing in the staff details
                EditPersonel editStaffForm = new EditPersonel(this, staffId, department, startDate, hourly, travelAllowance, ipp, food, name);
                editStaffForm.ShowDialog();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            idtextBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Staff WHERE Staff_Id = @Staff_Id";
            cmd = new SqlCommand(sorgu, baglan);
            cmd.Parameters.AddWithValue("@Staff_Id", Convert.ToInt32(idtextBox1.Text));
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            viewStaffList();
            updateStaffCount();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPersonel form1 = new AddPersonel();
            form1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
