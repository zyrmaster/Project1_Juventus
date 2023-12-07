using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL.Models;
using Microsoft.IdentityModel.Tokens;

namespace GUI
{
    public partial class CustomerAdd : Form
    {
        CustomerBUS customerBUS = new CustomerBUS();
        public CustomerAdd()
        {
            InitializeComponent();
            customerIdTxt.Text = (customerBUS.GetLastCustomerID() + 1).ToString();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if(customerIdTxt.Text.IsNullOrEmpty() || customerNameTxt.Text.IsNullOrEmpty()||addressTxt.Text.IsNullOrEmpty()) 
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (customerBUS.CheckPhoneExits(phoneTxt.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Customer customer = new Customer();
            customer.Id = Convert.ToInt32(customerIdTxt.Text);
            customer.CustomerName = customerNameTxt.Text;
            customer.Address = addressTxt.Text;
            customer.Phone = phoneTxt.Text;
            customer.Point = 0;
            if (customerBUS.AddCustomerBUS(customer))
            {
                MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
