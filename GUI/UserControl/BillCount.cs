using BUS;
using DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class BillCount : UserControl
    {
        BillServicesBUS servicesBUS = new BillServicesBUS();
        CustomerBUS customerBUS = new CustomerBUS();
        BillServicesBUS billServicesBUS = new BillServicesBUS();
        Bill _bill = new Bill();
        public BillCount(int BillId)
        {
            InitializeComponent();
            _bill = billServicesBUS.GetBill(BillId);
            if (_bill.Status == "0")
            {
                this.BackColor = Color.GhostWhite;
            }
            else if (_bill.Status == "1")
            {
                this.BackColor = Color.Lavender;
            }
            else
            {
                this.BackColor = Color.Gray;
            }
            nameBill.Text = $"{_bill.Id}";
            if (_bill.TableId == 9999)
            {
                tableId.Text = "Đơn mang đi";
            }
            else
            {
                tableId.Text = $"{_bill.TableId}";
            }
            priceTotal.Text = $"{_bill.PriceTotal}";
            dateTime.Text = $"{_bill.DateIn}";
            customer.Text = customerBUS.GetCustomerName(_bill.CustomerId);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xoá hoá đơn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (billServicesBUS.DeleteBillBUS(_bill.Id))
                {
                    Parent.Controls.Remove(this);
                    MessageBox.Show("Xoá hoá đơn thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            BillShow billShow = new BillShow(_bill);
            billShow.ShowDialog();
        }
    }
}
