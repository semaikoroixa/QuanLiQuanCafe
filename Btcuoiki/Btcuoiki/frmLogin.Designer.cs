namespace Btcuoiki
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            txtPassWord = new TextBox();
            label1 = new Label();
            btnThoat = new Button();
            panel1 = new Panel();
            txtUserName = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            btnDangKi = new Button();
            btnDangNhap = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPassWord);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 53);
            panel2.TabIndex = 0;
            panel2.Paint += panel1_Paint;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(142, 9);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(269, 27);
            txtPassWord.TabIndex = 1;
            txtPassWord.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 0;
            label1.Text = "Mật khẩu:";
            label1.Click += label1_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.Purple;
            btnThoat.Location = new Point(343, 134);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(101, 61);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát ";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 53);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(142, 13);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(269, 27);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(132, 19);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập:";
            label2.Click += label1_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Purple;
            btnLogin.Location = new Point(129, 134);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(101, 61);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Đăng nhập ";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnDangKi
            // 
            btnDangKi.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangKi.ForeColor = Color.Purple;
            btnDangKi.Location = new Point(236, 136);
            btnDangKi.Name = "btnDangKi";
            btnDangKi.Size = new Size(101, 59);
            btnDangKi.TabIndex = 2;
            btnDangKi.Text = "Đăng kí";
            btnDangKi.UseVisualStyleBackColor = true;
            btnDangKi.Click += btnDangki_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(15, 131);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(95, 67);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "button1";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 207);
            Controls.Add(btnDangNhap);
            Controls.Add(btnDangKi);
            Controls.Add(btnLogin);
            Controls.Add(btnThoat);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập ";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TextBox txtPassWord;
        private Label label1;
        private Button btnThoat;
        private Panel panel1;
        private TextBox txtUserName;
        private Label label2;
        private Button btnLogin;
        private Button btnDangKi;
        private Button btnDangNhap;
    }
}