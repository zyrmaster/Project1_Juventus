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
    public partial class ctCustomerPanel : UserControl
    {
        CustomerBUS customerBUS = new CustomerBUS();
        Customer _customer = new Customer();
        public ctCustomerPanel(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            idCustomer.Text = _customer.Id.ToString();
            customerName.Text = _customer.CustomerName;
            phoneNumber.Text = _customer.Phone.ToString();
            addresss.Text = _customer.Address.ToString();
            pointCustomer.Text = _customer.Point.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá khách hàng này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (customerBUS.DeleteCustomerById(_customer.Id))
                {
                    Parent.Controls.Remove(this);
                    MessageBox.Show("Xoá khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            fControlCustomer fControlCustomer = new fControlCustomer(_customer);
            fControlCustomer.ShowDialog();
        }
    }
}
