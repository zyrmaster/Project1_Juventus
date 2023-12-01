using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AccountServices
    {
        private List<Account> _lstAccount;
        private DatabaseContext _dbContext;
        private List<Role> _lstRole;
        private List<Employee> _lstEmployee;
        public AccountServices()
        {
            _lstAccount = new List<Account>();
            _dbContext = new DatabaseContext();
            _lstRole = new List<Role>();
            _lstEmployee = new List<Employee>();
        }
        public string AddAccount(Account acc)
        {
            _dbContext.Accounts.Add(acc);
            _dbContext.SaveChanges();
            return "Thêm thành công !";
        }
        public bool UpdateAccount(Account acc)
        {
            try
            {
                var existingAccount = _dbContext.Accounts.FirstOrDefault(c => c.Id == acc.Id);
                if (existingAccount != null)
                {
                    existingAccount.Username = acc.Username;
                    existingAccount.DisplayName = acc.DisplayName;
                    existingAccount.Password = acc.Password;
                    existingAccount.RoleId = acc.RoleId;
                    _dbContext.SaveChanges();
                    return true;
                }
                else { return false; }
            }
            catch(DbUpdateConcurrencyException ex)
            {
                foreach (var entry in ex.Entries)
                {
                    if (entry.Entity is Account)
                    {
                        var databaseValues = entry.GetDatabaseValues();
                        var updatedValues = entry.CurrentValues;
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                return false;
            }
            return false;
        }
        public string DeleteAccount(int id)
        {
            var acc = _dbContext.Accounts.FirstOrDefault(c => c.Id == id);
            _dbContext.SaveChanges();
            return "Xóa thành công !";
        }
        public bool AccountChecking(string username)
        {
            if(_dbContext.Accounts.Any(c => c.Username == username))
            {
                return true;
            }
            else { return false; }
        }
        public bool AuthAccount(string username,string password)
        {
            if(_dbContext.Accounts.Any(c=>c.Username== username && c.Password == password))
            {
                return true;
            }else { return false; }
        }
        public int GetRole(string username)
        {
            int role = (int)_dbContext.Accounts.Where(c => c.Username == username).Select(c => c.RoleId).FirstOrDefault();
            return role;
        }
        public string GetRoleName(int roleId)
        {
            string name = _dbContext.Roles.Where(c=>c.Id==roleId).Select(c=>c.RoleName).FirstOrDefault();
            return name;
        }
        public Account GetAccountInfoByUserName(string username)
        {
            return _dbContext.Accounts.FirstOrDefault(c => c.Username == username );
        }
        public Employee GetEmployeeById(int accountId)
        {
            return _dbContext.Employees.FirstOrDefault(c=>c.Id == accountId);
            
        }
    }
}
