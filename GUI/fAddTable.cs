using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL.Models;

namespace GUI
{
    public partial class fAddTable : Form
    {
        TableServicesBUS tbsvb = new TableServicesBUS();
        ctTableManager ctTableManager = new ctTableManager();
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        private Table tableInfo;
        public fAddTable()
        {
            InitializeComponent();
            nameTableTxt.Text = "Bàn  " + Convert.ToString(tbsvb.GetLastTableIdBUS() + 1);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.Id = tbsvb.GetLastTableIdBUS() + 1;
            table.Name = nameTableTxt.Text;
            table.Slot = Convert.ToInt32(numSlotTxt.Text);
            table.Status = "1";
            if (tbsvb.AddTableBUS(table))
            {
                MessageBox.Show("Thêm bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nameTableTxt.Text = "Bàn  " + Convert.ToString(tbsvb.GetLastTableIdBUS() + 1);
                numSlotTxt.Text = "1";

            }

        }

        private void title_panel_MouseDown_1(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void title_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point deltaCursor = new Point(Cursor.Position.X - lastCursor.X, Cursor.Position.Y - lastCursor.Y);
                this.Location = new Point(lastForm.X + deltaCursor.X, lastForm.Y + deltaCursor.Y);
            }
        }

        private void title_panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}
