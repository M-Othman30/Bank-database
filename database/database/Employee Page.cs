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
    public partial class Employee_Page : Form
    {
        public Employee_Page()
        {
            InitializeComponent();
        }

        private void Employee_Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Employee_SignUp es = new Employee_SignUp();
            es.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                string input = textBox1.Text;
                string input2 = textBox2.Text;
                string input3 = textBox3.Text;
                string query = "SELECT * FROM EMPLOYEE WHERE EMPLOYEE_ID = '" + input3 + "'AND EMPLOYEE_PASSWORD='" + input2 + "'AND EMPLOYEE_USER_NAME='" + input + "'";
                string connectionString = "Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True";
                string output = "";
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                output = reader["EMPLOYEE_ID"].ToString() + " ";
                            }
                        }
                    }
                }
                if (output == "")
                {
                    MessageBox.Show("Wrong input");
                }
                else
                {
                    Employee_Works ew = new Employee_Works();
                    ew.Show();
                    this.Hide();
                }
            }
        }
    }
}
