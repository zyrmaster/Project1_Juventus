using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BUS
{
    
    public class EmployerBUS
    {
        EmployerServices employerServices = new EmployerServices();
        public Employee GetEmployeeByID(int id)
        {
            return employerServices.GetEmployeeById(id);
        }
        public string GetEmployeeName(int id) {
            return employerServices.GetEmployeeName(id);
        }
        public Employee GetEmployeeByAccountId(int id)
        {
            return employerServices.GetEmployeeByAccountId(id);
        }
        public List<Employee> GetEmployersALLBUS() 
        {
            return employerServices.GetEmployeesALL();
        }
        public int GetLastEmployee()
        {
            return employerServices.GetLast();
        }
    }
}
