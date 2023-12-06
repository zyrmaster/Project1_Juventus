using DAL;
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
    }
}
