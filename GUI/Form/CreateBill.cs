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
        Product product = new Product();
        public CreateBill()
        {
            InitializeComponent();
            LoadProduct();
        }
        public void LoadProduct()
        {
            productShow.Controls.Clear();
            List<Product> products = servicesBUS.GetAllProductBUS();

            foreach (Product product in products)
            {
                ProductSell productSell = new ProductSell(product.Id);
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
                    productShow.Controls.Add(productSell);
                }
            }
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            FindByName(textBox4.Text);
        }
    }
}
