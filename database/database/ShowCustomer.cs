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
    public partial class ShowCustomer : Form
    {
        public ShowCustomer()
        {
            InitializeComponent();
        }

        private void ShowCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_SystemDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.bank_SystemDataSet.CUSTOMER);

        }
    }
}
