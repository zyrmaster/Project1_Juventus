namespace GUI
{
    partial class fTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            title_panel = new Panel();
            controlBox = new Panel();
            minipanel = new Panel();
            hideBtn = new PictureBox();
            zoomPanel = new Panel();
            zoomBtn = new PictureBox();
            exitPanel = new Panel();
            exitBtn = new PictureBox();
            titleName = new Label();
            menu_pictureBox = new PictureBox();
            homeBtn = new Button();
            listBtn = new Button();
            managerBtn = new Button();
            leftPanel = new Panel();
            websiteLink = new LinkLabel();
            settingBtn = new Button();
            staticBtn = new Button();
            infomationBtn = new Button();
            infomationPanel = new Panel();
            profile = new PictureBox();
            roleLabel = new Label();
            nametitleLabel = new Label();
            mainContainer = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            title_panel.SuspendLayout();
            controlBox.SuspendLayout();
            minipanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hideBtn).BeginInit();
            zoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)zoomBtn).BeginInit();
            exitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exitBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menu_pictureBox).BeginInit();
            leftPanel.SuspendLayout();
            infomationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profile).BeginInit();
            SuspendLayout();
            // 
            // title_panel
            // 
            title_panel.BackColor = SystemColors.ControlLightLight;
            title_panel.Controls.Add(controlBox);
            title_panel.Controls.Add(titleName);
            title_panel.Controls.Add(menu_pictureBox);
            title_panel.Dock = DockStyle.Top;
            title_panel.Location = new Point(0, 0);
            title_panel.Name = "title_panel";
            title_panel.Size = new Size(1179, 39);
            title_panel.TabIndex = 0;
            title_panel.Paint += title_panel_Paint;
            title_panel.MouseDown += title_panel_MouseDown;
            title_panel.MouseMove += title_panel_MouseMove;
            title_panel.MouseUp += title_panel_MouseUp;
            // 
            // controlBox
            // 
            controlBox.Controls.Add(minipanel);
            controlBox.Controls.Add(zoomPanel);
            controlBox.Controls.Add(exitPanel);
            controlBox.Dock = DockStyle.Right;
            controlBox.Location = new Point(1040, 0);
            controlBox.Name = "controlBox";
            controlBox.Size = new Size(139, 39);
            controlBox.TabIndex = 9;
            // 
            // minipanel
            // 
            minipanel.Controls.Add(hideBtn);
            minipanel.Location = new Point(32, 6);
            minipanel.Name = "minipanel";
            minipanel.Size = new Size(28, 29);
            minipanel.TabIndex = 8;
            // 
            // hideBtn
            // 
            hideBtn.Dock = DockStyle.Fill;
            hideBtn.Image = (Image)resources.GetObject("hideBtn.Image");
            hideBtn.Location = new Point(0, 0);
            hideBtn.Name = "hideBtn";
            hideBtn.Size = new Size(28, 29);
            hideBtn.SizeMode = PictureBoxSizeMode.Zoom;
            hideBtn.TabIndex = 5;
            hideBtn.TabStop = false;
            hideBtn.Click += pictureBox1_Click_1;
            // 
            // zoomPanel
            // 
            zoomPanel.Controls.Add(zoomBtn);
            zoomPanel.Location = new Point(69, 6);
            zoomPanel.Name = "zoomPanel";
            zoomPanel.Size = new Size(28, 29);
            zoomPanel.TabIndex = 8;
            // 
            // zoomBtn
            // 
            zoomBtn.Dock = DockStyle.Fill;
            zoomBtn.Image = (Image)resources.GetObject("zoomBtn.Image");
            zoomBtn.Location = new Point(0, 0);
            zoomBtn.Name = "zoomBtn";
            zoomBtn.Size = new Size(28, 29);
            zoomBtn.SizeMode = PictureBoxSizeMode.Zoom;
            zoomBtn.TabIndex = 4;
            zoomBtn.TabStop = false;
            zoomBtn.Click += pictureBox1_Click;
            // 
            // exitPanel
            // 
            exitPanel.Controls.Add(exitBtn);
            exitPanel.Location = new Point(104, 6);
            exitPanel.Name = "exitPanel";
            exitPanel.Size = new Size(28, 29);
            exitPanel.TabIndex = 7;
            // 
            // exitBtn
            // 
            exitBtn.Dock = DockStyle.Fill;
            exitBtn.Image = (Image)resources.GetObject("exitBtn.Image");
            exitBtn.Location = new Point(0, 0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(28, 29);
            exitBtn.SizeMode = PictureBoxSizeMode.Zoom;
            exitBtn.TabIndex = 3;
            exitBtn.TabStop = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // titleName
            // 
            titleName.AutoSize = true;
            titleName.Location = new Point(43, 10);
            titleName.Name = "titleName";
            titleName.Size = new Size(237, 20);
            titleName.TabIndex = 2;
            titleName.Text = "Giao diện quản lý | Juventus Group";
            // 
            // menu_pictureBox
            // 
            menu_pictureBox.Image = (Image)resources.GetObject("menu_pictureBox.Image");
            menu_pictureBox.Location = new Point(9, 6);
            menu_pictureBox.Name = "menu_pictureBox";
            menu_pictureBox.Size = new Size(26, 26);
            menu_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            menu_pictureBox.TabIndex = 1;
            menu_pictureBox.TabStop = false;
            menu_pictureBox.MouseHover += menu_pictureBox_MouseHover;
            // 
            // homeBtn
            // 
            homeBtn.BackColor = Color.SeaShell;
            homeBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            homeBtn.Image = (Image)resources.GetObject("homeBtn.Image");
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(12, 169);
            homeBtn.Name = "homeBtn";
            homeBtn.Padding = new Padding(20, 0, 0, 0);
            homeBtn.Size = new Size(195, 49);
            homeBtn.TabIndex = 3;
            homeBtn.Text = "Trang chủ";
            homeBtn.UseVisualStyleBackColor = false;
            homeBtn.Click += homeBtn_Click;
            // 
            // listBtn
            // 
            listBtn.BackColor = Color.SeaShell;
            listBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBtn.Image = (Image)resources.GetObject("listBtn.Image");
            listBtn.ImageAlign = ContentAlignment.MiddleLeft;
            listBtn.Location = new Point(12, 224);
            listBtn.Name = "listBtn";
            listBtn.Padding = new Padding(20, 0, 0, 0);
            listBtn.Size = new Size(195, 49);
            listBtn.TabIndex = 4;
            listBtn.Text = "Sản phẩm";
            listBtn.UseVisualStyleBackColor = false;
            listBtn.Click += listBtn_Click;
            // 
            // managerBtn
            // 
            managerBtn.BackColor = Color.SeaShell;
            managerBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            managerBtn.Image = (Image)resources.GetObject("managerBtn.Image");
            managerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            managerBtn.Location = new Point(12, 279);
            managerBtn.Name = "managerBtn";
            managerBtn.Padding = new Padding(20, 0, 0, 0);
            managerBtn.Size = new Size(195, 49);
            managerBtn.TabIndex = 5;
            managerBtn.Text = "Quản lý";
            managerBtn.UseVisualStyleBackColor = false;
            managerBtn.Click += managerBtn_Click;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = SystemColors.ControlLight;
            leftPanel.Controls.Add(websiteLink);
            leftPanel.Controls.Add(settingBtn);
            leftPanel.Controls.Add(staticBtn);
            leftPanel.Controls.Add(infomationBtn);
            leftPanel.Controls.Add(infomationPanel);
            leftPanel.Controls.Add(homeBtn);
            leftPanel.Controls.Add(managerBtn);
            leftPanel.Controls.Add(listBtn);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 39);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(223, 668);
            leftPanel.TabIndex = 6;
            // 
            // websiteLink
            // 
            websiteLink.AutoSize = true;
            websiteLink.Dock = DockStyle.Bottom;
            websiteLink.Font = new Font("Bahnschrift", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            websiteLink.Location = new Point(0, 652);
            websiteLink.Name = "websiteLink";
            websiteLink.Size = new Size(183, 16);
            websiteLink.TabIndex = 10;
            websiteLink.TabStop = true;
            websiteLink.Text = "Truy cập trang chủ - ZyrMaster";
            // 
            // settingBtn
            // 
            settingBtn.BackColor = Color.SeaShell;
            settingBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            settingBtn.Image = (Image)resources.GetObject("settingBtn.Image");
            settingBtn.ImageAlign = ContentAlignment.MiddleLeft;
            settingBtn.Location = new Point(12, 444);
            settingBtn.Name = "settingBtn";
            settingBtn.Padding = new Padding(20, 0, 0, 0);
            settingBtn.Size = new Size(195, 49);
            settingBtn.TabIndex = 9;
            settingBtn.Text = "Thoát chương trình";
            settingBtn.UseVisualStyleBackColor = false;
            settingBtn.Click += settingBtn_Click;
            // 
            // staticBtn
            // 
            staticBtn.BackColor = Color.SeaShell;
            staticBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            staticBtn.Image = (Image)resources.GetObject("staticBtn.Image");
            staticBtn.ImageAlign = ContentAlignment.MiddleLeft;
            staticBtn.Location = new Point(10, 334);
            staticBtn.Name = "staticBtn";
            staticBtn.Padding = new Padding(20, 0, 0, 0);
            staticBtn.Size = new Size(195, 49);
            staticBtn.TabIndex = 8;
            staticBtn.Text = "Thống kê";
            staticBtn.UseVisualStyleBackColor = false;
            staticBtn.Click += staticBtn_Click;
            // 
            // infomationBtn
            // 
            infomationBtn.BackColor = Color.SeaShell;
            infomationBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            infomationBtn.Image = (Image)resources.GetObject("infomationBtn.Image");
            infomationBtn.ImageAlign = ContentAlignment.MiddleLeft;
            infomationBtn.Location = new Point(12, 389);
            infomationBtn.Name = "infomationBtn";
            infomationBtn.Padding = new Padding(20, 0, 0, 0);
            infomationBtn.Size = new Size(195, 49);
            infomationBtn.TabIndex = 7;
            infomationBtn.Text = "Thông tin";
            infomationBtn.UseVisualStyleBackColor = false;
            infomationBtn.Click += infomationBtn_Click;
            // 
            // infomationPanel
            // 
            infomationPanel.Controls.Add(profile);
            infomationPanel.Controls.Add(roleLabel);
            infomationPanel.Controls.Add(nametitleLabel);
            infomationPanel.Dock = DockStyle.Top;
            infomationPanel.Location = new Point(0, 0);
            infomationPanel.Name = "infomationPanel";
            infomationPanel.Size = new Size(223, 156);
            infomationPanel.TabIndex = 6;
            // 
            // profile
            // 
            profile.Image = (Image)resources.GetObject("profile.Image");
            profile.InitialImage = (Image)resources.GetObject("profile.InitialImage");
            profile.Location = new Point(77, 28);
            profile.Name = "profile";
            profile.Size = new Size(64, 64);
            profile.SizeMode = PictureBoxSizeMode.AutoSize;
            profile.TabIndex = 2;
            profile.TabStop = false;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point);
            roleLabel.Location = new Point(75, 126);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(62, 20);
            roleLabel.TabIndex = 1;
            roleLabel.Text = "Quản lý";
            // 
            // nametitleLabel
            // 
            nametitleLabel.AutoSize = true;
            nametitleLabel.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nametitleLabel.Location = new Point(53, 101);
            nametitleLabel.Name = "nametitleLabel";
            nametitleLabel.Size = new Size(113, 20);
            nametitleLabel.TabIndex = 0;
            nametitleLabel.Text = "Phạm Tiến Đức";
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.White;
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(223, 39);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(956, 668);
            mainContainer.TabIndex = 7;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 707);
            Controls.Add(mainContainer);
            Controls.Add(leftPanel);
            Controls.Add(title_panel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            title_panel.ResumeLayout(false);
            title_panel.PerformLayout();
            controlBox.ResumeLayout(false);
            minipanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hideBtn).EndInit();
            zoomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)zoomBtn).EndInit();
            exitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)exitBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)menu_pictureBox).EndInit();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            infomationPanel.ResumeLayout(false);
            infomationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel title_panel;
        private PictureBox menu_pictureBox;
        private Label titleName;
        private PictureBox exitBtn;
        private PictureBox zoomBtn;
        private PictureBox hideBtn;
        private Button homeBtn;
        private Button listBtn;
        private Button managerBtn;
        private Panel leftPanel;
        private Panel infomationPanel;
        private Label nametitleLabel;
        private Button staticBtn;
        private Button infomationBtn;
        private LinkLabel websiteLink;
        private Button settingBtn;
        private Panel minipanel;
        private Panel zoomPanel;
        private Panel exitPanel;
        private Panel controlBox;
        private Panel mainContainer;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label roleLabel;
        private PictureBox profile;
    }
}