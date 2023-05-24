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

namespace database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection ("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Page admin = new Admin_Page();
            admin.Show();
            this.Hide();

            //SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");
            //SqlCommand sqlcommand = new SqlCommand();
            //sqlcommand.Connection = sqlconnection;
            //sqlconnection.Open();
            //sqlcommand.CommandText ="" ;
            //sqlcommand.ExecuteNonQuery();
            //sqlconnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer_Page customer = new Customer_Page();
            customer.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee_Page employee = new Employee_Page();
            employee.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Query q = new Query();
            q.Show();
        }
    }
}
