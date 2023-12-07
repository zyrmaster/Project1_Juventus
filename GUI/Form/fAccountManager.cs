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
    public partial class fAccountManager : Form
    {
        AccountBUS accountBUS = new AccountBUS();
        EmployerBUS employerBUS = new EmployerBUS();
        public fAccountManager()
        {
            InitializeComponent();
            LoadAllAccount();
        }
        public void LoadAllAccount()
        {
            mainContainer.Controls.Clear();
            List<Employee> employees = new List<Employee>();
            employees = employerBUS.GetEmployersALLBUS();
            foreach (Employee employee in employees)
            {
                ctAccountManager ctAccountManager = new ctAccountManager(employee);
                mainContainer.Controls.Add(ctAccountManager);
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
           fAddAccount fAddAccount = new fAddAccount();
            fAddAccount.ShowDialog();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
