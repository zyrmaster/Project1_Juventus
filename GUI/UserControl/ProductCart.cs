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
        public event EventHandler<int> removeClickSender;
        public event EventHandler<(int Quantity, int OtherValue)> ValuesChanged;
        public int CountProduct { get; set; }
        public ProductCart(int ProductId,int quantily)
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
            priceProduct.Text = product.Price.ToString();
            sizeProduct.Text = product.ProductType.ToString();
            countProductSell.Value = quantily;
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            removeClickSender?.Invoke(sender, product.Id);
        }
        public (int Quantity, int ProductID) GetValues()
        {
            int quantity = Convert.ToInt32(countProductSell.Value);
            int ProductID = product.Id;

            return (quantity, ProductID);
        }
        private void countProductSell_ValueChanged(object sender, EventArgs e)
        {
            var values = GetValues();
            OnValuesChanged(values);
        }
        protected virtual void OnValuesChanged((int Quantity, int OtherValue) values)
        {
            ValuesChanged?.Invoke(this, values);
        }
    }
}
