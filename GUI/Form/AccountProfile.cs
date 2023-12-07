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
    public partial class AccountProfile : Form
    {
        Employee _employee = new Employee();
        AccountBUS acccountServicesBUS = new AccountBUS();
        Account account = new Account();
        string password;
        public AccountProfile(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            account = acccountServicesBUS.GetAccountByIdBUS(Convert.ToInt32(_employee.AccountId));
            IDEmployee.Text = _employee.Id.ToString();
            displayEmployee.Text = _employee.EmployeeName.ToString();
            potisionEmployee.Text = _employee.Potision.ToString();
            salaryEmployee.Text = _employee.Salary.ToString();
            EmployeeAccountID.Text = _employee.AccountId.ToString();
            idAccount.Text = _employee.AccountId.ToString();
            displayNameAccount.Text = account.DisplayName.ToString();
            usernameAccount.Text = account.Username.ToString();
            password = account.Password.ToString();
            int role = acccountServicesBUS.getRole(account.Username);
            roleId.Text = role.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (newPassword.Text.IsNullOrEmpty() || rePassword.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (newPassword.Text == rePassword.Text)
                {
                    if (passwordAccount.Text == password)
                    {
                        Account _account = new Account();
                        _account.Id = account.Id;
                        _account.Username = account.Username;
                        _account.RoleId = account.RoleId;
                        _account.DisplayName = account.DisplayName;
                        _account.Password = newPassword.Text;
                        if (acccountServicesBUS.EditAccountBUS(_account))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
