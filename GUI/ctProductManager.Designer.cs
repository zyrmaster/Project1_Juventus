namespace GUI
{
    partial class ctProductManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctProductManager));
            headerPanel = new Panel();
            addBtn = new Button();
            reloadBtn = new Button();
            titleLabel = new Label();
            cateSortTxt = new ComboBox();
            cateSortLabel = new Label();
            leftHeaderPanel = new Panel();
            searchTxt = new TextBox();
            mainContainer = new FlowLayoutPanel();
            fullPanel = new Panel();
            headerPanel.SuspendLayout();
            leftHeaderPanel.SuspendLayout();
            fullPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.SeaShell;
            headerPanel.Controls.Add(addBtn);
            headerPanel.Controls.Add(reloadBtn);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(cateSortTxt);
            headerPanel.Controls.Add(cateSortLabel);
            headerPanel.Controls.Add(leftHeaderPanel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(956, 65);
            headerPanel.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.SeaShell;
            addBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.Image = (Image)resources.GetObject("addBtn.Image");
            addBtn.Location = new Point(286, 12);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(46, 38);
            addBtn.TabIndex = 6;
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // reloadBtn
            // 
            reloadBtn.BackColor = Color.SeaShell;
            reloadBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            reloadBtn.Image = (Image)resources.GetObject("reloadBtn.Image");
            reloadBtn.Location = new Point(619, 10);
            reloadBtn.Name = "reloadBtn";
            reloadBtn.Size = new Size(46, 38);
            reloadBtn.TabIndex = 5;
            reloadBtn.UseVisualStyleBackColor = false;
            reloadBtn.Click += reloadBtn_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(671, 19);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(267, 24);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Quản lý sản phẩm | Jusventus Manager";
            // 
            // cateSortTxt
            // 
            cateSortTxt.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cateSortTxt.FormattingEnabled = true;
            cateSortTxt.Items.AddRange(new object[] { "Đồ uống", "Đồ ăn", "Dịch vụ" });
            cateSortTxt.Location = new Point(414, 13);
            cateSortTxt.Name = "cateSortTxt";
            cateSortTxt.Size = new Size(197, 32);
            cateSortTxt.TabIndex = 2;
            cateSortTxt.TextChanged += cateSortTxt_TextChanged;
            // 
            // cateSortLabel
            // 
            cateSortLabel.AutoSize = true;
            cateSortLabel.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cateSortLabel.Location = new Point(334, 18);
            cateSortLabel.Name = "cateSortLabel";
            cateSortLabel.Size = new Size(74, 24);
            cateSortLabel.TabIndex = 1;
            cateSortLabel.Text = "Phân Loại";
            // 
            // leftHeaderPanel
            // 
            leftHeaderPanel.Controls.Add(searchTxt);
            leftHeaderPanel.Dock = DockStyle.Left;
            leftHeaderPanel.Location = new Point(0, 0);
            leftHeaderPanel.Name = "leftHeaderPanel";
            leftHeaderPanel.Size = new Size(311, 65);
            leftHeaderPanel.TabIndex = 0;
            // 
            // searchTxt
            // 
            searchTxt.BackColor = Color.White;
            searchTxt.BorderStyle = BorderStyle.None;
            searchTxt.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchTxt.Location = new Point(17, 18);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(263, 25);
            searchTxt.TabIndex = 0;
            searchTxt.Text = "Nhập tên sản phẩm\r\n";
            searchTxt.Click += searchTxt_Click;
            searchTxt.TextChanged += searchTxt_TextChanged;
            // 
            // mainContainer
            // 
            mainContainer.AutoScroll = true;
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(956, 603);
            mainContainer.TabIndex = 1;
            // 
            // fullPanel
            // 
            fullPanel.AutoScroll = true;
            fullPanel.Controls.Add(mainContainer);
            fullPanel.Dock = DockStyle.Fill;
            fullPanel.Location = new Point(0, 65);
            fullPanel.Name = "fullPanel";
            fullPanel.Size = new Size(956, 603);
            fullPanel.TabIndex = 2;
            // 
            // ctProductManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fullPanel);
            Controls.Add(headerPanel);
            Name = "ctProductManager";
            Size = new Size(956, 668);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            leftHeaderPanel.ResumeLayout(false);
            leftHeaderPanel.PerformLayout();
            fullPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Panel leftHeaderPanel;
        private TextBox searchTxt;
        private ComboBox cateSortTxt;
        private Label cateSortLabel;
        private Label titleLabel;
        private FlowLayoutPanel mainContainer;
        private Button reloadBtn;
        private Panel fullPanel;
        private Button addBtn;
    }
}
