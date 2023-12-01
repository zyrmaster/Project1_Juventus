using BUS;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GUI
{
    public partial class ctTableManager : UserControl
    {
        TableServicesBUS tableBus = new TableServicesBUS();
        int tableId;
        public ctTableManager()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            sortType.Text = "Chọn danh sách bàn";
            LoadTableList();
        }
        public void LoadTableList()
        {
            tableManager.Controls.Clear();
            int allTable = 0;
            int lockTable = 0;
            int openTable = 0;
            List<Table> tables = tableBus.GetAllTableLst();
            foreach (var table in tables)
            {
                allTable++;
                if (table.Status.Equals("0"))
                {
                    openTable++;
                }
                if (table.Status.Equals("2") || table.Status.Equals("1"))
                {
                    lockTable++;
                }
                Button btn = new Button() { Width = tableBus.TableWith, Height = tableBus.TableHeight };
                btn.BackColor = Color.SeaShell;
                btn.Text = "(" + table.Id + ")\n" + table.Name;
                btn.Click += Btn_Click;
                tableManager.Controls.Add(btn);
                tableManager.Controls.Add(addBtn);
            }
            countTable.Text = "Tổng số bàn : " + allTable;
            countOpenTable.Text = "Số bàn trống : " + openTable;
            countTableBusy.Text = "Bàn khác : " + lockTable;
        }
        public void LoadTableListByStatus(string status)
        {
            tableManager.Controls.Clear();
            List<Table> tables = tableBus.GetAllTableLst();
            foreach (var table in tables)
            {
                if (table.Status.Equals(status))
                {
                    Button btn = new Button() { Width = tableBus.TableWith, Height = tableBus.TableHeight };
                    btn.BackColor = Color.SeaShell;
                    btn.Text = "(" + table.Id + ")\n" + table.Name;
                    btn.Click += Btn_Click;
                    tableManager.Controls.Add(btn);
                    tableManager.Controls.Add(addBtn);
                }
            }
        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string pattern = @"\((\d+)\)";
            Match match = Regex.Match(btn.Text, pattern);
            if (match.Success)
            {

                int tableId = Convert.ToInt32(match.Groups[1].Value);
                fTableControl fTableControl = new fTableControl(tableId);
                fTableControl.ShowDialog();
                LoadTableList();
            }

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            LoadTableList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            fAddTable addtb = new fAddTable();
            addtb.ShowDialog();
            LoadTableList();
        }

        private void sortType_TextChanged(object sender, EventArgs e)
        {
            if (sortType.SelectedIndex == 0)
            {
                LoadTableListByStatus("0");
            }
            else if (sortType.SelectedIndex == 1)
            {
                LoadTableListByStatus("1");
            }
            else if (sortType.SelectedIndex == 2)
            {
                LoadTableListByStatus("2");
            }
        }
    }
}
