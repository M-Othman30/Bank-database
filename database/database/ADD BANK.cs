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
    public partial class ADD_BANK : Form
    {
        public ADD_BANK()
        {
            InitializeComponent();
        }
        string con = ("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlcommand.CommandText = "INSERT INTO BANK Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("Bank Successfully Registered");
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Chnage sqlquery and table name
            string sql = "select BANK_CODE, BANK_NAME, BANK_ADDRESS, ADMIN_ID from BANK";
            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetString(0).ToString());
                lv.SubItems.Add(Reader.GetString(1).ToString());
                lv.SubItems.Add(Reader.GetString(2).ToString());
                lv.SubItems.Add(Reader.GetDecimal(3).ToString());
                listView1.Items.Add(lv);
            }
            Reader.Close();
            cnn.Close();
        }

        private void ADD_BANK_Load(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            listView1.View = View.Details;
            //Add Column Header
            listView1.Columns.Add("BANK_CODE", 150);
            listView1.Columns.Add("BANK_NAME", 150);
            listView1.Columns.Add("BANK_ADDRESS", 150);
            listView1.Columns.Add("ADMIN_ID", 150);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
