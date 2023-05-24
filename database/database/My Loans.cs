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
    public partial class My_Loans : Form
    {
        public My_Loans()
        {
            InitializeComponent();
        }
        string con = ("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string sql = "SELECT LOAN_NO, BRANCH_NO, EMPLOYEE_ID, SSN, LOAN_AMOUNT, LOAN_TYPE, LOAN_STATUS FROM LOAN Where SSN = '"+input+"'";
            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetString(0).ToString());
                lv.SubItems.Add(Reader.GetDecimal(1).ToString());
                lv.SubItems.Add(Reader.GetDecimal(2).ToString());
                lv.SubItems.Add(Reader.GetDecimal(3).ToString());
                lv.SubItems.Add(Reader.GetDecimal(4).ToString());
                lv.SubItems.Add(Reader.GetString(5).ToString());
                lv.SubItems.Add(Reader.GetString(6).ToString());


                listView1.Items.Add(lv);
            }
            Reader.Close();
            cnn.Close();

        }


        private void My_Loans_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_SystemDataSet.LOAN' table. You can move, or remove it, as needed.
            this.lOANTableAdapter.Fill(this.bank_SystemDataSet.LOAN);

            listView1.GridLines = true;
            listView1.View = View.Details;
            //Add Column Header
            listView1.Columns.Add("LOAN_NO", 150);
            listView1.Columns.Add("BRANCH_NO", 150);
            listView1.Columns.Add("EMPLOYEE_ID", 150);
            listView1.Columns.Add("SSN", 150);
            listView1.Columns.Add("LOAN_AMOUNT", 150);
            listView1.Columns.Add("LOAN_TYPE", 150);
            listView1.Columns.Add("LOAN_STATUS", 150);
            
        }
        private int ID_Finder(string input1)
        {
            int id = 0;

            string query = "SELECT * from LOAN Where SSN = '" + input1 + "'";
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
                id = 1;

            }
            return id;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlconnection;
                sqlconnection.Open();


                sqlcommand.CommandText = "UPDATE  LOAN Set LOAN_STATUS='" + comboBox1.Text+"' Where LOAN_NO='" + textBox2.Text + "'AND SSN='" + textBox1.Text + "'";
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("Successfully Updated");
            }
        }

        
    }
}
