namespace GUI
{
    partial class BillShow
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
            titleLabel = new Label();
            customerName = new Label();
            idBill = new Label();
            dateTime = new Label();
            productShow = new FlowLayoutPanel();
            tableNum = new Label();
            brand = new Label();
            totalMoney = new Label();
            happy = new Label();
            label1 = new Label();
            status = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Bahnschrift Light Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(132, 5);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(142, 30);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Hoá đơn dịch vụ";
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            customerName.Location = new Point(16, 61);
            customerName.Name = "customerName";
            customerName.Size = new Size(87, 17);
            customerName.TabIndex = 4;
            customerName.Text = "Tên khách hàng :";
            // 
            // idBill
            // 
            idBill.AutoSize = true;
            idBill.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            idBill.Location = new Point(17, 83);
            idBill.Name = "idBill";
            idBill.Size = new Size(68, 17);
            idBill.TabIndex = 5;
            idBill.Text = "Mã hoá đơn :";
            // 
            // dateTime
            // 
            dateTime.AutoSize = true;
            dateTime.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTime.Location = new Point(278, 63);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(36, 17);
            dateTime.TabIndex = 6;
            dateTime.Text = "Ngày :";
            // 
            // productShow
            // 
            productShow.BorderStyle = BorderStyle.FixedSingle;
            productShow.Location = new Point(5, 142);
            productShow.Name = "productShow";
            productShow.Size = new Size(397, 396);
            productShow.TabIndex = 7;
            // 
            // tableNum
            // 
            tableNum.AutoSize = true;
            tableNum.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tableNum.Location = new Point(278, 85);
            tableNum.Name = "tableNum";
            tableNum.Size = new Size(44, 17);
            tableNum.TabIndex = 8;
            tableNum.Text = "Bàn số :";
            // 
            // brand
            // 
            brand.AutoSize = true;
            brand.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            brand.Location = new Point(150, 34);
            brand.Name = "brand";
            brand.Size = new Size(95, 17);
            brand.TabIndex = 9;
            brand.Text = "Juventus Software";
            // 
            // totalMoney
            // 
            totalMoney.AutoSize = true;
            totalMoney.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            totalMoney.Location = new Point(6, 550);
            totalMoney.Name = "totalMoney";
            totalMoney.Size = new Size(55, 17);
            totalMoney.TabIndex = 10;
            totalMoney.Text = "Tổng tiền :";
            // 
            // happy
            // 
            happy.AutoSize = true;
            happy.Font = new Font("Bahnschrift Light Condensed", 7F, FontStyle.Regular, GraphicsUnit.Point);
            happy.Location = new Point(290, 598);
            happy.Name = "happy";
            happy.Size = new Size(114, 14);
            happy.TabIndex = 11;
            happy.Text = "Chúc bạn một ngày vui vẻ !";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Light Condensed", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 598);
            label1.Name = "label1";
            label1.Size = new Size(216, 14);
            label1.TabIndex = 12;
            label1.Text = "House Coffee - Số 1 , Lê Đức Thọ , Nam Từ Liêm , Hà Nội";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            status.Location = new Point(5, 571);
            status.Name = "status";
            status.Size = new Size(131, 17);
            status.TabIndex = 13;
            status.Text = "Trạng thái : Đã thanh toán";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(6, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 32);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(296, 12);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 9;
            label5.Text = "Thành tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(191, 13);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 8;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(113, 12);
            label3.Name = "label3";
            label3.Size = new Size(23, 17);
            label3.TabIndex = 7;
            label3.Text = "Giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 12);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 6;
            label2.Text = "Tên sản phẩm";
            // 
            // button1
            // 
            button1.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(293, 549);
            button1.Name = "button1";
            button1.Size = new Size(104, 37);
            button1.TabIndex = 15;
            button1.Text = "In Hoá đơn";
            button1.UseVisualStyleBackColor = true;
            // 
            // BillShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 614);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(status);
            Controls.Add(label1);
            Controls.Add(happy);
            Controls.Add(totalMoney);
            Controls.Add(brand);
            Controls.Add(tableNum);
            Controls.Add(productShow);
            Controls.Add(dateTime);
            Controls.Add(idBill);
            Controls.Add(customerName);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BillShow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HOÁ ĐƠN";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label customerName;
        private Label idBill;
        private Label dateTime;
        private FlowLayoutPanel productShow;
        private Label tableNum;
        private Label brand;
        private Label totalMoney;
        private Label happy;
        private Label label1;
        private Label status;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}