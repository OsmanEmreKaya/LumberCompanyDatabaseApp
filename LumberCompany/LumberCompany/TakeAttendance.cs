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
    public partial class TakeAttendance : Form
    {
        public TakeAttendance()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Seng306Project; User id = sa ; Password = q ;Integrated Security=True;");
        SqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Attendance (Date, Staff_Id, Did_come) VALUES (@Date, @Staff_Id, @Did_come)";
            cmd = new SqlCommand(sorgu, baglan);

            baglan.Open();

            foreach (TreeNode node in treeView1.Nodes)
            {
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Staff_Id", Convert.ToInt32(node.Name));
                cmd.Parameters.AddWithValue("@Did_come", node.Checked ? 1 : 0);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while inserting the attendance record: " + ex.Message);
                }
            }

            baglan.Close();
            MessageBox.Show("Attendance recorded successfully.");
            this.Close();
        }

        private void fillCheckBox()
        {
            treeView1.Nodes.Clear();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff", baglan);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Class2 task = new Class2();
                task.Staff_id = dataReader[0].ToString();
                task.Name = dataReader[7].ToString();

                TreeNode node = new TreeNode();
                node.Name = task.Staff_id;
                node.Text = task.Name;
                treeView1.Nodes.Add(node);
            }

            dataReader.Close();
            baglan.Close();
        }

        private void TakeAttendance_Load(object sender, EventArgs e)
        {
            fillCheckBox();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
