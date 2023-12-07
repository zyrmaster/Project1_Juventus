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
    public partial class ctAccountManager : UserControl
    {
        EmployerBUS employeeBUS = new EmployerBUS();
        Employee _employee;
        public ctAccountManager(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            accountID.Text = _employee.Id.ToString();
            employerName.Text = _employee.EmployeeName.ToString();
            employerPotision.Text = _employee.Potision.ToString();
            accountIDCount.Text = _employee.AccountId.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
