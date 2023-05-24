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
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }
        string con = ("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");

        private void Query_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_SystemDataSet.ADMIN' table. You can move, or remove it, as needed.
            this.aDMINTableAdapter.Fill(this.bank_SystemDataSet.ADMIN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listView1.GridLines = true;
            listView1.View = View.Details;
            //Add Column Header
            listView1.Columns.Add("Branch_No", 150);
            listView1.Columns.Add("Branch_Address", 150);
            string sql = "select b.branch_no , branch_address from branch B left outer join bank_account BA on B.branch_no=BA.branch_no full outer join customer c  on c.ssn = BA.ssn where customer_name is null";

            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetDecimal(0).ToString());
                lv.SubItems.Add(Reader.GetString(1).ToString());
              
                listView1.Items.Add(lv);
            }
            Reader.Close();
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            listView1.GridLines = true;
            listView1.View = View.Details;
            //Add Column Header
            listView1.Columns.Add("Branch_No", 150);
            listView1.Columns.Add("Branch_Address", 150);
            string sql = "select b.branch_no , branch_address from branch B left outer join employee E on B.branch_no = e.branch_no where employee_name is null ;";

            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetDecimal(0).ToString());
                lv.SubItems.Add(Reader.GetString(1).ToString());

                listView1.Items.Add(lv);
            }
           
            Reader.Close();
            cnn.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            listView1.GridLines = true;
            listView1.View = View.Details;
            //Add Column Header
            listView1.Columns.Add("Employee_Name", 150);
            string sql = "select employee_name from employee E inner join loan L on E.employee_id=L.employee_id where loan_no in(select max(loan_no) from loan)";

            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetString(0).ToString());
               
                listView1.Items.Add(lv);
            }

            Reader.Close();
            cnn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            listView1.GridLines = true;
            listView1.View = View.Details;
            //Add Column Header
            listView1.Columns.Add("Customer_Name", 150);
            
            string sql = "select customer_name from customer c inner join loan l on c.ssn = l.ssn where LOAN_NO in (select max(loan_no) from loan)";

            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetString(0).ToString());
               

                listView1.Items.Add(lv);
            }

            Reader.Close();
            cnn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            listView1.View = View.Details;
            //Add Column Header
            listView1.Columns.Add("Customer_Name", 150);

            string sql = "select customer_name  from customer c left outer join loan l on c.ssn = l.ssn where LOAN_NO is null";

            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetString(0).ToString());


                listView1.Items.Add(lv);
            }

            Reader.Close();
            cnn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            listView1.View = View.Details;
            //Add Column Header
            listView1.Columns.Add("Customer_Name", 150);
            listView1.Columns.Add("SSN", 150);
            listView1.Columns.Add("Customer_Email", 150);
            listView1.Columns.Add("Customer_Phone", 150);
            listView1.Columns.Add("Customer_Address", 150);
            listView1.Columns.Add("NO_of_Employees", 150);

            string sql = "select CUSTOMER.CUSTOMER_NAME,CUSTOMER.SSN,CUSTOMER.CUSTOMER_EMAIL,CUSTOMER.CUSTOMER_PHONE,CUSTOMER.CUSTOMER_ADDRESS,(select count(*) from [dbo].[CUSTOMER],[dbo].[LOAN] where CUSTOMER.SSN = LOAN.SSN ) as Number_Of_Employees from [dbo].[CUSTOMER]";

            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetString(0).ToString());
                lv.SubItems.Add(Reader.GetDecimal(1).ToString());
                lv.SubItems.Add(Reader.GetString(2).ToString());
                lv.SubItems.Add(Reader.GetDecimal(3).ToString());
                lv.SubItems.Add(Reader.GetString(4).ToString());
                lv.SubItems.Add(Reader.GetInt32(5).ToString());

                listView1.Items.Add(lv);
            }

            Reader.Close();
            cnn.Close();

        }
    }
}
