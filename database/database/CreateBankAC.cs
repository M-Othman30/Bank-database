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
    public partial class CreateBankAC : Form
    {
        public CreateBankAC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                string input1 = textBox3.Text;
                string query = "select * from CUSTOMER where SSN = '" + input1 + "'";
                string connectionstring = "data source=desktop-ck7danv;initial catalog=bank system;integrated security=true";
                string output = "";
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionstring))
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
                    MessageBox.Show("No Customer With This SSN");
                }
                else
                {
                    SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");
                    SqlCommand sqlcommand = new SqlCommand();
                    sqlcommand.Connection = sqlconnection;
                    sqlconnection.Open();
                    sqlcommand.CommandText = "INSERT INTO BANK_ACCOUNT Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "') ";
                    sqlcommand.ExecuteNonQuery();
                    sqlconnection.Close();
                    MessageBox.Show("Successfully Created");
                    this.Hide();
                }
               
            }
        }
    }
}