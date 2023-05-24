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
    public partial class Update_Employee : Form
    {
        public Update_Employee()
        {
            InitializeComponent();
        }
        string con = ("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                string input1 = textBox4.Text;

                if (ID_Finder(input1) == 0)
                {
                    if (textBox3.Text == textBox5.Text)
                    {
                        SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");
                        SqlCommand sqlcommand = new SqlCommand();
                        sqlcommand.Connection = sqlconnection;
                        sqlconnection.Open();
                        sqlcommand.CommandText = "UPDATE EMPLOYEE Set EMPLOYEE_USER_NAME='" + textBox1.Text + "',EMPLOYEE_NAME='" + textBox2.Text + "',EMPLOYEE_PASSWORD='" + textBox3.Text + "',BRANCH_NO='" + textBox6.Text + "' Where EMPLOYEE_ID='" + textBox4.Text + "' ";
                        sqlcommand.ExecuteNonQuery();
                        sqlconnection.Close();
                        MessageBox.Show("Successfully Updated");
                    }
                    else
                    {
                        MessageBox.Show("Password and Confirm Password does not match");
                    }
                }
                else
                {
                    MessageBox.Show("No Employee with this ID");
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string input1 = textBox4.Text;

            if (ID_Finder(input1) == 0)
            {
                string sql = "select EMPLOYEE_ID, EMPLOYEE_USER_NAME, EMPLOYEE_NAME, BRANCH_NO, EMPLOYEE_PASSWORD from EMPLOYEE where EMPLOYEE_ID='" + textBox4.Text + "'";
                
                SqlConnection cnn = new SqlConnection(con);
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataReader Reader = cmd.ExecuteReader();
                listView1.Items.Clear();
                while (Reader.Read())
                {
                    ListViewItem lv = new ListViewItem(Reader.GetDecimal(0).ToString());
                    lv.SubItems.Add(Reader.GetString(1).ToString());
                    lv.SubItems.Add(Reader.GetString(2).ToString());
                    lv.SubItems.Add(Reader.GetDecimal(3).ToString());
                    lv.SubItems.Add(Reader.GetString(4).ToString());
                    listView1.Items.Add(lv);
                }
                Reader.Close();
                cnn.Close();
            }
            else
            {
                MessageBox.Show("No employee with this ID");
            }

        }

        private void Update_Employee_Load(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            listView1.View = View.Details;
            //Add Column Header
            listView1.Columns.Add("EMPLOYEE_ID", 150);
            listView1.Columns.Add("EMPLOYEE_USER_NAME", 150);
            listView1.Columns.Add("EMPLOYEE_NAME", 150);
            listView1.Columns.Add("BRANCH_NO", 150);
            listView1.Columns.Add("EMPLOYEE_PASSWORD", 150);
            
        }
        private int ID_Finder(string input1)
        {
            int id = 0;

            string query = "select * from EMPLOYEE where EMPLOYEE_ID = '" + input1 + "'";
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
                            output = reader["EMPLOYEE_ID"].ToString() + " ";
                        }
                    }
                }
            }
            if (output == "")
            {
                id = 1;

            }
            return id;

        }
    }
}
