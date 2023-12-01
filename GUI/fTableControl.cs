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
    public partial class fTableControl : Form
    {
        TableServicesBUS tbbus = new TableServicesBUS();
        private DAL.Models.Table _tableInfo;
        private int _tableId;
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        public fTableControl(int tableId)
        {
            _tableId = tableId;
            _tableInfo = tbbus.GetTableById(tableId);
            InitializeComponent();
            LoadData();
            tableIdTxt.Enabled = true;
            tableNameTxt.Enabled = true;
            slotTableTxt.Enabled = true;
            statusTableTxt.Enabled = true;
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
        private void title_panel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void title_panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void title_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point deltaCursor = new Point(Cursor.Position.X - lastCursor.X, Cursor.Position.Y - lastCursor.Y);
                this.Location = new Point(lastForm.X + deltaCursor.X, lastForm.Y + deltaCursor.Y);
            }
        }

        private void leaveBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (_tableInfo.Status == "0" || _tableInfo.Status == "1")
            {
                ChangeLockBtn.Text = "Khóa bàn";
            }
            else if (_tableInfo.Status == "2")
            {
                ChangeLockBtn.Text = "Mở khóa";
            }
            if (_tableInfo.Status.ToString() == "0")
            {
                tableNameTxt.ReadOnly = false;
                slotTableTxt.ReadOnly = false;
                payBtn.Visible = false;
                saveBtn.Visible = true;
            }
            else if (_tableInfo.Status.ToString() == "1")
            {
                MessageBox.Show("Không thể chỉnh sửa bàn đang có khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DAL.Models.Table table = new DAL.Models.Table();
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

        private void ChangeLockBtn_Click(object sender, EventArgs e)
        {
            string newStatus;
            if (_tableInfo.Status.ToString().Equals("0"))
            {
                DAL.Models.Table table = new DAL.Models.Table();
                table.Id = _tableInfo.Id;
                table.Name = _tableInfo.Name;
                table.Slot = _tableInfo.Slot;
                table.Status = "2";
                if (tbbus.UpdateTableBUS(table))
                {
                    MessageBox.Show("Khóa bàn thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (_tableInfo.Status.ToString().Equals("2"))
            {
                DAL.Models.Table table = new DAL.Models.Table();
                table.Id = _tableInfo.Id;
                table.Status = "0";
                table.Name = _tableInfo.Name;
                table.Slot = _tableInfo.Slot;
                if (tbbus.UpdateTableBUS(table))
                {
                    MessageBox.Show("Mở khóa bàn thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (_tableInfo.Status.ToString().Equals("1"))
            {
                MessageBox.Show("Không thể khóa đối với loại bàn đang trong trạng thái này !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa hoàn thiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (_tableInfo.Status.ToString() == "1")
            {
                MessageBox.Show("Không xóa bàn đang có khách !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa bàn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (tbbus.DeleteByIdBUS(_tableInfo.Id))
                {
                    MessageBox.Show("Xóa bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                LoadData();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
