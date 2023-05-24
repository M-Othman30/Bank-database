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
    public partial class SignUp : Form
    {
        public SignUp()
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
                if (textBox5.Text == textBox3.Text)
                {
                    SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");
                    SqlCommand sqlcommand = new SqlCommand();
                    sqlcommand.Connection = sqlconnection;
                    sqlconnection.Open();
                    sqlcommand.CommandText = "INSERT INTO ADMIN Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";
                    sqlcommand.ExecuteNonQuery();
                    sqlconnection.Close();
                    MessageBox.Show("Successfully Registered");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password does not match");
                }
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");

        }
    }
}

