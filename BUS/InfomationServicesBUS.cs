using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BUS
{
    public class InfomationServicesBUS
    {
        InfomationServices infoSv = new InfomationServices();
        List<Role> _lstRoles = new List<Role>();
        public List<Role> GetRoleList()
        {
            return infoSv.LoadAllRole();
        }
    }
}
