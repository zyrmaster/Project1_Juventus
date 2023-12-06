namespace GUI
{
    partial class CreateBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBill));
            groupBox1 = new GroupBox();
            addCustomer = new Button();
            inputDiscount = new TextBox();
            discountCheck = new CheckBox();
            phoneCustomer = new TextBox();
            phoneNumber = new Label();
            customerName = new TextBox();
            customer = new Label();
            customerMoney = new ComboBox();
            totalMoney = new TextBox();
            label8 = new Label();
            leftMoney = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tableList = new ComboBox();
            label5 = new Label();
            typeBill = new ComboBox();
            label4 = new Label();
            billCode = new Label();
            billControl = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            label10 = new Label();
            productShow = new FlowLayoutPanel();
            confirmBtn = new Button();
            payBtn = new Button();
            printBtn = new Button();
            exitBtn = new Button();
            cashBtn = new Button();
            bankBtn = new Button();
            postBtn = new Button();
            getoutBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addCustomer);
            groupBox1.Controls.Add(inputDiscount);
            groupBox1.Controls.Add(discountCheck);
            groupBox1.Controls.Add(phoneCustomer);
            groupBox1.Controls.Add(phoneNumber);
            groupBox1.Controls.Add(customerName);
            groupBox1.Controls.Add(customer);
            groupBox1.Controls.Add(customerMoney);
            groupBox1.Controls.Add(totalMoney);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(leftMoney);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tableList);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(typeBill);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(billCode);
            groupBox1.Controls.Add(billControl);
            groupBox1.Location = new Point(478, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(593, 538);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "HOÁ ĐƠN";
            // 
            // addCustomer
            // 
            addCustomer.BackColor = Color.SeaShell;
            addCustomer.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addCustomer.Location = new Point(234, 372);
            addCustomer.Name = "addCustomer";
            addCustomer.Padding = new Padding(20, 0, 0, 0);
            addCustomer.Size = new Size(26, 25);
            addCustomer.TabIndex = 9;
            addCustomer.Text = "+";
            addCustomer.TextAlign = ContentAlignment.MiddleLeft;
            addCustomer.UseVisualStyleBackColor = false;
            addCustomer.Click += addCustomer_Click;
            // 
            // inputDiscount
            // 
            inputDiscount.BackColor = SystemColors.ScrollBar;
            inputDiscount.BorderStyle = BorderStyle.None;
            inputDiscount.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            inputDiscount.Location = new Point(32, 472);
            inputDiscount.Name = "inputDiscount";
            inputDiscount.Size = new Size(130, 21);
            inputDiscount.TabIndex = 21;
            inputDiscount.Visible = false;
            // 
            // discountCheck
            // 
            discountCheck.AutoSize = true;
            discountCheck.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            discountCheck.Location = new Point(32, 441);
            discountCheck.Name = "discountCheck";
            discountCheck.Size = new Size(99, 25);
            discountCheck.TabIndex = 20;
            discountCheck.Text = "Mã giảm giá";
            discountCheck.UseVisualStyleBackColor = true;
            discountCheck.CheckedChanged += discountCheck_CheckedChanged;
            // 
            // phoneCustomer
            // 
            phoneCustomer.BackColor = SystemColors.ScrollBar;
            phoneCustomer.BorderStyle = BorderStyle.None;
            phoneCustomer.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            phoneCustomer.Location = new Point(98, 402);
            phoneCustomer.Name = "phoneCustomer";
            phoneCustomer.Size = new Size(130, 21);
            phoneCustomer.TabIndex = 19;
            phoneCustomer.TextChanged += textBox2_TextChanged;
            // 
            // phoneNumber
            // 
            phoneNumber.AutoSize = true;
            phoneNumber.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumber.Location = new Point(21, 402);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(71, 21);
            phoneNumber.TabIndex = 18;
            phoneNumber.Text = "Điện thoại :";
            // 
            // customerName
            // 
            customerName.BackColor = SystemColors.ScrollBar;
            customerName.BorderStyle = BorderStyle.None;
            customerName.Enabled = false;
            customerName.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customerName.Location = new Point(98, 375);
            customerName.Name = "customerName";
            customerName.Size = new Size(130, 21);
            customerName.TabIndex = 17;
            // 
            // customer
            // 
            customer.AutoSize = true;
            customer.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customer.Location = new Point(11, 375);
            customer.Name = "customer";
            customer.Size = new Size(81, 21);
            customer.TabIndex = 16;
            customer.Text = "Khách hàng :";
            // 
            // customerMoney
            // 
            customerMoney.FlatStyle = FlatStyle.Flat;
            customerMoney.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customerMoney.FormattingEnabled = true;
            customerMoney.Items.AddRange(new object[] { "0", "1000", "2000", "5000", "10000", "20000", "50000", "100000", "200000", "500000" });
            customerMoney.Location = new Point(454, 437);
            customerMoney.Name = "customerMoney";
            customerMoney.Size = new Size(130, 29);
            customerMoney.TabIndex = 15;
            customerMoney.SelectedIndexChanged += customerMoney_SelectedIndexChanged;
            customerMoney.TextChanged += customerMoney_TextChanged;
            // 
            // totalMoney
            // 
            totalMoney.BackColor = SystemColors.ScrollBar;
            totalMoney.BorderStyle = BorderStyle.None;
            totalMoney.Enabled = false;
            totalMoney.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            totalMoney.Location = new Point(454, 472);
            totalMoney.Name = "totalMoney";
            totalMoney.Size = new Size(130, 21);
            totalMoney.TabIndex = 13;
            totalMoney.TextChanged += totalMoney_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(373, 472);
            label8.Name = "label8";
            label8.Size = new Size(65, 21);
            label8.TabIndex = 12;
            label8.Text = "Tổng tiền :";
            // 
            // leftMoney
            // 
            leftMoney.BackColor = SystemColors.ScrollBar;
            leftMoney.BorderStyle = BorderStyle.None;
            leftMoney.Enabled = false;
            leftMoney.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            leftMoney.Location = new Point(454, 500);
            leftMoney.Name = "leftMoney";
            leftMoney.Size = new Size(130, 21);
            leftMoney.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(370, 500);
            label7.Name = "label7";
            label7.Size = new Size(68, 21);
            label7.TabIndex = 10;
            label7.Text = "Tiền thừa :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(351, 440);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 8;
            label6.Text = "Tiền khách trả :";
            // 
            // tableList
            // 
            tableList.FlatStyle = FlatStyle.Flat;
            tableList.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tableList.FormattingEnabled = true;
            tableList.Location = new Point(454, 402);
            tableList.Name = "tableList";
            tableList.Size = new Size(130, 29);
            tableList.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(386, 406);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 6;
            label5.Text = "Bàn số :";
            // 
            // typeBill
            // 
            typeBill.FlatStyle = FlatStyle.Flat;
            typeBill.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            typeBill.FormattingEnabled = true;
            typeBill.Items.AddRange(new object[] { "Tại quán", "Mang đi" });
            typeBill.Location = new Point(454, 367);
            typeBill.Name = "typeBill";
            typeBill.Size = new Size(130, 29);
            typeBill.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(386, 370);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 4;
            label4.Text = "Loại đơn :";
            // 
            // billCode
            // 
            billCode.AutoSize = true;
            billCode.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            billCode.Location = new Point(11, 349);
            billCode.Name = "billCode";
            billCode.Size = new Size(87, 21);
            billCode.TabIndex = 1;
            billCode.Text = "Mã hoá đơn : 1";
            // 
            // billControl
            // 
            billControl.AutoScroll = true;
            billControl.BorderStyle = BorderStyle.FixedSingle;
            billControl.Location = new Point(11, 24);
            billControl.Name = "billControl";
            billControl.Size = new Size(573, 322);
            billControl.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(productShow);
            groupBox2.Location = new Point(12, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 628);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "SẢN PHẨM";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(322, 23);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(130, 20);
            textBox4.TabIndex = 16;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(251, 22);
            label10.Name = "label10";
            label10.Size = new Size(67, 21);
            label10.TabIndex = 15;
            label10.Text = "Tìm kiếm :";
            // 
            // productShow
            // 
            productShow.AutoScroll = true;
            productShow.BorderStyle = BorderStyle.FixedSingle;
            productShow.Location = new Point(6, 49);
            productShow.Name = "productShow";
            productShow.Size = new Size(447, 573);
            productShow.TabIndex = 0;
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.SeaShell;
            confirmBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmBtn.Image = (Image)resources.GetObject("confirmBtn.Image");
            confirmBtn.ImageAlign = ContentAlignment.MiddleLeft;
            confirmBtn.Location = new Point(495, 564);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Padding = new Padding(20, 0, 0, 0);
            confirmBtn.Size = new Size(124, 50);
            confirmBtn.TabIndex = 5;
            confirmBtn.Text = "Xác nhận";
            confirmBtn.TextAlign = ContentAlignment.MiddleRight;
            confirmBtn.UseVisualStyleBackColor = false;
            // 
            // payBtn
            // 
            payBtn.BackColor = Color.SeaShell;
            payBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            payBtn.Image = (Image)resources.GetObject("payBtn.Image");
            payBtn.ImageAlign = ContentAlignment.MiddleLeft;
            payBtn.Location = new Point(638, 564);
            payBtn.Name = "payBtn";
            payBtn.Padding = new Padding(20, 0, 0, 0);
            payBtn.Size = new Size(137, 50);
            payBtn.TabIndex = 6;
            payBtn.Text = "Thanh toán";
            payBtn.TextAlign = ContentAlignment.MiddleRight;
            payBtn.UseVisualStyleBackColor = false;
            payBtn.Click += payBtn_Click;
            // 
            // printBtn
            // 
            printBtn.BackColor = Color.SeaShell;
            printBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            printBtn.Image = (Image)resources.GetObject("printBtn.Image");
            printBtn.ImageAlign = ContentAlignment.MiddleLeft;
            printBtn.Location = new Point(781, 564);
            printBtn.Name = "printBtn";
            printBtn.Padding = new Padding(20, 0, 0, 0);
            printBtn.Size = new Size(137, 50);
            printBtn.TabIndex = 7;
            printBtn.Text = "In hoá đơn";
            printBtn.TextAlign = ContentAlignment.MiddleRight;
            printBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.SeaShell;
            exitBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtn.Image = (Image)resources.GetObject("exitBtn.Image");
            exitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            exitBtn.Location = new Point(924, 564);
            exitBtn.Name = "exitBtn";
            exitBtn.Padding = new Padding(20, 0, 0, 0);
            exitBtn.Size = new Size(122, 50);
            exitBtn.TabIndex = 8;
            exitBtn.Text = "Huỷ bỏ";
            exitBtn.TextAlign = ContentAlignment.MiddleRight;
            exitBtn.UseVisualStyleBackColor = false;
            // 
            // cashBtn
            // 
            cashBtn.BackColor = Color.SeaShell;
            cashBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cashBtn.Image = (Image)resources.GetObject("cashBtn.Image");
            cashBtn.ImageAlign = ContentAlignment.MiddleLeft;
            cashBtn.Location = new Point(489, 564);
            cashBtn.Name = "cashBtn";
            cashBtn.Padding = new Padding(20, 0, 0, 0);
            cashBtn.Size = new Size(137, 50);
            cashBtn.TabIndex = 9;
            cashBtn.Text = "Tiền mặt";
            cashBtn.UseVisualStyleBackColor = false;
            cashBtn.Visible = false;
            cashBtn.Click += cashBtn_Click;
            // 
            // bankBtn
            // 
            bankBtn.BackColor = Color.SeaShell;
            bankBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bankBtn.Image = (Image)resources.GetObject("bankBtn.Image");
            bankBtn.ImageAlign = ContentAlignment.MiddleLeft;
            bankBtn.Location = new Point(638, 564);
            bankBtn.Name = "bankBtn";
            bankBtn.Padding = new Padding(20, 0, 0, 0);
            bankBtn.Size = new Size(137, 50);
            bankBtn.TabIndex = 10;
            bankBtn.Text = "Ngân hàng";
            bankBtn.TextAlign = ContentAlignment.MiddleRight;
            bankBtn.UseVisualStyleBackColor = false;
            bankBtn.Visible = false;
            // 
            // postBtn
            // 
            postBtn.BackColor = Color.SeaShell;
            postBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            postBtn.Image = (Image)resources.GetObject("postBtn.Image");
            postBtn.ImageAlign = ContentAlignment.MiddleLeft;
            postBtn.Location = new Point(781, 564);
            postBtn.Name = "postBtn";
            postBtn.Padding = new Padding(20, 0, 0, 0);
            postBtn.Size = new Size(137, 50);
            postBtn.TabIndex = 11;
            postBtn.Text = "Tín dụng";
            postBtn.TextAlign = ContentAlignment.MiddleRight;
            postBtn.UseVisualStyleBackColor = false;
            postBtn.Visible = false;
            postBtn.Click += postBtn_Click;
            // 
            // getoutBtn
            // 
            getoutBtn.BackColor = Color.SeaShell;
            getoutBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            getoutBtn.Image = (Image)resources.GetObject("getoutBtn.Image");
            getoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            getoutBtn.Location = new Point(924, 564);
            getoutBtn.Name = "getoutBtn";
            getoutBtn.Padding = new Padding(20, 0, 0, 0);
            getoutBtn.Size = new Size(122, 50);
            getoutBtn.TabIndex = 12;
            getoutBtn.Text = "Thoát";
            getoutBtn.TextAlign = ContentAlignment.MiddleRight;
            getoutBtn.UseVisualStyleBackColor = false;
            getoutBtn.Visible = false;
            getoutBtn.Click += getoutBtn_Click;
            // 
            // CreateBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 648);
            Controls.Add(getoutBtn);
            Controls.Add(exitBtn);
            Controls.Add(confirmBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(bankBtn);
            Controls.Add(postBtn);
            Controls.Add(cashBtn);
            Controls.Add(payBtn);
            Controls.Add(printBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CreateBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JUVENTUS SOFTWARE | QUẢN LÝ HOÁ ĐƠN";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button confirmBtn;
        private Button payBtn;
        private Label billCode;
        private FlowLayoutPanel billControl;
        private FlowLayoutPanel productShow;
        private Button printBtn;
        private Button exitBtn;
        private ComboBox tableList;
        private Label label5;
        private ComboBox typeBill;
        private Label label4;
        private TextBox totalMoney;
        private Label label8;
        private TextBox leftMoney;
        private Label label7;
        private Label label6;
        private TextBox textBox4;
        private Label label10;
        private ComboBox customerMoney;
        private TextBox customerName;
        private Label customer;
        private TextBox inputDiscount;
        private CheckBox discountCheck;
        private TextBox phoneCustomer;
        private Label phoneNumber;
        private Button addCustomer;
        private Button cashBtn;
        private Button bankBtn;
        private Button postBtn;
        private Button getoutBtn;
    }
}