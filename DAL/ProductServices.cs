using DAL.Context;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductServices
    {
        private DatabaseContext _dbContext;
        private List<Product> _products;
        private List<ProductCategory> _categories;
        Product product = new Product();
        ProductCategory category = new ProductCategory();
        public ProductServices()
        {
            _dbContext = new DatabaseContext();
            _products = new List<Product>();
        }
        public List<Product> getAllProduct()
        {
           return _dbContext.Products.ToList();
        }
        public Product GetProductByID(int id)
        {
            return _dbContext.Products.FirstOrDefault(c => c.Id == id);
        }
        public string GetCateNameByID(int id)
        {
            var categoryName = _dbContext.ProductCategories
                .Where(c => c.Id == id)
                .Select(c => c.Name)
                .FirstOrDefault();

            return categoryName ?? "Category not found";
        }
        public int GetLastProductID()
        {
            return _dbContext.Products.OrderBy(c => c.Id).Last().Id;
        }
        public bool AddProduct(Product product)
        {
            var isProduct = _dbContext.Products.Any(c => c.Id == product.Id);
            if(!isProduct)
            {
                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();
                return true;
            }
            else return false;
        }
        public bool EditProduct(Product product) 
        {
            var isProduct = _dbContext.Products.FirstOrDefault(c => c.Id == product.Id);
            if (isProduct != null)
            {
                isProduct.Name = product.Name;
                isProduct.Price = product.Price;
                isProduct.CategoryId = product.CategoryId;
                isProduct.ProductType = product.ProductType;
                _dbContext.SaveChanges();
                return true;
            }
            else return false;
        }
        public bool DeleteProduct(int id)
        {
            var isExits = _dbContext.Products.FirstOrDefault(c=>c.Id == id);
            if (isExits != null)
            {
                _dbContext.Products.Where(c => c.Id == id).ExecuteDelete();
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
