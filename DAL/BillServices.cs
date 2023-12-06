using DAL.Context;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillServices
    {
        private List<Bill> _lstBills;
        private DatabaseContext _dbContext;
        private List<BillInfo> _lstBillsInfo;
        public BillServices()
        {
            _lstBills = new List<Bill>();
            _dbContext = new DatabaseContext();
            _lstBillsInfo = new List<BillInfo>();
        }
        public Bill LoadBill(int BillId)
        {
            return _dbContext.Bills.FirstOrDefault(c=>c.Id == BillId);
        }
        public List<Bill> GetBillCount()
        {
            return _dbContext.Bills.OrderByDescending(bill => bill.DateIn).Take(20).ToList();
        }
    }
}
