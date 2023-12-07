using BUS;
using GUI;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{

    public partial class ProductSell : UserControl
    {
        ProductServicesBUS servicesBUS = new ProductServicesBUS();
        Product product = new Product();
        public event EventHandler doubleClickSender;
        public int ProductIdCart { get; set; }
        public ProductSell(int ProductId)
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.None;
            this.Dock = DockStyle.None;
            product = servicesBUS.GetProductByIDBUS(ProductId);
            nameProduct.Text = product.Name;
            switch (product.CategoryId)
            {
                case 1:
                    cateSort.Text = "Đồ uống";
                    break;
                case 2:
                    cateSort.Text = "Đồ ăn";
                    break;
                case 3:
                    cateSort.Text = "Dịch vụ";
                    break;
                default:
                    cateSort.Text = "Không xác định";
                    break;
            }
            priceProduct.Text = product.Price.ToString() + "K";
            sizeProduct.Text = product.ProductType.ToString();
        }
        private void ProductSell_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProductIdCart = product.Id;
            doubleClickSender(sender, e);
        }
    }
}
