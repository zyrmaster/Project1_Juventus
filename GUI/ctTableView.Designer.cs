namespace GUI
{
    partial class ctTableView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctTableView));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            statusTableTxt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            statusTable = new Label();
            slotTable = new Label();
            nameTable = new Label();
            idTable = new Label();
            titleTabel = new Label();
            slotTableTxt = new TextBox();
            tableNameTxt = new TextBox();
            tableIdTxt = new TextBox();
            saveBtn = new Button();
            payBtn = new Button();
            panel3 = new Panel();
            label1 = new Label();
            payLabel = new Label();
            panel2 = new Panel();
            leaveBtn = new Button();
            deleteBtn = new Button();
            changeBtn = new Button();
            infoBtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(685, 537);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(statusTableTxt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(statusTable);
            panel1.Controls.Add(slotTable);
            panel1.Controls.Add(nameTable);
            panel1.Controls.Add(idTable);
            panel1.Controls.Add(titleTabel);
            panel1.Controls.Add(slotTableTxt);
            panel1.Controls.Add(tableNameTxt);
            panel1.Controls.Add(tableIdTxt);
            panel1.Controls.Add(saveBtn);
            panel1.Controls.Add(payBtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 528);
            panel1.TabIndex = 0;
            // 
            // statusTableTxt
            // 
            statusTableTxt.BorderStyle = BorderStyle.None;
            statusTableTxt.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusTableTxt.Location = new Point(65, 298);
            statusTableTxt.Name = "statusTableTxt";
            statusTableTxt.ReadOnly = true;
            statusTableTxt.Size = new Size(209, 25);
            statusTableTxt.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(19, 298);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 18;
            label5.Text = "         ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(17, 233);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 17;
            label4.Text = "         ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(20, 168);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 16;
            label3.Text = "         ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(18, 102);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 15;
            label2.Text = "         ";
            // 
            // statusTable
            // 
            statusTable.AutoSize = true;
            statusTable.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusTable.ForeColor = Color.FromArgb(0, 0, 192);
            statusTable.Location = new Point(24, 264);
            statusTable.Name = "statusTable";
            statusTable.Size = new Size(75, 24);
            statusTable.TabIndex = 14;
            statusTable.Text = "Trạng thái";
            // 
            // slotTable
            // 
            slotTable.AutoSize = true;
            slotTable.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            slotTable.ForeColor = Color.FromArgb(0, 0, 192);
            slotTable.Location = new Point(24, 199);
            slotTable.Name = "slotTable";
            slotTable.Size = new Size(55, 24);
            slotTable.TabIndex = 13;
            slotTable.Text = "Số chỗ";
            // 
            // nameTable
            // 
            nameTable.AutoSize = true;
            nameTable.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTable.ForeColor = Color.FromArgb(0, 0, 192);
            nameTable.Location = new Point(24, 134);
            nameTable.Name = "nameTable";
            nameTable.Size = new Size(60, 24);
            nameTable.TabIndex = 12;
            nameTable.Text = "Tên bàn";
            // 
            // idTable
            // 
            idTable.AutoSize = true;
            idTable.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idTable.ForeColor = Color.FromArgb(0, 0, 192);
            idTable.Location = new Point(24, 69);
            idTable.Name = "idTable";
            idTable.Size = new Size(57, 24);
            idTable.TabIndex = 11;
            idTable.Text = "Mã bàn";
            // 
            // titleTabel
            // 
            titleTabel.AutoSize = true;
            titleTabel.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleTabel.ForeColor = Color.FromArgb(0, 0, 192);
            titleTabel.Location = new Point(78, 16);
            titleTabel.Name = "titleTabel";
            titleTabel.Size = new Size(70, 24);
            titleTabel.TabIndex = 9;
            titleTabel.Text = "Thông tin";
            // 
            // slotTableTxt
            // 
            slotTableTxt.BorderStyle = BorderStyle.None;
            slotTableTxt.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            slotTableTxt.Location = new Point(65, 230);
            slotTableTxt.Name = "slotTableTxt";
            slotTableTxt.ReadOnly = true;
            slotTableTxt.Size = new Size(209, 25);
            slotTableTxt.TabIndex = 5;
            // 
            // tableNameTxt
            // 
            tableNameTxt.BorderStyle = BorderStyle.None;
            tableNameTxt.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tableNameTxt.Location = new Point(65, 165);
            tableNameTxt.Name = "tableNameTxt";
            tableNameTxt.ReadOnly = true;
            tableNameTxt.Size = new Size(209, 25);
            tableNameTxt.TabIndex = 3;
            // 
            // tableIdTxt
            // 
            tableIdTxt.BorderStyle = BorderStyle.None;
            tableIdTxt.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tableIdTxt.Location = new Point(65, 99);
            tableIdTxt.Name = "tableIdTxt";
            tableIdTxt.ReadOnly = true;
            tableIdTxt.Size = new Size(209, 25);
            tableIdTxt.TabIndex = 1;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.Image = (Image)resources.GetObject("saveBtn.Image");
            saveBtn.ImageAlign = ContentAlignment.MiddleLeft;
            saveBtn.Location = new Point(60, 414);
            saveBtn.Name = "saveBtn";
            saveBtn.Padding = new Padding(20, 0, 0, 0);
            saveBtn.Size = new Size(195, 49);
            saveBtn.TabIndex = 20;
            saveBtn.Text = "Lưu thay đổi";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Visible = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // payBtn
            // 
            payBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            payBtn.Image = (Image)resources.GetObject("payBtn.Image");
            payBtn.ImageAlign = ContentAlignment.MiddleLeft;
            payBtn.Location = new Point(60, 414);
            payBtn.Name = "payBtn";
            payBtn.Padding = new Padding(20, 0, 0, 0);
            payBtn.Size = new Size(195, 49);
            payBtn.TabIndex = 8;
            payBtn.Text = "Tổng hóa đơn";
            payBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(payLabel);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(332, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 528);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(74, 262);
            label1.Name = "label1";
            label1.Size = new Size(199, 24);
            label1.TabIndex = 11;
            label1.Text = "Chưa có thông tin thanh toán";
            // 
            // payLabel
            // 
            payLabel.AutoSize = true;
            payLabel.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            payLabel.ForeColor = Color.FromArgb(0, 0, 192);
            payLabel.Location = new Point(96, 16);
            payLabel.Name = "payLabel";
            payLabel.Size = new Size(126, 24);
            payLabel.TabIndex = 10;
            payLabel.Text = "Thông tin hóa đơn";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(leaveBtn);
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(changeBtn);
            panel2.Controls.Add(infoBtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 537);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 131);
            panel2.TabIndex = 1;
            // 
            // leaveBtn
            // 
            leaveBtn.BackColor = Color.RosyBrown;
            leaveBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            leaveBtn.ForeColor = SystemColors.ButtonHighlight;
            leaveBtn.Image = (Image)resources.GetObject("leaveBtn.Image");
            leaveBtn.ImageAlign = ContentAlignment.MiddleLeft;
            leaveBtn.Location = new Point(500, 40);
            leaveBtn.Name = "leaveBtn";
            leaveBtn.Padding = new Padding(20, 0, 0, 0);
            leaveBtn.Size = new Size(150, 49);
            leaveBtn.TabIndex = 13;
            leaveBtn.Text = "Khóa bàn";
            leaveBtn.UseVisualStyleBackColor = false;
            leaveBtn.Click += leaveBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Red;
            deleteBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.ForeColor = SystemColors.ButtonHighlight;
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteBtn.Location = new Point(332, 40);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Padding = new Padding(20, 0, 0, 0);
            deleteBtn.Size = new Size(150, 49);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Xóa bàn";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // changeBtn
            // 
            changeBtn.BackColor = Color.DarkGray;
            changeBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            changeBtn.ForeColor = SystemColors.ActiveCaptionText;
            changeBtn.Image = (Image)resources.GetObject("changeBtn.Image");
            changeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            changeBtn.Location = new Point(176, 40);
            changeBtn.Name = "changeBtn";
            changeBtn.Padding = new Padding(20, 0, 0, 0);
            changeBtn.Size = new Size(150, 49);
            changeBtn.TabIndex = 11;
            changeBtn.Text = "Chỉnh sửa";
            changeBtn.UseVisualStyleBackColor = false;
            changeBtn.Click += changeBtn_Click;
            // 
            // infoBtn
            // 
            infoBtn.BackColor = Color.SeaShell;
            infoBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            infoBtn.ForeColor = SystemColors.ActiveCaptionText;
            infoBtn.Image = (Image)resources.GetObject("infoBtn.Image");
            infoBtn.ImageAlign = ContentAlignment.MiddleLeft;
            infoBtn.Location = new Point(10, 40);
            infoBtn.Name = "infoBtn";
            infoBtn.Padding = new Padding(20, 0, 0, 0);
            infoBtn.Size = new Size(150, 49);
            infoBtn.TabIndex = 10;
            infoBtn.Text = "Thông tin";
            infoBtn.UseVisualStyleBackColor = false;
            // 
            // ctTableView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Name = "ctTableView";
            Size = new Size(685, 668);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private TextBox tableIdTxt;
        private TextBox slotTableTxt;
        private TextBox tableNameTxt;
        private Button payBtn;
        private Panel panel2;
        private Button infoBtn;
        private Button changeBtn;
        private Label titleTabel;
        private Button deleteBtn;
        private Panel panel3;
        private Label payLabel;
        private Label label1;
        private Button leaveBtn;
        private Label slotTable;
        private Label nameTable;
        private Label idTable;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label statusTable;
        private TextBox statusTableTxt;
        private Button saveBtn;
    }
}
