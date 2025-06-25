using System.ComponentModel;
using System.Net.Mail;
using System.Windows.Forms;

namespace LumberCompany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ViewPersonel form1 = new ViewPersonel();
            form1.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TransactionsPage form2 = new TransactionsPage();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MakeTransactions form2 = new MakeTransactions();
            form2.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TakeAttendance form2 = new TakeAttendance();
            form2.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AttendanceList form2 = new AttendanceList();
            form2.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Current_Staff_Pay form1 = new Current_Staff_Pay();
            form1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Staff_Salary form1 = new Staff_Salary();
            form1.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {

            Worker_Weekly_Pay form1 = new Worker_Weekly_Pay();
            form1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Administrative_Monthly_Pay form1 = new Administrative_Monthly_Pay();
            form1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}