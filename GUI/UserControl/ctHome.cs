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
    public partial class ctHome : UserControl
    {
        BillServicesBUS servicesBUS = new BillServicesBUS();
        public ctHome()
        {
            InitializeComponent();
            LoadBill();
        }

        private void createBill_Click(object sender, EventArgs e)
        {
            CreateBill createBill = new CreateBill(0);
            createBill.ShowDialog();
        }
        public void LoadBill()
        {
            List<Bill> bills = servicesBUS.GetBillList();
            foreach(Bill bill in bills)
            {
                BillHistory billHistory = new BillHistory(bill.Id);
                billControlGroup.Controls.Add(billHistory);
            }
        }
    }
}
