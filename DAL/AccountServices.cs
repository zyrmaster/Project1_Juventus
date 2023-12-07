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
        public bool AddAccount(Account acc)
        {
            try
            {
                var isExits = _dbContext.Accounts.FirstOrDefault(c=>c.Id == acc.Id);
                if (isExits != null)
                {
                    Account newAccount = new Account();
                    newAccount.Id = acc.Id;
                    newAccount.Username = acc.Username;
                    newAccount.Password = acc.Password;
                    newAccount.RoleId = acc.RoleId;
                    newAccount.DisplayName = acc.DisplayName;
                    _dbContext.Accounts.Add(newAccount);
                    _dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
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
        public List<Account> GetAllAccount()
        {
            return _dbContext.Accounts.ToList();
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
        public bool EditAccount(Account account)
        {
            var isExits = _dbContext.Accounts.FirstOrDefault(c=>c.Id== account.Id);
            if (isExits != null)
            {
                isExits.Id = isExits.Id;
                isExits.DisplayName = account.DisplayName;
                isExits.Username = account.Username;
                isExits.Password = account.Password;
                isExits.RoleId = account.RoleId;
                _dbContext.SaveChanges();
                return true;

            }
            return false;
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
        public Account GetAccountByID(int accountId)
        {
            return _dbContext.Accounts.FirstOrDefault(c => c.Id == accountId);
        }
        public int getLast()
        {
            return _dbContext.Accounts.OrderBy(c => c.Id).Last().Id;
        }
    }
}
