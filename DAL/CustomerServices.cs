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
            var isExits = _dbContext.Customers.Any(c => c.Id == customerGet.Id);
            if (!isExits)
            {
                Customer customer = new Customer();
                customer.Id = customerGet.Id;
                customer.CustomerName = customerGet.CustomerName;
                customer.Address = customerGet.Address;
                customer.Phone = customerGet.Phone;
                customer.Point = customerGet.Point;
                _dbContext.Customers.Add(customer);
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteCustomer(int id)
        {
            var delete = _dbContext.Customers.FirstOrDefault(c => c.Id == id);
            if (delete !=null)
            {
                _dbContext.Customers.Remove(delete);
               _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool EditCustomer(Customer customer)
        {
            try
            {
                var existingCustomer = _dbContext.Customers.FirstOrDefault(c => c.Id == customer.Id);

                if (existingCustomer != null)
                {
                    existingCustomer.Point = customer.Point;
                    existingCustomer.CustomerName = customer.CustomerName;
                    existingCustomer.Phone = customer.Phone;
                    existingCustomer.Address = customer.Address;
                    _dbContext.SaveChanges();

                    return true;
                }

                return false;
            }
            catch (Exception ex)
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
        public Customer GetCustomerById(int id)
        {
            return _dbContext.Customers.FirstOrDefault(c => c.Id == id);

        }
        public bool CheckPhoneExists(string phone)
        {
            var isPhoneExists = _dbContext.Customers.Any(c => c.Phone == phone);

            // If the phone number exists, return true; otherwise, return false
            return isPhoneExists;
        }
        public int GetCustomerIDByName(string name)
        {
            try
            {
                var customer = _dbContext.Customers.FirstOrDefault(c => c.CustomerName == name);

                if (customer != null)
                {
                    return customer.Id;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
            }
            return 0;
        }
        public List<Customer> GetCustomersLST()
        {
            return _dbContext.Customers.ToList();
        }
    }
}
