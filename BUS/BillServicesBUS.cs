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
        public int GetBillInfoLastId() 
        {
            return billServices.GetLastBillInfoId();
        }
        public bool CreateBillBUS(Bill bill)
        {
            return billServices.CreateBill(bill);
        }
        public bool CreateBillInfoBUS(BillInfo billInfo)
        {
            return billServices.CreateBillInfo(billInfo);
        }
        public bool DeleteBillBUS(int id)
        {
            return billServices.DeleteBill(id);
        }
        public Bill GetBillByCustomerIDBUS(int customerID)
        {
            return billServices.GetBillByCustomerID(customerID);
        }
        public List<BillInfo> GetBillInfoBUS(int id)
        {
            return billServices.GetBillInfoByIDBill(id);
        }
        public bool AddProductIntoBillBUS(int BillId,int productId,int quantily)
        {
            return billServices.AddProductIntoBill(BillId, productId, quantily);
        }
        public bool DeleteBillInfoByBillIdBUS(int id)
        {
            return billServices.DeleteBillInfoByBillId(id);
        }
        public bool SetBillStatusBUS(int id,string status)
        {
            return billServices.SetStatusBill(id, status);
        }
        public List<Bill> GetBillListBUS()
        {
            return billServices.GetBillAll();
        }
        public List<Bill> GetBillAllWithDay(int day)
        {
            return billServices.GetBillCountWithDay(day);
        }
    }
}
