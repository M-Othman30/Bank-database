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
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_SystemDataSet.BRANCH' table. You can move, or remove it, as needed.
            this.bRANCHTableAdapter.Fill(this.bank_SystemDataSet.BRANCH);
            // TODO: This line of code loads data into the 'bank_SystemDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.bank_SystemDataSet.EMPLOYEE);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-CK7DANV;Initial Catalog=Bank System;Integrated Security=True");
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlconnection;
                sqlconnection.Open();
                sqlcommand.CommandText = "INSERT INTO LOAN Values('" + textBox1.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','pending')";
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("Request submitted");
                this.Hide();

            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eMPLOYEETableAdapter.Fill(this.bank_SystemDataSet.EMPLOYEE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


    }
}
