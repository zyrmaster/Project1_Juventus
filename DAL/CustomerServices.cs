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
    }
}
