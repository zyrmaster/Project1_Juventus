using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerBUS
    {
        CustomerServices customerServices = new CustomerServices();
        public string GetCustomerName(int id)
        {
            return customerServices.GetCustomerName(id);
        }
        public int GetLastCustomerID()
        {
            return customerServices.GetLastCustomer();
        }
        public bool AddCustomerBUS(Customer customer)
        {
            return customerServices.AddCustomer(customer);
        }
        public Customer GetCustomerByPhone(string phone)
        {
            return customerServices.GetCustomerByPhone(phone);
        }
        public bool CheckPhoneExits(string phone)
        {
            return customerServices.CheckPhoneExists(phone);
        }
        public int GetCustomerIDByName(string name)
        {
            return customerServices.GetCustomerIDByName(name);
        }
        public Customer GetCustomerById(int id)
        {
            return customerServices.GetCustomerById(id);
        }
        public List<Customer> GetAll()
        {
            return customerServices.GetCustomersLST();
        }
        public bool DeleteCustomerById(int id)
        {
            return customerServices.DeleteCustomer(id);
        }
        public bool EditCustomerBUS(Customer customer)
        {
            return customerServices.EditCustomer(customer);
        }
    }
}
