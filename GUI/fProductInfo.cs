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
    public partial class fProductInfo : Form
    {
        Product _product = new Product();
        ProductServices ServiceBUS = new ProductServices();
        Boolean isChange = false;
        public fProductInfo(int type, int productId)
        {
            _product = ServiceBUS.GetProductByID(productId);
            InitializeComponent();
            nonSize.Checked = true;
            switch (type)
            {
                case 1:
                    changeBtn.Visible = true;
                    deleteBtn.Visible = true;
                    ShowProduct();
                    break;
                case 2:
                    addBtn.Visible = true;
                    exitBtn.Visible = true;
                    AddProduct();
                    break;
            }
        }
        public void Savecheck()
        {
            if (haveSize.Checked)
            {
                nonSize.Checked = false;
                sizeProductTxt.Enabled = true;
            }
            if (nonSize.Checked)
            {
                haveSize.Checked = false;
                sizeProductTxt.Enabled = false;
            }
            if (!isChange)
            {
                idProductTxt.Enabled = false;
                nameProductTxt.Enabled = false;
            }
        }
        public void ShowProduct()
        {
            idProductTxt.Text = _product.Id.ToString();
            nameProductTxt.Text = _product.Name;
            switch (_product.CategoryId)
            {
                case 1:
                    cateProductTxt.TabIndex = 1;
                    break;
                case 2:
                    cateProductTxt.TabIndex = 2;
                    break;
                case 3:
                    cateProductTxt.TabIndex = 3;
                    break;
            }
            string cateName = ServiceBUS.GetCateNameByID(_product.CategoryId);
            cateProductTxt.Text = cateName.ToString();
            switch (_product.ProductType)
            {
                case "S":
                    haveSize.Checked = true;
                    sizeProductTxt.SelectedIndex = 0;
                    break;
                case "M":
                    haveSize.Checked = true;
                    sizeProductTxt.SelectedIndex = 1;
                    break;
                case "L":
                    haveSize.Checked = true;
                    sizeProductTxt.SelectedIndex = 2;
                    break;
                case "NULL":
                    {
                        nonSize.Checked = true;
                        sizeProductTxt.SelectedIndex = 3;
                    }
                    break;
                default:
                    {
                        nonSize.Checked = true;
                    }
                    break;
            }
            noteProductTxt.Text = "Note";
            priceProductTxt.Text = _product.Price.ToString();
        }
        public void AddProduct()
        {
            idProductTxt.Text = ServiceBUS.GetLastProductID().ToString();
        }

        private void nonSize_CheckedChanged(object sender, EventArgs e)
        {
            Savecheck();
        }
        private void haveSize_CheckedChanged(object sender, EventArgs e)
        {
            Savecheck();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
