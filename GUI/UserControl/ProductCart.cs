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
    public partial class ProductCart : UserControl
    {
        ProductServicesBUS servicesBUS = new ProductServicesBUS();
        Product product = new Product();
        int ProductSet;
        public ProductCart(int ProductId)
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.None;
            this.Dock = DockStyle.None;
            product = servicesBUS.GetProductByIDBUS(ProductId);
            nameProduct.Text = product.Name;
            switch (product.CategoryId)
            {
                case 1:
                    cateProduct.Text = "Đồ uống";
                    break;
                case 2:
                    cateProduct.Text = "Đồ ăn";
                    break;
                case 3:
                    cateProduct.Text = "Dịch vụ";
                    break;
                default:
                    cateProduct.Text = "Không xác định";
                    break;
            }
            priceProduct.Text = product.Price.ToString() + "K";
            sizeProduct.Text = product.ProductType.ToString();
        }
    }
}
