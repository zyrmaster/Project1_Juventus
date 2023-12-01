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
using System.Threading;

namespace GUI
{
    public partial class fTableManager : Form
    {
        private readonly Account _accountInfo;
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        ctTableManager tableControl = new ctTableManager();
        ctProductManager productManager = new ctProductManager();
        ctHome ctHome = new ctHome();
        ctStatic ctStatic = new ctStatic();
        ctInfomation ctInfomation = new ctInfomation();
        public fTableManager(Account accountInfo)
        {
            InitializeComponent();
            _accountInfo = accountInfo;
            mainContainer.Controls.Clear();
            mainContainer.Controls.Add(ctHome);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void title_panel_MouseDown(object sender, MouseEventArgs e)
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi chương trình ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void trangChuBtn_Click(object sender, EventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_pictureBox_MouseHover(object sender, EventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            mainContainer.Controls.Clear();
            mainContainer.Controls.Add(ctHome);
        }

        private void managerBtn_Click(object sender, EventArgs e)
        {
            mainContainer.Controls.Clear();
            mainContainer.Controls.Add(tableControl);
        }

        private void title_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            mainContainer.Controls.Clear();
            mainContainer.Controls.Add(productManager);
        }

        private void infomationBtn_Click(object sender, EventArgs e)
        {
            mainContainer.Controls.Clear();
            mainContainer.Controls.Add(ctInfomation);
        }

        private void staticBtn_Click(object sender, EventArgs e)
        {
            mainContainer.Controls.Clear();
            mainContainer.Controls.Add(ctStatic);
        }
    }
}
