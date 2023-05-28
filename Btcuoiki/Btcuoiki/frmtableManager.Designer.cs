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
            NumericUpDown nudFoodCount;
            NumericUpDown numericUpDown1;
            panel2 = new Panel();
            lsvBill = new ListView();
            panel1 = new Panel();
            btnSwitch = new Button();
            btnDiscount = new Button();
            cmbSwitch = new ComboBox();
            btnCheckout = new Button();
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
            nudFoodCount = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudFoodCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(272, 53);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(94, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
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
            lsvBill.Location = new Point(3, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(463, 389);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSwitch);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(btnDiscount);
            panel1.Controls.Add(cmbSwitch);
            panel1.Controls.Add(btnCheckout);
            panel1.Location = new Point(501, 542);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 85);
            panel1.TabIndex = 4;
            // 
            // btnSwitch
            // 
            btnSwitch.BackColor = SystemColors.ControlLight;
            btnSwitch.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSwitch.Location = new Point(3, 7);
            btnSwitch.Name = "btnSwitch";
            btnSwitch.Size = new Size(94, 40);
            btnSwitch.TabIndex = 1;
            btnSwitch.Text = "Chuyển bàn ";
            btnSwitch.UseVisualStyleBackColor = false;
            btnSwitch.Click += btnAddFood_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.BackColor = SystemColors.ControlLight;
            btnDiscount.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiscount.Location = new Point(272, 7);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(94, 40);
            btnDiscount.TabIndex = 1;
            btnDiscount.Text = "Giảm giá ";
            btnDiscount.UseVisualStyleBackColor = false;
            btnDiscount.Click += btnAddFood_Click;
            // 
            // cmbSwitch
            // 
            cmbSwitch.FormattingEnabled = true;
            cmbSwitch.Location = new Point(3, 52);
            cmbSwitch.Name = "cmbSwitch";
            cmbSwitch.Size = new Size(94, 28);
            cmbSwitch.TabIndex = 0;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = SystemColors.ControlLight;
            btnCheckout.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckout.Location = new Point(372, 7);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(94, 75);
            btnCheckout.TabIndex = 1;
            btnCheckout.Text = "Thanh toán";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnAddFood_Click;
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
            // 
            // cmbFood
            // 
            cmbFood.FormattingEnabled = true;
            cmbFood.Location = new Point(13, 61);
            cmbFood.Name = "cmbFood";
            cmbFood.Size = new Size(285, 28);
            cmbFood.TabIndex = 0;
            // 
            // flpTable
            // 
            flpTable.Location = new Point(12, 31);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(483, 596);
            flpTable.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
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
        private Button btnSwitch;
        private Button btnDiscount;
        private ComboBox cmbSwitch;
        private Button btnCheckout;
        private FlowLayoutPanel flpTable;
    }
}