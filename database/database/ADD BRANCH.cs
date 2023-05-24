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
    public partial class ADD_BRANCH : Form
    {
        public ADD_BRANCH()
        {
            InitializeComponent();
        }
        string con = ("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlcommand.CommandText = "INSERT INTO BRANCH Values('" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "') ";
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("Branch Successfully Registered");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "select BRANCH_NO, BANK_CODE, BRANCH_ADDRESS, ADMIN_ID from BRANCH";
            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            listView2.Items.Clear();
            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetDecimal(0).ToString());
                lv.SubItems.Add(Reader.GetString(1).ToString());
                lv.SubItems.Add(Reader.GetString(2).ToString());
                lv.SubItems.Add(Reader.GetDecimal(3).ToString());
                listView2.Items.Add(lv);
            }
            Reader.Close();
            cnn.Close();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ADD_BRANCH_Load(object sender, EventArgs e)
        {
            listView2.GridLines = true;
            listView2.View = View.Details;
            //Add Column Header
            listView2.Columns.Add("BRANCH_NO", 150);
            listView2.Columns.Add("BANK_CODE", 150);
            listView2.Columns.Add("BRANCH_ADDRESS", 150);
            listView2.Columns.Add("ADMIN_ID", 150);
        }

        
    }
}
