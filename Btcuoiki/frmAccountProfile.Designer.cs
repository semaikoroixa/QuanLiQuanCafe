namespace Btcuoiki
{
    partial class frmAccountProfile
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
            txtRepeat = new TextBox();
            label2 = new Label();
            txtUserName = new TextBox();
            panel2 = new Panel();
            txtNewPassword = new TextBox();
            label1 = new Label();
            txtDisplayname = new TextBox();
            panel3 = new Panel();
            txtPassword = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtRepeat);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 310);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 53);
            panel1.TabIndex = 1;
            // 
            // txtRepeat
            // 
            txtRepeat.Location = new Point(171, 13);
            txtRepeat.Name = "txtRepeat";
            txtRepeat.Size = new Size(415, 27);
            txtRepeat.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 0;
            label2.Text = "Nhập lại:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(171, 13);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(411, 27);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += txtDisplayName_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtNewPassword);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 241);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 53);
            panel2.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(171, 13);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(411, 27);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.TextChanged += txtNewPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(121, 19);
            label1.TabIndex = 0;
            label1.Text = "Mật khẩu mới:";
            // 
            // txtDisplayname
            // 
            txtDisplayname.Location = new Point(171, 13);
            txtDisplayname.Name = "txtDisplayname";
            txtDisplayname.Size = new Size(411, 27);
            txtDisplayname.TabIndex = 1;
            txtDisplayname.TextChanged += txtUserName_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 167);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 53);
            panel3.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(171, 13);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(411, 27);
            txtPassword.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(3, 17);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtUserName);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(12, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(600, 53);
            panel4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Purple;
            label4.Location = new Point(3, 17);
            label4.Name = "label4";
            label4.Size = new Size(107, 19);
            label4.TabIndex = 0;
            label4.Text = "Tên hiển thị:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtDisplayname);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(12, 93);
            panel5.Name = "panel5";
            panel5.Size = new Size(600, 53);
            panel5.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Purple;
            label5.Location = new Point(3, 17);
            label5.Name = "label5";
            label5.Size = new Size(132, 19);
            label5.TabIndex = 0;
            label5.Text = "Tên đăng nhập:";
            label5.Click += label5_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(336, 369);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(128, 35);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(470, 369);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(128, 35);
            btnExit.TabIndex = 2;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmAccountProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 417);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtRepeat;
        private Label label2;
        private Panel panel2;
        private TextBox txtNewPassword;
        private Label label1;
        private Panel panel3;
        private TextBox txtPassword;
        private Label label3;
        private Panel panel4;
        private TextBox txtDisplayname;
        private Label label4;
        private Panel panel5;
        private TextBox txtUserName;
        private Label label5;
        private Button btnUpdate;
        private Button btnExit;
    }
}