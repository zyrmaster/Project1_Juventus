using BUS;
using DAL;
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
        CustomerBUS customerBUS = new CustomerBUS();
        Employee _employee;
        public ctHome(Employee employee)
        {
            _employee = employee;
            InitializeComponent();
            LoadBill();
        }

        public ctHome()
        {
        }

        private void createBill_Click(object sender, EventArgs e)
        {
            CreateBill createBill = new CreateBill(0, _employee, 0); // tao hoa don moi
            createBill.ShowDialog();
            LoadBill();
        }
        public void LoadBill()
        {
            billControlGroup.Controls.Clear();
            List<Bill> bills = servicesBUS.GetBillList();
            foreach (Bill bill in bills)
            {
                BillHistory billHistory = new BillHistory(bill.Id, _employee);
                billControlGroup.Controls.Add(billHistory);
            }
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            BillShowInfo billShowInfo = new BillShowInfo();
            billShowInfo.ShowDialog();

        }

        private void listCustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerControl customerControl = new CustomerControl();
            customerControl.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void couponBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm quản lý quán Cafe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccountProfile accountProfile = new AccountProfile(_employee);
            accountProfile.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fAccountManager fAccountManager = new fAccountManager();
            fAccountManager.ShowDialog();
        }
    }
}
