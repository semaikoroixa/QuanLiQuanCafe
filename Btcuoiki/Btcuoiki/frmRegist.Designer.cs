namespace Btcuoiki
{
    partial class frmRegist
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
            panel1 = new Panel();
            txtTendangnhap = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txtMatkhau = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            txtTenhienthi = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txtMabaomat = new TextBox();
            label4 = new Label();
            btnDangki = new Button();
            btnThoat = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTendangnhap);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(11, 12);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 53);
            panel1.TabIndex = 1;
            // 
            // txtTendangnhap
            // 
            txtTendangnhap.Location = new Point(124, 13);
            txtTendangnhap.Margin = new Padding(2, 3, 2, 3);
            txtTendangnhap.Name = "txtTendangnhap";
            txtTendangnhap.Size = new Size(236, 25);
            txtTendangnhap.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(2, 17);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 19);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtMatkhau);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(11, 94);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 53);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(124, 13);
            txtMatkhau.Margin = new Padding(2, 3, 2, 3);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(236, 25);
            txtMatkhau.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(2, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 0;
            label1.Text = "Mật Khẩu:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTenhienthi);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(13, 174);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(377, 53);
            panel3.TabIndex = 1;
            panel3.Paint += panel2_Paint;
            // 
            // txtTenhienthi
            // 
            txtTenhienthi.Location = new Point(124, 13);
            txtTenhienthi.Margin = new Padding(2, 3, 2, 3);
            txtTenhienthi.Name = "txtTenhienthi";
            txtTenhienthi.Size = new Size(236, 25);
            txtTenhienthi.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(2, 17);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 0;
            label3.Text = "Tên hiển thị:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtMabaomat);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(11, 253);
            panel4.Margin = new Padding(2, 3, 2, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(377, 53);
            panel4.TabIndex = 1;
            panel4.Paint += panel2_Paint;
            // 
            // txtMabaomat
            // 
            txtMabaomat.Location = new Point(124, 13);
            txtMabaomat.Margin = new Padding(2, 3, 2, 3);
            txtMabaomat.Name = "txtMabaomat";
            txtMabaomat.Size = new Size(236, 25);
            txtMabaomat.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Purple;
            label4.Location = new Point(2, 17);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 19);
            label4.TabIndex = 0;
            label4.Text = "Mã bảo mật:";
            // 
            // btnDangki
            // 
            btnDangki.BackColor = SystemColors.Control;
            btnDangki.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangki.ForeColor = Color.Purple;
            btnDangki.Location = new Point(218, 324);
            btnDangki.Margin = new Padding(2, 3, 2, 3);
            btnDangki.Name = "btnDangki";
            btnDangki.Size = new Size(82, 29);
            btnDangki.TabIndex = 2;
            btnDangki.Text = "Đăng kí";
            btnDangki.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.Purple;
            btnThoat.Location = new Point(306, 324);
            btnThoat.Margin = new Padding(2, 3, 2, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(82, 29);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmRegist
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 371);
            Controls.Add(btnThoat);
            Controls.Add(btnDangki);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(2, 3, 2, 3);
            Name = "frmRegist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng kí ";
            Load += frmRegist_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtTendangnhap;
        private Label label2;
        private Panel panel2;
        private TextBox txtMatkhau;
        private Label label1;
        private Panel panel3;
        private TextBox txtTenhienthi;
        private Label label3;
        private Panel panel4;
        private TextBox txtMabaomat;
        private Label label4;
        private Button btnDangki;
        private Button btnThoat;
    }
}