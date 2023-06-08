namespace Btcuoiki
{
    partial class Login
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
            textBox2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 53);
            panel2.TabIndex = 0;
            panel2.Paint += panel1_Paint;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(269, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
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
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Purple;
            button1.Location = new Point(119, 134);
            button1.Name = "button1";
            button1.Size = new Size(101, 61);
            button1.TabIndex = 1;
            button1.Text = "Thoát ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 53);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox2_TextChanged;
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
            // button2
            // 
            button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Purple;
            button2.Location = new Point(12, 134);
            button2.Name = "button2";
            button2.Size = new Size(101, 61);
            button2.TabIndex = 1;
            button2.Text = "Đăng nhập ";
            button2.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 207);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Login";
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
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
    }
}