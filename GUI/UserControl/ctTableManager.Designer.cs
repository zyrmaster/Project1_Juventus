namespace GUI
{
    partial class ctTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctTableManager));
            panel2 = new Panel();
            sortType = new ComboBox();
            sortLabel = new Label();
            addBtn = new Button();
            panel1 = new Panel();
            countTableBusy = new Label();
            countOpenTable = new Label();
            countTable = new Label();
            homeBtn = new Button();
            tableManager = new FlowLayoutPanel();
            titlePanel = new Panel();
            titleLabel = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableManager.SuspendLayout();
            titlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(sortType);
            panel2.Controls.Add(sortLabel);
            panel2.Controls.Add(addBtn);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(homeBtn);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(685, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 668);
            panel2.TabIndex = 1;
            // 
            // sortType
            // 
            sortType.DropDownStyle = ComboBoxStyle.DropDownList;
            sortType.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sortType.FormattingEnabled = true;
            sortType.Items.AddRange(new object[] { "Bàn trống", "Có khách", "Bàn khóa" });
            sortType.Location = new Point(37, 266);
            sortType.Name = "sortType";
            sortType.Size = new Size(205, 32);
            sortType.TabIndex = 8;
            sortType.TextChanged += sortType_TextChanged;
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sortLabel.ForeColor = Color.FromArgb(64, 0, 0);
            sortLabel.Location = new Point(15, 232);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(103, 24);
            sortLabel.TabIndex = 3;
            sortLabel.Text = "Trạng thái bàn";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(192, 255, 192);
            addBtn.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.Image = (Image)resources.GetObject("addBtn.Image");
            addBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addBtn.Location = new Point(0, 643);
            addBtn.Name = "addBtn";
            addBtn.Padding = new Padding(20, 0, 0, 0);
            addBtn.Size = new Size(127, 25);
            addBtn.TabIndex = 7;
            addBtn.Text = "Thêm bàn";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(countTableBusy);
            panel1.Controls.Add(countOpenTable);
            panel1.Controls.Add(countTable);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 125);
            panel1.TabIndex = 5;
            // 
            // countTableBusy
            // 
            countTableBusy.AutoSize = true;
            countTableBusy.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            countTableBusy.ForeColor = Color.Brown;
            countTableBusy.Location = new Point(9, 80);
            countTableBusy.Name = "countTableBusy";
            countTableBusy.Size = new Size(102, 24);
            countTableBusy.TabIndex = 2;
            countTableBusy.Text = "Số bàn bận : 0";
            // 
            // countOpenTable
            // 
            countOpenTable.AutoSize = true;
            countOpenTable.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            countOpenTable.ForeColor = Color.ForestGreen;
            countOpenTable.Location = new Point(9, 44);
            countOpenTable.Name = "countOpenTable";
            countOpenTable.Size = new Size(113, 24);
            countOpenTable.TabIndex = 1;
            countOpenTable.Text = "Số bàn trống : 0";
            // 
            // countTable
            // 
            countTable.AutoSize = true;
            countTable.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            countTable.ForeColor = Color.FromArgb(64, 0, 0);
            countTable.Location = new Point(9, 9);
            countTable.Name = "countTable";
            countTable.Size = new Size(106, 24);
            countTable.TabIndex = 0;
            countTable.Text = "Tổng số bàn : 0";
            // 
            // homeBtn
            // 
            homeBtn.BackColor = Color.SeaShell;
            homeBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            homeBtn.Image = (Image)resources.GetObject("homeBtn.Image");
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(37, 157);
            homeBtn.Name = "homeBtn";
            homeBtn.Padding = new Padding(20, 0, 0, 0);
            homeBtn.Size = new Size(195, 49);
            homeBtn.TabIndex = 4;
            homeBtn.Text = "Làm mới";
            homeBtn.UseVisualStyleBackColor = false;
            homeBtn.Click += homeBtn_Click;
            // 
            // tableManager
            // 
            tableManager.AutoScroll = true;
            tableManager.BackColor = Color.White;
            tableManager.Controls.Add(titlePanel);
            tableManager.Location = new Point(0, 0);
            tableManager.Name = "tableManager";
            tableManager.Size = new Size(685, 668);
            tableManager.TabIndex = 2;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = SystemColors.ControlLight;
            titlePanel.Controls.Add(titleLabel);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(3, 3);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(685, 63);
            titlePanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Bahnschrift Light Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.FromArgb(64, 0, 0);
            titleLabel.Location = new Point(198, 11);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(216, 41);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Quản lý hệ thống ";
            // 
            // ctTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableManager);
            Controls.Add(panel2);
            Name = "ctTableManager";
            Size = new Size(956, 668);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableManager.ResumeLayout(false);
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button homeBtn;
        private FlowLayoutPanel tableManager;
        private Panel titlePanel;
        private Label titleLabel;
        private Panel panel1;
        private Label countTable;
        private Label countOpenTable;
        private Label countTableBusy;
        private Button addBtn;
        private ComboBox sortType;
        private Label sortLabel;
    }
}
