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
    public partial class CreateBill : Form
    {
        ProductServicesBUS servicesBUS = new ProductServicesBUS();
        TableServicesBUS tableServicesBUS = new TableServicesBUS();
        BillServicesBUS BillServiceBUS = new BillServicesBUS();
        CustomerBUS customerBUS = new CustomerBUS();
        ProductServicesBUS ProductServicesBUS = new ProductServicesBUS();
        Product product = new Product();
        Employee _employee = new Employee();
        Boolean pay = false;
        double totalMoneyNum;
        Bill bill = new Bill();
        public CreateBill(int type, Employee employee, int billIdExits)
        {
            _employee = employee;
            InitializeComponent();
            LoadProduct();
            GetTable();
            if (type == 0)
            {
                billCode.Text = "Mã hoá đơn : " + ((BillServiceBUS.GetLastIDBill()) + 1).ToString();
                confirmBtn.Visible = true;
            }
            totalMoney.Text = _employee.EmployeeName.ToString();
            if (type == 1)
            {
                addBtn.Visible = true;
                List<BillInfo> billInfos = new List<BillInfo>();
                billInfos = BillServiceBUS.GetBillInfoBUS(billIdExits);
                foreach (var billInfo in billInfos)
                {
                    Product product = new Product();
                    ProductWithQuantity productWithQuantity = new ProductWithQuantity();
                    productWithQuantity.OriginalProduct = ProductServicesBUS.GetProductByID(billInfo.ProductId);
                    productWithQuantity.Quantity = billInfo.CountValue;
                    _prodcutListSell.Add(productWithQuantity);
                }
                ShowCart();
                bill = BillServiceBUS.GetBill(billIdExits);
                _customer = customerBUS.GetCustomerById(bill.CustomerId);
                phoneCustomer.Enabled = false;
                phoneCustomer.Text = $"{_customer.Phone}";
                customerName.Text = $"{_customer.CustomerName}";
                billCode.Text = $"Mã hoá đơn : {billIdExits}";

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
        private List<Product> _lstProduct = new List<Product>();
        List<ProductWithQuantity> _prodcutListSell = new List<ProductWithQuantity>();
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
                    var IsTrue = _lstProduct.FirstOrDefault(c => c.Id == product.Id);
                    if (IsTrue == null)
                    {
                        productSell.doubleClickSender += new EventHandler(AppendCart);
                        productShow.Controls.Add(productSell);
                    }

                }
            }
        }
        public void AppendCart(object sender, EventArgs e)
        {
            if (sender is ProductSell clickedProductSell)
            {
                int productId = clickedProductSell.ProductIdCart;

                var existingProduct = _prodcutListSell.FirstOrDefault(p => p.OriginalProduct.Id == productId);

                if (existingProduct == null)
                {
                    Product product = servicesBUS.GetProductByID(productId);
                    ProductWithQuantity newProductWithQuantity = new ProductWithQuantity { OriginalProduct = product, Quantity = 1 };
                    _prodcutListSell.Add(newProductWithQuantity);
                    ShowCart();
                }
                else
                {
                    MessageBox.Show("Sản phẩm đã tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ShowCart()
        {
            billControl.Controls.Clear();
            foreach (ProductWithQuantity productWithQuantity in _prodcutListSell)
            {
                Product originalProduct = productWithQuantity.OriginalProduct;
                int quantity = productWithQuantity.Quantity;
                ProductCart productCart = new ProductCart(originalProduct.Id, quantity);
                productCart.removeClickSender += RemoveCart;
                productCart.ValuesChanged += ChangeQuantily;
                CaculatorAll();
                billControl.Controls.Add(productCart);
            }
        }

        private void ChangeQuantily(object? sender, (int Quantity, int OtherValue) e)
        {
            AdjustProductQuantity(e.OtherValue, e.Quantity);
            ShowCart();
            CaculatorAll();
        }

        private void RemoveCart(object? sender, int e)
        {
            _prodcutListSell.RemoveAll(p => p.OriginalProduct.Id == e);
            ShowCart();
            CaculatorAll();
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
        public void AdjustProductQuantity(int productId, int newQuantity)
        {
            ProductWithQuantity existingProduct = _prodcutListSell.FirstOrDefault(p => p.OriginalProduct.Id == productId);

            if (existingProduct != null)
            {
                existingProduct.Quantity = newQuantity;

                ShowCart();
            }
            else
            {
                MessageBox.Show("Sản phẩm không tồn tại trong giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        public void CaculatorTotalMoney()
        {
            totalMoneyNum = 0;
            foreach (var productWithQuantity in _prodcutListSell)
            {
                totalMoneyNum += productWithQuantity.OriginalProduct.Price * productWithQuantity.Quantity;
            }
            totalMoney.Text = totalMoneyNum.ToString();
        }
        public void CaculatorAll()
        {
            CaculatorTotalMoney();
            if (totalMoney.Text.IsNullOrEmpty() || customerMoney.Text.IsNullOrEmpty())
            {
                return;
            }
            double leftMoneyNum = Convert.ToDouble(customerMoney.Text) - Convert.ToDouble(totalMoney.Text);
            if (leftMoneyNum > 0)
            {
                leftMoney.Text = leftMoneyNum.ToString();
            }
            else
            {
                leftMoney.Text = "?";
            }
        }
        private void totalMoney_TextChanged(object sender, EventArgs e)
        {
            CaculatorAll();
        }

        private void customerMoney_SelectedIndexChanged(object sender, EventArgs e)
        {
            CaculatorAll();
        }

        private void customerMoney_TextChanged(object sender, EventArgs e)
        {
            CaculatorAll();
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
            if (bill.Id == 0)
            {
                CreateNewBill();
                this.Close();
            }
            else
            {
                if (BillServiceBUS.SetBillStatusBUS(bill.Id, "1"))
                {
                    MessageBox.Show("Thanh toán thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        private void postBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa hỗ trợ thanh toán qua POS !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        Customer _customer = new Customer();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Customer customer = customerBUS.GetCustomerByPhone(phoneCustomer.Text);

            if (customer != null)
            {
                _customer = customer;
                customerName.Text = customer.CustomerName;
            }
            else
            {
                customerName.Text = string.Empty;
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            CreateNewBill();
        }
        public void CreateNewBill()
        {
            Bill bill = new Bill();
            bill.Id = (BillServiceBUS.GetLastIDBill() + 1);
            bill.DateIn = DateTime.Now;
            bill.DateOut = DateTime.Today;
            bill.Status = "0";  // chua thanh toan
            bill.PriceTotal = Convert.ToDouble(totalMoney.Text);
            if (typeBill.Text == "Tại quán")
            {
                bill.TableId = Convert.ToInt32(tableList.Text);
            }
            else if (typeBill.Text == "Mang đi")
            {
                bill.TableId = 9999;
            }
            else { bill.TableId = 1; }
            bill.CustomerId = _customer.Id;
            bill.EmployeeId = _employee.Id;
            int countProduct = 0;
            if (BillServiceBUS.CreateBillBUS(bill))
            {
                int BillID = bill.Id;
                foreach (var product in _prodcutListSell)
                {
                    int productId = product.OriginalProduct.Id;
                    int quantily = product.Quantity;
                    if (BillServiceBUS.AddProductIntoBillBUS(BillID, productId, quantily))
                    {
                        countProduct++;
                    }
                }
                if (countProduct == _prodcutListSell.Count)
                {
                    MessageBox.Show("Thêm hóa đơn thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi tạo hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddProductsToExistingBill(Bill existingBill)
        {
            try
            {
                if (existingBill == null)
                {
                    MessageBox.Show("Hóa đơn không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (BillServiceBUS.DeleteBillInfoByBillIdBUS(existingBill.Id))
                {
                    int countProduct = 0;
                    foreach (var product in _prodcutListSell)
                    {
                        int productId = product.OriginalProduct.Id;
                        int quantily = product.Quantity;

                        if (BillServiceBUS.AddProductIntoBillBUS(existingBill.Id, productId, quantily))
                        {
                            countProduct++;
                        }
                    }

                    if (countProduct == _prodcutListSell.Count)
                    {
                        MessageBox.Show("Thêm sản phẩm vào hóa đơn thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi thêm sản phẩm vào hóa đơn: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            BillServiceBUS.AddProductIntoBillBUS(16, 1, 1);
        }

        private void typeBill_TextChanged(object sender, EventArgs e)
        {
            if (typeBill.Text == "Tại quán")
            {
                tableList.Enabled = true;
            }
            else if (typeBill.Text == "Mang đi")
            {
                tableList.Enabled = false;
            }
            else { tableList.Enabled = false; }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddProductsToExistingBill(bill);
        }

        private void bankBtn_Click(object sender, EventArgs e)
        {
            if (bill.Id == 0)
            {
                CreateNewBill();
                this.Close();
            }
            else
            {
                if (BillServiceBUS.SetBillStatusBUS(bill.Id, "1"))
                {
                    MessageBox.Show("Thanh toán thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
