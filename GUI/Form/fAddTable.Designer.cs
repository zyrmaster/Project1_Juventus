namespace GUI
{
    partial class fAddTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddTable));
            title_panel = new Panel();
            panel2 = new Panel();
            exitBtn = new PictureBox();
            titleName = new Label();
            menu_pictureBox = new PictureBox();
            panel1 = new Panel();
            numSlotTxt = new ComboBox();
            numSlot = new Label();
            nameTableTxt = new TextBox();
            nameTable = new Label();
            addBtn = new Button();
            title_panel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exitBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menu_pictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // title_panel
            // 
            title_panel.BackColor = SystemColors.ControlLightLight;
            title_panel.Controls.Add(panel2);
            title_panel.Controls.Add(titleName);
            title_panel.Controls.Add(menu_pictureBox);
            title_panel.Dock = DockStyle.Top;
            title_panel.Location = new Point(0, 0);
            title_panel.Name = "title_panel";
            title_panel.Size = new Size(382, 41);
            title_panel.TabIndex = 0;
            title_panel.MouseDown += title_panel_MouseDown_1;
            title_panel.MouseMove += title_panel_MouseMove;
            title_panel.MouseUp += title_panel_MouseUp;
            // 
            // panel2
            // 
            panel2.Controls.Add(exitBtn);
            panel2.Location = new Point(345, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(28, 32);
            panel2.TabIndex = 1;
            // 
            // exitBtn
            // 
            exitBtn.Dock = DockStyle.Fill;
            exitBtn.Image = (Image)resources.GetObject("exitBtn.Image");
            exitBtn.Location = new Point(0, 0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(28, 32);
            exitBtn.SizeMode = PictureBoxSizeMode.Zoom;
            exitBtn.TabIndex = 4;
            exitBtn.TabStop = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // titleName
            // 
            titleName.AutoSize = true;
            titleName.Location = new Point(36, 10);
            titleName.Name = "titleName";
            titleName.Size = new Size(79, 20);
            titleName.TabIndex = 3;
            titleName.Text = "Thêm bàn ";
            // 
            // menu_pictureBox
            // 
            menu_pictureBox.Image = (Image)resources.GetObject("menu_pictureBox.Image");
            menu_pictureBox.Location = new Point(4, 6);
            menu_pictureBox.Name = "menu_pictureBox";
            menu_pictureBox.Size = new Size(26, 26);
            menu_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            menu_pictureBox.TabIndex = 2;
            menu_pictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(numSlotTxt);
            panel1.Controls.Add(numSlot);
            panel1.Controls.Add(nameTableTxt);
            panel1.Controls.Add(nameTable);
            panel1.Location = new Point(4, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 261);
            panel1.TabIndex = 1;
            // 
            // numSlotTxt
            // 
            numSlotTxt.FormattingEnabled = true;
            numSlotTxt.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            numSlotTxt.Location = new Point(17, 172);
            numSlotTxt.Name = "numSlotTxt";
            numSlotTxt.Size = new Size(341, 28);
            numSlotTxt.TabIndex = 3;
            numSlotTxt.Text = "1";
            // 
            // numSlot
            // 
            numSlot.Font = new Font("Bahnschrift Light Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            numSlot.ForeColor = Color.Black;
            numSlot.Image = (Image)resources.GetObject("numSlot.Image");
            numSlot.ImageAlign = ContentAlignment.MiddleLeft;
            numSlot.Location = new Point(17, 113);
            numSlot.Name = "numSlot";
            numSlot.Size = new Size(142, 56);
            numSlot.TabIndex = 2;
            numSlot.Text = "Số người ";
            numSlot.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nameTableTxt
            // 
            nameTableTxt.BorderStyle = BorderStyle.None;
            nameTableTxt.Location = new Point(17, 67);
            nameTableTxt.Name = "nameTableTxt";
            nameTableTxt.Size = new Size(335, 20);
            nameTableTxt.TabIndex = 1;
            // 
            // nameTable
            // 
            nameTable.Font = new Font("Bahnschrift Light Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameTable.ForeColor = Color.Black;
            nameTable.Image = (Image)resources.GetObject("nameTable.Image");
            nameTable.ImageAlign = ContentAlignment.MiddleLeft;
            nameTable.Location = new Point(17, 8);
            nameTable.Name = "nameTable";
            nameTable.Size = new Size(126, 56);
            nameTable.TabIndex = 0;
            nameTable.Text = "Tên bàn";
            nameTable.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.White;
            addBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.Image = (Image)resources.GetObject("addBtn.Image");
            addBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addBtn.Location = new Point(90, 338);
            addBtn.Name = "addBtn";
            addBtn.Padding = new Padding(20, 0, 0, 0);
            addBtn.Size = new Size(195, 49);
            addBtn.TabIndex = 5;
            addBtn.Text = "Thêm mới";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += homeBtn_Click;
            // 
            // fAddTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(382, 423);
            ControlBox = false;
            Controls.Add(addBtn);
            Controls.Add(panel1);
            Controls.Add(title_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fAddTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAddTable";
            title_panel.ResumeLayout(false);
            title_panel.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)exitBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)menu_pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel title_panel;
        private PictureBox menu_pictureBox;
        private Label titleName;
        private Panel panel2;
        private PictureBox exitBtn;
        private Panel panel1;
        private Label nameTable;
        private Label numSlot;
        private TextBox nameTableTxt;
        private ComboBox numSlotTxt;
        private Button addBtn;
    }
}