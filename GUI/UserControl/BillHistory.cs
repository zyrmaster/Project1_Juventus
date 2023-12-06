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
    public partial class BillHistory : UserControl
    {
        BillServicesBUS servicesBUS = new BillServicesBUS();
        CustomerBUS customerBUS = new CustomerBUS();
        Bill bill = new Bill();
        public BillHistory(int billId)
        {
            InitializeComponent();
            bill = servicesBUS.GetBill(billId);
            billName.Text = "Hoá đơn số " + bill.Id.ToString();
            if (bill.Status == "Đã thanh toán")
            {
                this.BackColor = Color.Aquamarine;
            }
            else if (bill.Status == "Chưa thanh toán")
            {
                this.BackColor = Color.LightSkyBlue;
            }
            else if (bill.Status == "Hoá đơn lỗi")
            {
                this.BackColor = Color.Magenta;
            }
            tableId.Text = "Bàn " + bill.TableId.ToString();
            customerName.Text = customerBUS.GetCustomerName(bill.CustomerId);
        }

        private void BillHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
