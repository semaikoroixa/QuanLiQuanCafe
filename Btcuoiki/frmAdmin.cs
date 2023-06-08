using Btcuoiki.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            DateTimePickerBill();
            LoadListByDate(dtpFromDate.Value, dtpToDate.Value);
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

        #region Methods
        void LoadListByDate(DateTime checkIn, DateTime checkOut)
        {
            dgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        void DateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            LoadListByDate(dtpFromDate.Value, dtpToDate.Value);
        }
        #endregion
    }
}
