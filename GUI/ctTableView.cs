using DAL.Models;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class ctTableView : UserControl
    {
        TableServicesBUS tbbus = new TableServicesBUS();
        ctTableManager ctTableManager = new ctTableManager();
        private Table _tableInfo;
        private int _tableId;
        public ctTableView(int tableId)
        {
            _tableId = tableId;
            _tableInfo = tbbus.GetTableById(tableId);
            InitializeComponent();
            LoadData();
            if (_tableInfo.Status == "0" || _tableInfo.Status == "1")
            {
                leaveBtn.Text = "Khóa bàn";
            }
            else if (_tableInfo.Status == "2")
            {
                leaveBtn.Text = "Mở khóa";
            }
        }
        private void LoadData()
        {
            titleTabel.Text = "Thông tin " + _tableInfo.Name;
            tableIdTxt.Text = _tableInfo.Id.ToString();
            tableNameTxt.Text = _tableInfo.Name.ToString();
            slotTableTxt.Text = _tableInfo.Slot.ToString();
            if (_tableInfo.Status.ToString() == "0")
            {
                statusTableTxt.Text = "Bàn trống";
            }
            else if (_tableInfo.Status.ToString() == "2")
            {
                statusTableTxt.Text = "Bàn khóa";
            }
            else if (_tableInfo.Status.ToString() == "1")
            {
                statusTableTxt.Text = "Có khách";
            }
        }
        private void leaveBtn_Click(object sender, EventArgs e)
        {
            string newStatus;
            if (_tableInfo.Status.ToString().Equals("0"))
            {
                Table table = new Table();
                table.Id = _tableInfo.Id;
                table.Name = _tableInfo.Name;
                table.Slot = _tableInfo.Slot;
                table.Status = "2";
                if (tbbus.UpdateTableBUS(table))
                {
                    ctTableManager.Controls.Clear();
                    ctTableManager.LoadTableList();
                    MessageBox.Show("Khóa bàn thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (_tableInfo.Status.ToString().Equals("2"))
            {
                Table table = new Table();
                table.Id = _tableInfo.Id;
                table.Status = "0";
                table.Name = _tableInfo.Name;
                table.Slot = _tableInfo.Slot;
                if (tbbus.UpdateTableBUS(table))
                {
                    ctTableManager.LoadTableList();
                    MessageBox.Show("Mở khóa bàn thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (_tableInfo.Status.ToString().Equals("1"))
            {
                ctTableManager.LoadTableList();
                MessageBox.Show("Không thể khóa đối với loại bàn đang trong trạng thái này !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (_tableInfo.Status.ToString() == "0")
            {
                tableNameTxt.ReadOnly = false;
                slotTableTxt.ReadOnly = false;
                payBtn.Visible = false;
                saveBtn.Visible = true;
            }
            else if (_tableInfo.Status.ToString() == "2")
            {
                MessageBox.Show("Mở khóa bàn trước khi chỉnh sửa !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (_tableInfo.Status.ToString() == "1")
            {
                MessageBox.Show("Không thể chỉnh sửa bàn đang có khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.Id = Convert.ToInt32(tableIdTxt.Text);
            table.Name = tableNameTxt.Text;
            table.Slot = Convert.ToInt32(slotTableTxt.Text);
            table.Status = _tableInfo.Status;
            if (tbbus.UpdateTableBUS(table))
            {
                tableNameTxt.ReadOnly = true;
                slotTableTxt.ReadOnly = true;
                MessageBox.Show("Cập nhật thông tin bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
