namespace Btcuoiki
{
    partial class frmtableManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nudFoodCount = new NumericUpDown();
            panel2 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel1 = new Panel();
            btnSwitchTable = new Button();
            nudDiscount = new NumericUpDown();
            btnCheckOut = new Button();
            txtTotalPrice = new TextBox();
            cmbSwitch = new ComboBox();
            menuStrip1 = new MenuStrip();
            quảnLíToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            btnAddFood = new Button();
            cmbCategory = new ComboBox();
            cmbFood = new ComboBox();
            flpTable = new FlowLayoutPanel();
            flpTable1 = new FlowLayoutPanel();
            btnDiscount = new Button();
            ((System.ComponentModel.ISupportInitialize)nudFoodCount).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            flpTable.SuspendLayout();
            SuspendLayout();
            // 
            // nudFoodCount
            // 
            nudFoodCount.Location = new Point(404, 39);
            nudFoodCount.Name = "nudFoodCount";
            nudFoodCount.Size = new Size(51, 27);
            nudFoodCount.TabIndex = 2;
            nudFoodCount.TextAlign = HorizontalAlignment.Center;
            nudFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(501, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(469, 395);
            panel2.TabIndex = 1;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(3, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(463, 389);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "SL";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 120;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDiscount);
            panel1.Controls.Add(btnSwitchTable);
            panel1.Controls.Add(nudDiscount);
            panel1.Controls.Add(btnCheckOut);
            panel1.Controls.Add(txtTotalPrice);
            panel1.Controls.Add(cmbSwitch);
            panel1.Location = new Point(501, 542);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 85);
            panel1.TabIndex = 4;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.BackColor = SystemColors.ControlLight;
            btnSwitchTable.Font = new Font("Arial", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            btnSwitchTable.Location = new Point(3, 5);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(94, 42);
            btnSwitchTable.TabIndex = 6;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = false;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // nudDiscount
            // 
            nudDiscount.Location = new Point(120, 52);
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(94, 27);
            nudDiscount.TabIndex = 5;
            nudDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = SystemColors.ControlLight;
            btnCheckOut.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckOut.Location = new Point(362, 7);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(101, 61);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalPrice.ForeColor = Color.Red;
            txtTotalPrice.Location = new Point(231, 50);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(125, 28);
            txtTotalPrice.TabIndex = 3;
            txtTotalPrice.Text = "0";
            txtTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbSwitch
            // 
            cmbSwitch.FormattingEnabled = true;
            cmbSwitch.Location = new Point(3, 52);
            cmbSwitch.Name = "cmbSwitch";
            cmbSwitch.Size = new Size(94, 28);
            cmbSwitch.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLíToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(976, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // quảnLíToolStripMenuItem
            // 
            quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            quảnLíToolStripMenuItem.Size = new Size(67, 24);
            quảnLíToolStripMenuItem.Text = "Admin";
            quảnLíToolStripMenuItem.Click += quảnLíToolStripMenuItem_Click_1;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(151, 24);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            thôngTinTàiKhoảnToolStripMenuItem.Click += thôngTinTàiKhoảnToolStripMenuItem_Click;
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(210, 26);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(210, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(nudFoodCount);
            panel3.Controls.Add(btnAddFood);
            panel3.Controls.Add(cmbCategory);
            panel3.Controls.Add(cmbFood);
            panel3.Location = new Point(501, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(469, 103);
            panel3.TabIndex = 6;
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = SystemColors.ControlLight;
            btnAddFood.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.Location = new Point(304, 14);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(94, 75);
            btnAddFood.TabIndex = 1;
            btnAddFood.Text = "Thêm món ";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(13, 14);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(285, 28);
            cmbCategory.TabIndex = 0;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbFood
            // 
            cmbFood.FormattingEnabled = true;
            cmbFood.Location = new Point(13, 61);
            cmbFood.Name = "cmbFood";
            cmbFood.Size = new Size(285, 28);
            cmbFood.TabIndex = 0;
            cmbFood.SelectedIndexChanged += cmbFood_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.Controls.Add(flpTable1);
            flpTable.Location = new Point(15, 31);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(483, 596);
            flpTable.TabIndex = 2;
            // 
            // flpTable1
            // 
            flpTable1.AutoScroll = true;
            flpTable1.Location = new Point(3, 3);
            flpTable1.Name = "flpTable1";
            flpTable1.Size = new Size(477, 590);
            flpTable1.TabIndex = 0;
            // 
            // btnDiscount
            // 
            btnDiscount.BackColor = SystemColors.ControlLight;
            btnDiscount.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiscount.ForeColor = SystemColors.ActiveCaptionText;
            btnDiscount.Location = new Point(120, 8);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(94, 36);
            btnDiscount.TabIndex = 7;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.UseVisualStyleBackColor = false;
            // 
            // frmtableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 639);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(flpTable);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Name = "frmtableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmtableManager";
            ((System.ComponentModel.ISupportInitialize)nudFoodCount).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            flpTable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private ListView lsvBill;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLíToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel3;
        private NumericUpDown nudFoodCount;
        private Button btnAddFood;
        private ComboBox cmbCategory;
        private ComboBox cmbFood;
        private ComboBox cmbSwitch;
        private FlowLayoutPanel flpTable;
        private FlowLayoutPanel flpTable1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txtTotalPrice;
        private Button btnCheckOut;
        private NumericUpDown nudDiscount;
        private Button btnSwitchTable;
        private Button btnDiscount;
    }
}