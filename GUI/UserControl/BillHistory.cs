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
        Employee _employee = new Employee();
        public BillHistory(int billId,Employee employee)
        {
            _employee = employee;
            InitializeComponent();
            bill = servicesBUS.GetBill(billId);
            billName.Text = "ID Bill : " + bill.Id.ToString();
            if (bill.Status == "0")
            {
                this.BackColor = Color.Aquamarine;
            }
            else if (bill.Status == "1")
            {
                this.BackColor = Color.LightSkyBlue;
            }
            else if (bill.Status == "2")
            {
                this.BackColor = Color.Magenta;
            }
            if (bill.TableId == 9999)
            {
                tableId.Text = "Mang đi";
            }
            else
            {
                tableId.Text = "Bàn " + bill.TableId.ToString();
            }
            
            customerName.Text = customerBUS.GetCustomerName(bill.CustomerId);
        }

        private void BillHistory_Load(object sender, EventArgs e)
        {

        }

        private void BillHistory_Click(object sender, EventArgs e)
        {
            if(bill.Status == "0")
            {
                
                CreateBill createBill = new CreateBill(1,_employee,bill.Id); // mo hoa don cu
                createBill.ShowDialog();
            }
            else if(bill.Status == "1")
            {
                BillShow billShow = new BillShow(bill);
                billShow.ShowDialog();
            }
        }
    }
}
