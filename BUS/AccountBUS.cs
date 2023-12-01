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
    }
}
