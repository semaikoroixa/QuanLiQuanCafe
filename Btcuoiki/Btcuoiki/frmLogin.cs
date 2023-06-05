using Btcuoiki.DAO;
using System.Diagnostics.Eventing.Reader;

namespace Btcuoiki
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng chương trình ?", " Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        //button2 la nut Login
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        bool Login(string userName, string passWord)
        {

            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            frmRegist d = new frmRegist();
            d.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            if (Login(userName, passWord))
            {
                frmtableManager f = new frmtableManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }
    }
}