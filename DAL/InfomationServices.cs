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
    public class InfomationServices
    {
        private DatabaseContext _dbContexts;
        private List<Employee> _lstEmployee;
        private List<Role> _lstRoles;
        public InfomationServices()
        {
            _lstEmployee = new List<Employee>();
            _lstRoles = new List<Role>();
        }
        public List<Role> LoadAllRole()
        {
            return _dbContexts.Roles.ToList();
        }
    }
}
