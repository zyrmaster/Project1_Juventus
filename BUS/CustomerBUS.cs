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
    }
}
