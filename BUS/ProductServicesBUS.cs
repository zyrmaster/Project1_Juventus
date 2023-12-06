using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ProductServicesBUS : ProductServices
    {
        ProductServices service = new ProductServices();
        public List<Product> GetAllProductBUS()
        {
            return service.getAllProduct();
        }
        public Product GetProductByIDBUS(int id)
        {
            return service.GetProductByID(id);
        }
        public string GetCateNameBUS(int id)
        {
            return service.GetCateNameByID(id);
        }
        public int GetLastProductIdBUS()
        {
            return service.GetLastProductID();
        }
        public bool AddProduct(Product product)
        {
            return service.AddProduct(product);
        }
        public bool EditProduct(Product product)
        {
            return service.EditProduct(product);
        }
        public bool DeleteProduct(int  id)
        {
            return service.DeleteProduct(id);
        }
    }
}
