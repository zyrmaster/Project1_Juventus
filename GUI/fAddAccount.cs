using BUS;
using DAL.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fAddAccount : Form
    {
        AccountBUS acccountBUS = new AccountBUS();
        EmployerBUS EmployerBUS = new EmployerBUS();
        public fAddAccount()
        {
            InitializeComponent();
            IDEmployee.Text = (EmployerBUS.GetLastEmployee() + 1).ToString();
            EmployeeAccountID.Text = (acccountBUS.GetLast() + 1).ToString();
            idAccount.Text = EmployeeAccountID.Text;
            displayNameAccount.Text = $"Tài khoản {EmployeeAccountID.Text}";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddAccount();
        }
        public void AddAccount()
        {
            if (string.IsNullOrEmpty(idAccount.Text) || string.IsNullOrEmpty(usernameAccount.Text) ||
                string.IsNullOrEmpty(displayNameAccount.Text) || string.IsNullOrEmpty(passwordAccount.Text) ||
                string.IsNullOrEmpty(retypePass.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int accountId;
            if (!int.TryParse(idAccount.Text, out accountId))
            {
                MessageBox.Show("ID tài khoản không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordAccount.Text) || string.IsNullOrWhiteSpace(retypePass.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (passwordAccount.Text != retypePass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Account account = new Account
            {
                Id = accountId,
                Username = usernameAccount.Text,
                DisplayName = displayNameAccount.Text,
                Password = passwordAccount.Text,
                RoleId = 1
            };
            try
            {
                if (acccountBUS.AddAccount(account))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                }
        }
        public void AddEmployee()
        {
            Employee account = new Employee();

        }

        private void roleId_TextChanged(object sender, EventArgs e)
        {
            if (roleId.Text == "1")
            {
                roleName.Text = "Quản lý";
            }
            else if (roleId.Text == "2")
            {
                roleName.Text = "Nhân viên";
            }
            else if (roleId.Text == "99")
            {
                roleName.Text = "Quản trị";
            }
            else
            {
                roleName.Text = "Không xác định";
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
