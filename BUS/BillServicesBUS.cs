using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BillServicesBUS
    {
        BillServices billServices = new BillServices();
        public Bill GetBill(int billId)
        {
            return billServices.LoadBill(billId);
        }
        public List<Bill> GetBillList()
        {
            return billServices.GetBillCount();
        }
        public int GetLastIDBill()
        {
            return billServices.GetLastIdBill();
        }
    }
}
