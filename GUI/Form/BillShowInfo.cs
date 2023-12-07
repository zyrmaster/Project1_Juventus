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
    public partial class BillShowInfo : Form
    {
        BillServicesBUS servicesBUS = new BillServicesBUS();
        public BillShowInfo()
        {
            InitializeComponent();
            LoadBill();
        }
        public void LoadBill()
        {
            billFullShow.Controls.Clear();
            List<Bill> bills = new List<Bill>();
            bills = servicesBUS.GetBillListBUS();
            foreach (Bill bill in bills)
            {
                BillCount billCount = new BillCount(bill.Id);
                billFullShow.Controls.Add(billCount);
            }
        }

        private void sortType_TextChanged(object sender, EventArgs e)
        {
            if (sortType.TabIndex == 0)
            {
                LoadBill();
            }
            else if (sortType.TabIndex == 1)
            {
                billFullShow.Controls.Clear();
            }
            else if (sortType.TabIndex == 2)
            {
                billFullShow.Controls.Clear();
            }
            else
            {
                sortType.TabIndex = 0;
            }
        }
    }
}
