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
    public partial class Admin_Page : Form
    {

        public Admin_Page()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CK7DANVnitial Catalog=Bank System;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void Admin_Page_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp s = new SignUp();
            s.Show();
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
                string query = "SELECT * FROM ADMIN WHERE ADMIN_ID = '" + input3 + "'AND ADMIN_PASSWORD='" + input2 + "'AND ADMIN_USER_NAME='" + input + "'";
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
                                output = reader["ADMIN_ID"].ToString() + " ";
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
                    Admin_Work aw = new Admin_Work();
                    aw.Show();
                    this.Hide();
                }
            }

        }
    }
}
