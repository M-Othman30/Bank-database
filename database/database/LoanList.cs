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
    public partial class LoanList : Form
    {
        public LoanList()
        {
            InitializeComponent();
        }
        string con = ("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT LOAN.*,CUSTOMER.CUSTOMER_NAME,EMPLOYEE.EMPLOYEE_NAME from LOAN,CUSTOMER,EMPLOYEE Where LOAN.EMPLOYEE_ID=EMPLOYEE.EMPLOYEE_ID AND LOAN.SSN=CUSTOMER.SSN";
            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetDecimal(0).ToString());
                lv.SubItems.Add(Reader.GetDecimal(1).ToString());
                lv.SubItems.Add(Reader.GetDecimal(2).ToString());
                lv.SubItems.Add(Reader.GetDecimal(3).ToString());
                lv.SubItems.Add(Reader.GetDecimal(4).ToString());
                lv.SubItems.Add(Reader.GetString(5).ToString());
                lv.SubItems.Add(Reader.GetString(6).ToString());
                lv.SubItems.Add(Reader.GetString(7).ToString());
                lv.SubItems.Add(Reader.GetString(8).ToString());

                listView1.Items.Add(lv);
            }
            Reader.Close();
            cnn.Close();

        }
     

        private void LoanList_Load(object sender, EventArgs e)
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
            listView1.Columns.Add("CUSTOMER_NAME", 150);
            listView1.Columns.Add("EMPLOYEE_NAME", 150);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" )
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlconnection;
                sqlconnection.Open();
               
               
                sqlcommand.CommandText = "UPDATE  LOAN Set LOAN_STATUS='"+comboBox2.Text+"ed' Where LOAN_NO='"+comboBox1.Text+"'";
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("Successfully Updated");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
