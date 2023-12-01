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
    public partial class ctProductSetting : UserControl
    {
        ProductServicesBUS servicesBUS = new ProductServicesBUS();
        Product product = new Product();
        int ProductSet;
        public ctProductSetting(int ProductId)
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.None;
            this.Dock = DockStyle.None;
            product = servicesBUS.GetProductByIDBUS(ProductId);
            nameProduct.Text = product.Name;
            switch (product.CategoryId)
            {
                case 1:
                    cateSort.Text = "Danh mục : Đồ uống";
                    break;
                case 2:
                    cateSort.Text = "Danh mục : Đồ ăn";
                    break;
                case 3:
                    cateSort.Text = "Danh mục : Dịch vụ";
                    break;
                default:
                    cateSort.Text = "Danh mục : Không xác định";
                    break;
            }
        }

        private void profileProduct_Click(object sender, EventArgs e)
        {
            ShowProductChange(product.Id);
        }

        private void ctProductSetting_Click(object sender, EventArgs e)
        {
            ShowProductChange(product.Id);
        }
        public void ShowProductChange(int productId)
        {
            fProductInfo fProductInfo = new fProductInfo(1, productId);
            fProductInfo.ShowDialog();
        }
    }
}
