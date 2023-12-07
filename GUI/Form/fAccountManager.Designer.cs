namespace GUI
{
    partial class fAccountManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAccountManager));
            mainContainer = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            findbyUS = new TextBox();
            addBtn = new Button();
            loadBtn = new Button();
            exitBtn = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainer
            // 
            mainContainer.Location = new Point(4, 37);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(643, 402);
            mainContainer.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(4, -7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(643, 44);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(findbyUS);
            groupBox2.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(655, 206);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(233, 115);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "TÌM KIẾM";
            // 
            // findbyUS
            // 
            findbyUS.Location = new Point(33, 40);
            findbyUS.Name = "findbyUS";
            findbyUS.Size = new Size(171, 32);
            findbyUS.TabIndex = 0;
            findbyUS.Text = "Nhập tên để tìm";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.SeaShell;
            addBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.Image = (Image)resources.GetObject("addBtn.Image");
            addBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addBtn.Location = new Point(699, 23);
            addBtn.Name = "addBtn";
            addBtn.Padding = new Padding(20, 0, 0, 0);
            addBtn.Size = new Size(150, 57);
            addBtn.TabIndex = 7;
            addBtn.Text = "Thêm";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.BackColor = Color.SeaShell;
            loadBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadBtn.Image = (Image)resources.GetObject("loadBtn.Image");
            loadBtn.ImageAlign = ContentAlignment.MiddleLeft;
            loadBtn.Location = new Point(699, 100);
            loadBtn.Name = "loadBtn";
            loadBtn.Padding = new Padding(20, 0, 0, 0);
            loadBtn.Size = new Size(150, 57);
            loadBtn.TabIndex = 8;
            loadBtn.Text = "Làm mới";
            loadBtn.UseVisualStyleBackColor = false;
            loadBtn.Click += loadBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.SeaShell;
            exitBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtn.Image = (Image)resources.GetObject("exitBtn.Image");
            exitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            exitBtn.Location = new Point(699, 366);
            exitBtn.Name = "exitBtn";
            exitBtn.Padding = new Padding(20, 0, 0, 0);
            exitBtn.Size = new Size(150, 57);
            exitBtn.TabIndex = 9;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // fAccountManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 450);
            Controls.Add(exitBtn);
            Controls.Add(loadBtn);
            Controls.Add(addBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(mainContainer);
            Name = "fAccountManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DANH SÁCH NHÂN VIÊN";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel mainContainer;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox findbyUS;
        private Button addBtn;
        private Button loadBtn;
        private Button exitBtn;
    }
}