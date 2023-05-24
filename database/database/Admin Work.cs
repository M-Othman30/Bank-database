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
    public partial class Admin_Work : Form
    {
        public Admin_Work()
        {
            InitializeComponent();
        }

        private void Admin_Work_Load(object sender, EventArgs e)
        {
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ADD_BANK add = new ADD_BANK();
            add.Show();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADD_BRANCH add = new ADD_BRANCH();
            add.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UPDATE_Admin update = new UPDATE_Admin();
            update.Show();
            
        }
    }
}
