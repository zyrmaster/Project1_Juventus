using DAL.Context;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
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
            DateTime today = DateTime.Today;

            return _dbContext.Bills
                .Where(bill => bill.DateIn.Date == today)
                .OrderByDescending(bill => bill.DateIn)
                .ToList();
        }
        public List<Bill> GetBillCountWithDay(int daysAgo)
        {
            DateTime startDate = DateTime.Today.AddDays(-daysAgo);

            return _dbContext.Bills
                .Where(bill => bill.DateIn.Date >= startDate && bill.DateIn.Date < DateTime.Today)
                .OrderByDescending(bill => bill.DateIn)
                .ToList();
        }
        public List<Bill> GetBillAll()
        {
            return _dbContext.Bills.OrderBy(bill => bill.Id).ToList();
        }
        public int GetLastIdBill()
        {
            return _dbContext.Bills.OrderBy(c=>c.Id).Last().Id;
        }
        public bool CreateBill(Bill bill)
        {
            var existingBill = _dbContext.Bills.FirstOrDefault(c => c.Id == bill.Id);

            if (existingBill == null)
            {
                Bill newBill = new Bill
                {
                    Id = bill.Id,
                    DateIn = DateTime.Now,
                    DateOut = DateTime.Now,
                    Status = bill.Status,
                    PriceTotal = bill.PriceTotal,
                    TableId = bill.TableId,
                    EmployeeId = bill.EmployeeId,
                    CustomerId = bill.CustomerId
                };

                _dbContext.Bills.Add(newBill);
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CreateBillInfo(BillInfo billInfo)
        {
            var infoExists = _dbContext.BillInfos.FirstOrDefault(c => c.Id == billInfo.Id);

            if (infoExists == null)
            {
                // Create a new BillInfo only if it doesn't exist
                BillInfo newBillInfo = new BillInfo
                {
                    Id = GetLastBillInfoId() + 1,
                    BillId = billInfo.Id,
                    ProductId = billInfo.ProductId,
                    CountValue = billInfo.CountValue
                };

                _dbContext.BillInfos.Add(newBillInfo);
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetLastBillInfoId()
        {
            var lastBillInfoId = _dbContext.BillInfos.Max(c => (int?)c.Id) ?? 0;
            return lastBillInfoId;
        }
        public bool DeleteBill(int billid)
        {
            try
            {
                var billToDelete = _dbContext.Bills.FirstOrDefault(c => c.Id == billid);

                if (billToDelete != null)
                {
                    _dbContext.Bills.Remove(billToDelete);
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
                Console.WriteLine($"Error deleting Bill: {ex.Message}");
                return false;
            }
        }
        public Bill GetBillByCustomerID(int customerID)
        {
            return _dbContext.Bills.FirstOrDefault(c => c.CustomerId==customerID);
        }
        public List<BillInfo> GetBillInfoByIDBill(int id)
        {
            var billInfos = _dbContext.BillInfos
                .Where(bi => bi.BillId == id)
                .ToList();

            return billInfos;
        }
        public bool AddProductIntoBill(int BillId, int productId, int quantily)
        {
            try
            {
                BillInfo billInfo = new BillInfo
                {
                    Id = _dbContext.BillInfos.Max(c => c.Id) + 1,
                    BillId = BillId,
                    ProductId = productId,
                    CountValue = quantily
                };

                _dbContext.BillInfos.Add(billInfo);
                _dbContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeleteBillInfoByBillId(int billId)
        {
            try
            {
                List<BillInfo> billInfosToDelete = _dbContext.BillInfos.Where(bi => bi.BillId == billId).ToList();
                _dbContext.BillInfos.RemoveRange(billInfosToDelete);
                _dbContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool SetStatusBill(int billId, string status)
        {
            try
            {
                var bill = _dbContext.Bills.FirstOrDefault(b => b.Id == billId);

                if (bill != null)
                {
                    bill.Status = status;
                    _dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) { 
                return false;
            }
        }


    }
}
