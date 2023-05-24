using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database
{
    public partial class Employee_Works : Form
    {
        public Employee_Works()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_Employee emp = new Update_Employee();
            emp.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Customer cust = new Add_Customer();
            cust.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateBankAC cba = new CreateBankAC();
            cba.Show();
        }

        private void Employee_Works_Load(object sender, EventArgs e)
        {
            
            this.cUSTOMERTableAdapter.Fill(this.bank_SystemDataSet.CUSTOMER);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowCustomer sc = new ShowCustomer();
            sc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoanList ll = new LoanList();
            ll.Show();
        }
    }
}
