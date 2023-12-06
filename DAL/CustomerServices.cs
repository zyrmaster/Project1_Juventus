using DAL.Context;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerServices
    {
        private List<Customer> _lstCustomer;
        private DatabaseContext _dbContext;
        public CustomerServices()
        {
            _lstCustomer = new List<Customer>();
            _dbContext = new DatabaseContext();
        }
        public string GetCustomerName(int id)
        {
            return _dbContext.Customers
                .Where(c => c.Id == id)
                .Select(c => c.CustomerName)
                .FirstOrDefault();
        }
        public Customer GetCustomer(int id)
        {
            return _dbContext.Customers .FirstOrDefault(c => c.Id == id);
        }
        public bool AddCustomer(Customer customerGet)
        {
            var isExits = _dbContext.Customers.Any(c => c.Id != customerGet.Id);
            var isPhoneHave = _dbContext.Customers.Any(c => c.Phone != customerGet.Phone);
            if (!isExits)
            {
                if(!isPhoneHave)
                {
                    _dbContext.Customers.Add(customerGet);
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        public int GetLastCustomer()
        {
            return _dbContext.Customers.OrderBy(c => c.Id).Last().Id;
        }
        public Customer GetCustomerByPhone(string phone)
        {
            return _dbContext.Customers.FirstOrDefault(c => c.Phone == phone);

        }
    }
}
