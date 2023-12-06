using GUI.Services;
using BUS;
using DAL.Models;

namespace GUI

{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        Validates validates = new Validates();
        AccountBUS accountServices = new AccountBUS();
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (accountServices.AccountChecking(usernameTextBox.Text.ToString()))
            {
                if (accountServices.AuthAccount(usernameTextBox.Text, passwordTextBox.Text))
                {
                    Account _account = accountServices.GetInfoAccountByUsernameBUS(usernameTextBox.Text.ToString());
                    fTableManager f = new fTableManager(_account);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác !! , vui lòng kiểm tra lại !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại trong hệ thống , vui lòng kiểm tra lại !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if (usernameTextBox.Text.Length == 0 || usernameTextBox.Text == "Tên đăng nhập...")
            //{
            //    MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (passwordTextBox.Text.Length == 0 || passwordTextBox.Text == "Password")
            //{
            //    MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}



        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Tên đăng nhập...")
            {
                usernameTextBox.Text = string.Empty;
            }
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "PasswordLogin")
            {
                passwordTextBox.Text = string.Empty;
            }
        }

        private void ShowPasscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasscheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void FailShowButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ CSKH hoặc Quản trị phần mềm để báo lỗi sử dụng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a MessageBox asking the user if they really want to exit
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks "No", cancel the form closing event
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void fLogin_Load(object sender, EventArgs e)
        {

        }
        private void fLogin_FormClosing(object sender, EventArgs e)
        {
        }

        private void SavePassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SavePassCheckBox.Checked)
            {
                
;
            }
        }
    }
}