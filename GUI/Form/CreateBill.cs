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
    public partial class CreateBill : Form
    {
        ProductServicesBUS servicesBUS = new ProductServicesBUS();
        TableServicesBUS tableServicesBUS = new TableServicesBUS();
        BillServicesBUS BillServiceBUS = new BillServicesBUS();
        CustomerBUS customerBUS = new CustomerBUS();
        Product product = new Product();
        Boolean pay = false;
        public CreateBill(int type)
        {
            InitializeComponent();
            LoadProduct();
            GetTable();
            if (type == 0)
            {
                billCode.Text = "Mã hoá đơn : " + ((BillServiceBUS.GetLastIDBill()) + 1).ToString();
            }
        }
        public void InitPay()
        {
            if (pay)
            {
                cashBtn.Visible = true;
                bankBtn.Visible = true;
                postBtn.Visible = true;
                getoutBtn.Visible = true;
                confirmBtn.Visible = false;
                payBtn.Visible = false;
                printBtn.Visible = false;
                exitBtn.Visible = false;
            }
            else if (!pay)
            {
                cashBtn.Visible = false;
                bankBtn.Visible = false;
                postBtn.Visible = false;
                getoutBtn.Visible = false;
                confirmBtn.Visible = true;
                payBtn.Visible = true;
                printBtn.Visible = true;
                exitBtn.Visible = true;
            }
        }
        public void LoadProduct()
        {
            productShow.Controls.Clear();
            List<Product> products = servicesBUS.GetAllProductBUS();

            foreach (Product product in products)
            {
                ProductSell productSell = new ProductSell(product.Id);
                productSell.doubleClickSender += new EventHandler(AppendCart);
                productShow.Controls.Add(productSell);
            }
        }
        public void FindByName(string name)
        {
            productShow.Controls.Clear();
            List<Product> products = servicesBUS.GetAllProductBUS();

            foreach (Product product in products)
            {
                if (product.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    ProductSell productSell = new ProductSell(product.Id);
                    productSell.doubleClickSender += new EventHandler(AppendCart);
                    productShow.Controls.Add(productSell);
                }
            }
        }
        private List<Product> _lstProduct = new List<Product>();
        public void AppendCart(object sender, EventArgs e)
        {
            ProductSell clickedProductSell = sender as ProductSell;

            if (clickedProductSell != null)
            {
                ProductCart productCart = new ProductCart(clickedProductSell.ProductIdCart);
                _lstProduct.Add(servicesBUS.GetProductByID(clickedProductSell.ProductIdCart));
                totalMoney.Text = CountMoney().ToString();
                billControl.Controls.Add(productCart);
            }
        }
        private List<Table> _lstTable = new List<Table>();
        public void GetTable()
        {
            _lstTable = tableServicesBUS.GetAllTableLst();
            foreach (Table table in _lstTable)
            {
                tableList.Items.Add(table.Id);
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            FindByName(textBox4.Text);
        }
        public double CountMoney()
        {
            double money = 0;
            foreach (Product product in _lstProduct)
            {
                money = money + product.Price;
            }
            return money;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Caculator();
        }
        public void Caculator()
        {
            int totalMoney = (int)CountMoney();
            int tradeMoney = Convert.ToInt32(customerMoney.Text);
            int leftmoney = tradeMoney - totalMoney;
            leftMoney.Text = leftmoney.ToString();
        }

        private void totalMoney_TextChanged(object sender, EventArgs e)
        {
            if (customerMoney.Text.Length > 0)
            {
                Caculator();
            }
        }

        private void customerMoney_SelectedIndexChanged(object sender, EventArgs e)
        {
            Caculator();
        }

        private void customerMoney_TextChanged(object sender, EventArgs e)
        {
            Caculator();
        }

        private void discountCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (discountCheck.Checked)
            {
                inputDiscount.Visible = true;
            }
            else if (!discountCheck.Checked)
            {
                inputDiscount.Visible = false;
            }
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            CustomerAdd customerAdd = new CustomerAdd();
            customerAdd.ShowDialog();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            pay = true;
            InitPay();
        }

        private void getoutBtn_Click(object sender, EventArgs e)
        {
            pay = false;
            InitPay();
        }

        private void cashBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(leftMoney) < 0 || leftMoney.Text.Length < 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Thanh toán thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void postBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa hỗ trợ thanh toán qua POS !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customerBUS.GetCustomerByPhone(phoneCustomer.Text);
            if (customer != null)
            {
                customerName.Text = customer.CustomerName;
            }
        }
    }
}
