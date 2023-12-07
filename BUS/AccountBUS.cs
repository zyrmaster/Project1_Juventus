using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BUS
{
    public class AccountBUS
    {
        AccountServices accSv = new AccountServices();
        public bool UpdateAccountBUS(Account account)
        {
            return accSv.UpdateAccount(account);
        }
        public bool AccountChecking(string username)
        {
            return accSv.AccountChecking(username);
        }
        public bool AddAccount(Account account)
        {
            return accSv.AddAccount(account);
        }
        public bool AuthAccount(string username,string password) {
            return accSv.AuthAccount(username,password);
        }
        public int getRole(string username)
        {
            return accSv.GetRole(username);
        }
        public Account GetInfoAccountByUsernameBUS(string username)
        {
            return accSv.GetAccountInfoByUserName(username);
        }
        public Employee GetEmployeeById(int accountId)
        {
            return accSv.GetEmployeeById(accountId);
        }
        public string GetRoleName(int roleId)
        {
            return accSv.GetRoleName(roleId);
        }
        public Account GetAccountByIdBUS(int accountId)
        {
            return accSv.GetAccountByID(accountId);
        }
        public bool EditAccountBUS(Account account)
        {
            return accSv.EditAccount(account);
        }
        public List<Account> GetAllAccountBUS()
        {
            return accSv.GetAllAccount();
        }
        public int GetLast()
        {
            return accSv.getLast();
        }
    }
}
