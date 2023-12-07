namespace GUI
{
    partial class ctHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctHome));
            createBill = new Button();
            historyBtn = new Button();
            listCustomerBtn = new Button();
            couponBtn = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            button2 = new Button();
            groupBox4 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            billControlGroup = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // createBill
            // 
            createBill.BackColor = Color.SeaShell;
            createBill.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createBill.Image = (Image)resources.GetObject("createBill.Image");
            createBill.ImageAlign = ContentAlignment.MiddleLeft;
            createBill.Location = new Point(6, 31);
            createBill.Name = "createBill";
            createBill.Padding = new Padding(20, 0, 0, 0);
            createBill.Size = new Size(195, 91);
            createBill.TabIndex = 4;
            createBill.Text = "Tạo";
            createBill.UseVisualStyleBackColor = false;
            createBill.Click += createBill_Click;
            // 
            // historyBtn
            // 
            historyBtn.BackColor = Color.SeaShell;
            historyBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            historyBtn.Image = (Image)resources.GetObject("historyBtn.Image");
            historyBtn.ImageAlign = ContentAlignment.MiddleLeft;
            historyBtn.Location = new Point(6, 130);
            historyBtn.Name = "historyBtn";
            historyBtn.Padding = new Padding(20, 0, 0, 0);
            historyBtn.Size = new Size(195, 91);
            historyBtn.TabIndex = 5;
            historyBtn.Text = "Lịch sử";
            historyBtn.UseVisualStyleBackColor = false;
            historyBtn.Click += historyBtn_Click;
            // 
            // listCustomerBtn
            // 
            listCustomerBtn.BackColor = Color.SeaShell;
            listCustomerBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listCustomerBtn.Image = (Image)resources.GetObject("listCustomerBtn.Image");
            listCustomerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            listCustomerBtn.Location = new Point(7, 31);
            listCustomerBtn.Name = "listCustomerBtn";
            listCustomerBtn.Padding = new Padding(20, 0, 0, 0);
            listCustomerBtn.Size = new Size(195, 91);
            listCustomerBtn.TabIndex = 6;
            listCustomerBtn.Text = "Danh sách";
            listCustomerBtn.UseVisualStyleBackColor = false;
            listCustomerBtn.Click += listCustomerBtn_Click;
            // 
            // couponBtn
            // 
            couponBtn.BackColor = Color.SeaShell;
            couponBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            couponBtn.Image = (Image)resources.GetObject("couponBtn.Image");
            couponBtn.ImageAlign = ContentAlignment.MiddleLeft;
            couponBtn.Location = new Point(6, 28);
            couponBtn.Name = "couponBtn";
            couponBtn.Padding = new Padding(20, 0, 0, 0);
            couponBtn.Size = new Size(195, 91);
            couponBtn.TabIndex = 7;
            couponBtn.Text = "Thông tin";
            couponBtn.UseVisualStyleBackColor = false;
            couponBtn.Click += couponBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(createBill);
            groupBox1.Controls.Add(historyBtn);
            groupBox1.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(22, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(208, 234);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "HOÁ ĐƠN";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(listCustomerBtn);
            groupBox2.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(253, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(208, 234);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "KHÁCH HÀNG";
            // 
            // button1
            // 
            button1.BackColor = Color.SeaShell;
            button1.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(7, 132);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(195, 91);
            button1.TabIndex = 7;
            button1.Text = "Đổi điểm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(couponBtn);
            groupBox3.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(489, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(208, 234);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "CỬA HÀNG";
            // 
            // button2
            // 
            button2.BackColor = Color.SeaShell;
            button2.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(7, 130);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(195, 91);
            button2.TabIndex = 8;
            button2.Text = "Giảm giá";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(button3);
            groupBox4.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(724, 13);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(208, 234);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "NHÂN VIÊN";
            // 
            // button4
            // 
            button4.BackColor = Color.SeaShell;
            button4.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(8, 130);
            button4.Name = "button4";
            button4.Padding = new Padding(20, 0, 0, 0);
            button4.Size = new Size(195, 91);
            button4.TabIndex = 10;
            button4.Text = "Quản lý";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaShell;
            button3.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(7, 32);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(195, 91);
            button3.TabIndex = 9;
            button3.Text = "Thông tin";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // billControlGroup
            // 
            billControlGroup.BackColor = Color.White;
            billControlGroup.BorderStyle = BorderStyle.Fixed3D;
            billControlGroup.Location = new Point(24, 253);
            billControlGroup.Name = "billControlGroup";
            billControlGroup.Size = new Size(910, 403);
            billControlGroup.TabIndex = 15;
            // 
            // ctHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(billControlGroup);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ctHome";
            Size = new Size(956, 668);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button createBill;
        private Button historyBtn;
        private Button listCustomerBtn;
        private Button couponBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private FlowLayoutPanel billControlGroup;
    }
}
