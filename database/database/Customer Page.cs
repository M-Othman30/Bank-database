using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database
{
    public partial class Customer_Page : Form
    {
        public Customer_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" )
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                string input = textBox2.Text;
                string input2 = textBox1.Text;
                string query = "SELECT * FROM CUSTOMER WHERE SSN = '" + input + "'AND CUSTOMER_EMAIL='" + input2 + "'";
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
                                output = reader["SSN"].ToString() + " ";
                            }
                        }
                    }
                }
                if (output == "")
                {
                    MessageBox.Show("Wrong Input");
                }
                else
                {
                    Customer_work cw = new Customer_work();
                    cw.Show();
                    this.Hide();
                }
            }

        }

        private void Customer_Page_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
