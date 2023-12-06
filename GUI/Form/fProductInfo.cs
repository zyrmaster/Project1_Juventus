using BUS;
using DAL;
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
    public partial class fProductInfo : Form
    {
        Product _product = new Product();
        ProductServicesBUS ServiceBUS = new ProductServicesBUS();
        ctProductManager ctProductManager = new ctProductManager();
        Boolean isChange = false;
        public fProductInfo(int type, int productId)
        {
            InitializeComponent();
            _product = ServiceBUS.GetProductByID(productId);
            switch (type)
            {
                case 1:
                    titleProduct.Text = "Chỉnh sửa sản phẩm";
                    saveBtn.Visible = true;
                    deleteBtn.Visible = true;
                    ShowProduct();
                    break;
                case 2:
                    titleProduct.Text = "Thêm sản phẩm";
                    addBtn.Visible = true;
                    exitBtn.Visible = true;
                    AddProduct();
                    break;
            }
        }
        public void Savecheck()
        {
        }
        public void ShowProduct()
        {
            idProductTxt.Text = _product.Id.ToString();
            nameProductTxt.Text = _product.Name;
            switch (_product.CategoryId)
            {
                case 1:
                    cateProductTxt.SelectedIndex = 0;
                    break;
                case 2:
                    cateProductTxt.SelectedIndex = 1;
                    break;
                case 3:
                    cateProductTxt.SelectedIndex = 2;
                    break;
                case 0:
                    cateProductTxt.SelectedIndex = 3;
                    break;
            }
            string cateName = ServiceBUS.GetCateNameByID(_product.CategoryId);
            cateProductTxt.Text = cateName.ToString();
            switch (_product.ProductType)
            {
                case "S":
                    sizeProductTxt.SelectedIndex = 0;
                    break;
                case "M":
                    sizeProductTxt.SelectedIndex = 1;
                    break;
                case "L":
                    sizeProductTxt.SelectedIndex = 2;
                    break;
                case "NO":
                    {
                        sizeProductTxt.SelectedIndex = 3;
                    }
                    break;
                default:
                    {
                        sizeProductTxt.SelectedIndex = 3;
                    }
                    break;
            }
            priceProductTxt.Text = _product.Price.ToString();
        }
        public void AddProduct()
        {
            idProductTxt.Text = (ServiceBUS.GetLastProductID() + 1).ToString();
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
            if (!CheckEmpty())
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Product product = GetProduct();
            if (ServiceBUS.AddProduct(product))
            {
                MessageBox.Show("Thêm sản phẩm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!CheckEmpty())
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Product product = GetProduct();
            if (ServiceBUS.EditProduct(product))
            {
                MessageBox.Show("Sửa sản phẩm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                ctProductManager.LoadAllData();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Product GetProduct()
        {
            Product product = new Product();
            product.Id = Convert.ToInt32(idProductTxt.Text);
            product.Name = nameProductTxt.Text;
            product.Price = Convert.ToInt32(priceProductTxt.Value);
            switch (cateProductTxt.SelectedIndex)
            {
                case 0:
                    product.CategoryId = 1;
                    break;
                case 1:
                    product.CategoryId = 2;
                    break;
                case 2:
                    product.CategoryId = 3;
                    break;
            }
            product.ProductType = GetTypeProduct();
            return product;
        }
        public string GetTypeProduct()
        {
            switch (sizeProductTxt.SelectedIndex)
            {
                case 0:
                    return "S";
                    break;
                case 1:
                    return "M";
                    break;
                case 2:
                    return "L";
                    break;
                case 3:
                    return "X";
                    break;
            }
            return "0";
        }
        public bool CheckEmpty()
        {
            if (idProductTxt.Text.IsNullOrEmpty() ||
                nameProductTxt.Text.IsNullOrEmpty() ||
                priceProductTxt.Value == 0 ||
                cateProduct.Text == "Chọn loại" ||
                sizeProductTxt.Text == "Size")
            {
                return false;
            }
            return true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xoá sản phẩm này ?","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialogResult== DialogResult.Yes)
            {
                if (ServiceBUS.DeleteProduct(Convert.ToInt32(idProductTxt.Text)))
                {
                    MessageBox.Show("Xoá sản phẩm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

        }
    }
}