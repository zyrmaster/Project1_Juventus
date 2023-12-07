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
    public partial class CustomerControl : Form
    {
        CustomerBUS customerBUS = new CustomerBUS();
        public CustomerControl()
        {
            InitializeComponent();
            LoadCustomer();
        }
        public void LoadCustomer()
        {
            customerPanel.Controls.Clear();
            List<Customer> customers = new List<Customer>();
            customers = customerBUS.GetAll();
            foreach (Customer customer in customers)
            {
                ctCustomerPanel ctCustomerPanel = new ctCustomerPanel(customer);
                customerPanel.Controls.Add(ctCustomerPanel);
            }
        }

        private void listCustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerAdd customerAdd = new CustomerAdd();
            customerAdd.ShowDialog();
            LoadCustomer();
        }

        private void refersh_Click(object sender, EventArgs e)
        {
            LoadCustomer();
            nameFind.Text = string.Empty;
        }

        private void nameFind_TextChanged(object sender, EventArgs e)
        {
            PerformSearch(nameFind.Text);

        }
        private void PerformSearch(string name)
        {
            List<Customer> customers = customerBUS.GetAll();
            customerPanel.Controls.Clear();
            foreach (Customer customer in customers)
            {
                if (customer.CustomerName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    ctCustomerPanel ctCustomerPanel = new ctCustomerPanel(customer);
                    customerPanel.Controls.Add(ctCustomerPanel);
                }
            }
        }
        private void PerformSearchAddress(string Address)
        {
            List<Customer> customers = customerBUS.GetAll();
            customerPanel.Controls.Clear();
            foreach (Customer customer in customers)
            {
                if (customer.Address.IndexOf(Address, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    ctCustomerPanel ctCustomerPanel = new ctCustomerPanel(customer);
                    customerPanel.Controls.Add(ctCustomerPanel);
                }
            }
        }
        private void nameFind_Click(object sender, EventArgs e)
        {
            nameFind.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PerformSearchAddress(textBox1.Text);
        }
    }
}
