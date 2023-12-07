using DAL.Context;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployerServices
    {
        private Employee _employee;
        private DatabaseContext _dbContext;
        public EmployerServices()
        {
            _employee = new Employee();
            _dbContext = new DatabaseContext();
        }
        public Employee GetEmployeeById(int Id)
        {
            return _dbContext.Employees.Where(c=>c.Id == Id).FirstOrDefault();
        }
        public string GetEmployeeName(int Id)
        {
            return _dbContext.Employees.Where(c => c.Id == Id).Select(c => c.EmployeeName).FirstOrDefault();
        }
        public Employee GetEmployeeByAccountId(int Id)
        {
            return _dbContext.Employees.FirstOrDefault(c => c.AccountId == Id);
        }
        public List<Employee> GetEmployeesALL()
        {
            return _dbContext.Employees.ToList();
        }
        public int GetLast()
        {
            return _dbContext.Employees.OrderBy(c => c.Id).Last().Id;
        }
    }
}
