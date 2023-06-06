using Btcuoiki.DAO;
using Nest;
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

namespace Btcuoiki
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();

            LoadAcountList();
        }

        void LoadAcountList()
        {
            string query = "exec dbo.USP_GetAccountByUserName @userName  ";
            DataProvider provider = new DataProvider();
            dgvAccount.DataSource = provider.Executequery(query,new object[] { "nguyenminhmanh", "dangcap" });

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResetpassword_Click(object sender, EventArgs e)
        {

        }

        private void btnResetpassword_Click_1(object sender, EventArgs e)
        {

        }
    }
}
