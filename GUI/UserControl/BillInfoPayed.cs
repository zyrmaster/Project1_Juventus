using BUS;
using DAL;
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
    public partial class BillInfoPayed : UserControl
    {
        ProductServicesBUS productServices = new ProductServicesBUS();
        public BillInfoPayed(int productID, int quantily)
        {
            Product product = productServices.GetProductByID(productID);
            InitializeComponent();
            nameProduct.Text = product.Name;
            price.Text = $"{product.Price}";
            countQuantily.Text = quantily.ToString();
            totalPrice.Text = $"{quantily * product.Price}";
        }
    }
}
