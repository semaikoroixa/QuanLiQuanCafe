using Btcuoiki.DAO;
using Btcuoiki.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Btcuoiki
{
    public partial class frmtableManager : Form
    {
        public frmtableManager()
        {
            InitializeComponent();

            LoadTable();
            LoadCategory();
            LoadComboboxTable(cmbSwitch);
        }

        #region Method
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cmbCategory.DataSource = listCategory;
            cmbCategory.DisplayMember = "Name";
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetListFoodByCategoryID(id);
            cmbFood.DataSource = listFood;
            cmbFood.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flpTable1.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightCyan;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flpTable1.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            //Thread.CurrentThread.CurrentCulture=culture;
            txtTotalPrice.Text = totalPrice.ToString("N2", culture);

        }
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        #endregion
        #region Events
        private void btn_Click(object? sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cmbFood.SelectedItem as Food).ID;
            int count = (int)nudFoodCount.Value;
            //th1:bill chua ton tai
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            //th2 bill da ton tai
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountProfile f = new frmAccountProfile();
            f.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quảnLíToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            f.ShowDialog();
        }
        #endregion

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);

        }

        private void cmbFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nudDiscount.Value;
            string totalPriceText = txtTotalPrice.Text; /*Replace(",", " ");*/
            double totalPrice = Convert.ToDouble(totalPriceText.Split('.')[0]);
            totalPrice *= 1000;
            if (totalPrice < 10000 && totalPrice > 0)
            {
                string[] parts = txtTotalPrice.Text.Split('.');
                double[] prices = new double[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    if (double.TryParse(parts[i], out double price))
                    {
                        prices[i] = price;
                    }


                }
                totalPrice += prices[1];
                totalPrice *= 1000;
                foreach (double price in prices)
                {
                    Console.WriteLine(price);
                }

            }
            if (totalPrice == 0)
            {
                totalPrice = 0;
            }


            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn chắc chắn thanh toán hóa đơn cho{0}\n Tổng tiền - (Tổng tiền/100) x Giảm giá\n=> {1} -  ({1} / 100) x {2} = {3} ", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount,(float)finalTotalPrice);
                    ShowBill(table.ID);
                    LoadTable();

                }
            }
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {


            int id1 = (lsvBill.Tag as Table).ID;
            int id2 = (cmbSwitch.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có muốn chuyển bàn {0} qua bàn {1} đúng không", (lsvBill.Tag as Table).Name, (cmbSwitch.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                TableDAO.Instance.SwitchTable(id1, id2);
            LoadTable();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
