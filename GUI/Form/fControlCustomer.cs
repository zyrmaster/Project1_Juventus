using BUS;
using DAL.Models;
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
    public partial class fControlCustomer : Form
    {
        CustomerBUS customerBUS = new CustomerBUS();
        Customer _customer = new Customer();
        public fControlCustomer(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            customerIdTxt.Text = _customer.Id.ToString();
            customerNameTxt.Text = _customer.CustomerName.ToString();
            phoneTxt.Text = _customer.Phone.ToString();
            pointTxt.Text = _customer.Point.ToString();
            addressTxt.Text = _customer.Address.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerName = customerNameTxt.Text;
            customer.Phone = phoneTxt.Text;
            customer.Address = addressTxt.Text;
            customer.Point = Convert.ToInt32(pointTxt.Text);
            customer.Id = Convert.ToInt32(customerIdTxt.Text);
            if (customerBUS.EditCustomerBUS(customer))
            {
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
