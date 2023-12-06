using BUS;
using DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class ctProductManager : UserControl
    {
        ProductServicesBUS servicesBUS = new ProductServicesBUS();
        public ctProductManager()
        {
            InitializeComponent();
            LoadAllData();
        }
        public void LoadAllData()
        {
            mainContainer.Controls.Clear();
            List<Product> products = servicesBUS.GetAllProductBUS();

            foreach (Product product in products)
            {
                ctProductSetting ctProductManager = new ctProductSetting(product.Id);
                mainContainer.Controls.Add(ctProductManager);
            }
        }
        public void FindByName(string name)
        {
            mainContainer.Controls.Clear();
            List<Product> products = servicesBUS.GetAllProductBUS();

            foreach (Product product in products)
            {
                if (product.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    ctProductSetting ctProductManager = new ctProductSetting(product.Id);
                    mainContainer.Controls.Add(ctProductManager);
                }
            }
        }
        public void FindByCategory(int categoryId)
        {
            mainContainer.Controls.Clear();
            List<Product> products = servicesBUS.GetAllProductBUS();

            foreach (Product product in products)
            {
                if (product.CategoryId == categoryId)
                {
                    ctProductSetting ctProductManager = new ctProductSetting(product.Id);
                    mainContainer.Controls.Add(ctProductManager);
                }
            }
        }
        private void PictureBox_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            cateSortTxt.Text = string.Empty;
            searchTxt.Text = string.Empty;
            LoadAllData();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTxt.Text))
            {
                LoadAllData();
            }
            else
            {
                FindByName(searchTxt.Text);
            }
        }

        private void cateSortTxt_TextChanged(object sender, EventArgs e)
        {
            switch (cateSortTxt.SelectedIndex)
            {
                case 0:
                    FindByCategory(1);
                    break;
                case 1:
                    FindByCategory(2);
                    break;
                case 2:
                    FindByCategory(3);
                    break;
                default:
                    LoadAllData();
                    break;
            }
        }

        private void searchTxt_Click(object sender, EventArgs e)
        {
            searchTxt.Text = string.Empty;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            fProductInfo fProductInfo = new fProductInfo(2,1);
            fProductInfo.ShowDialog();
            LoadAllData();

        }
    }
}
