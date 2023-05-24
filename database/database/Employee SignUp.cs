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
    public partial class Employee_SignUp : Form
    {
        public Employee_SignUp()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == ""|| textBox6.Text == "")
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
                    sqlcommand.CommandText = "INSERT INTO EMPLOYEE Values('" + textBox4.Text + "','" + textBox6.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "') ";
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

        private void Employee_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
