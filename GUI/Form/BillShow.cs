using BUS;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class BillShow : Form
    {
        BillServicesBUS servicesBillBUS = new BillServicesBUS();
        Bill _bill = new Bill();
        BillInfo billInfo = new BillInfo();
        ProductWithQuantity ProductWithQuantity = new ProductWithQuantity();
        ProductServicesBUS productServices = new ProductServicesBUS();
        public BillShow(Bill bill)
        {
            InitializeComponent();
            _bill = bill;
            idBill.Text = $"Mã hoá đơn{_bill.Id} ";
            dateTime.Text = $"Ngày : {_bill.DateOut}";
            totalMoney.Text = $"Tổng tiền : {_bill.PriceTotal}";
            if (_bill.TableId == 9999)
            {
                tableNum.Text = $"Bàn : Mang đi";
            }
            else
            {
                tableNum.Text = $"Bàn :{_bill.TableId}";
            }
            if (_bill.Status == "1")
            {
                status.Text = "Trạng thái : Đã thanh toán";
            }
            else if (_bill.Status == "2")
            {
                status.Text = "Trạng thái : Chưa thanh toán";
            }
            else
            {
                status.Text = "Trạng thái : Hoá đơn khác";
            }
            GetAllProduct();
        }
        public void GetAllProduct()
        {
            productShow.Controls.Clear();
            List<BillInfo> billInfos = servicesBillBUS.GetBillInfoBUS(_bill.Id);

            foreach (var billInfo in billInfos)
            {

                if (billInfo.ProductId != null)
                {
                    BillInfoPayed billInfoPayed = new BillInfoPayed(billInfo.ProductId, billInfo.CountValue);
                    productShow.Controls.Add(billInfoPayed);
                }
                else
                {
                    // Xử lý khi không tìm thấy Product
                    MessageBox.Show($"Không tìm thấy sản phẩm với ID {billInfo.ProductId}");
                }
            }
        }

    }
}
