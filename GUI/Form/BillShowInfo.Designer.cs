namespace GUI
{
    partial class BillShowInfo
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
            billFullShow = new FlowLayoutPanel();
            sortType = new ComboBox();
            groupBox2 = new GroupBox();
            customer = new Label();
            priceTotal = new Label();
            tableId = new Label();
            dateTime = new Label();
            nameBill = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // billFullShow
            // 
            billFullShow.AutoScroll = true;
            billFullShow.BorderStyle = BorderStyle.FixedSingle;
            billFullShow.Location = new Point(5, 42);
            billFullShow.Name = "billFullShow";
            billFullShow.Size = new Size(793, 403);
            billFullShow.TabIndex = 0;
            // 
            // sortType
            // 
            sortType.FormattingEnabled = true;
            sortType.Items.AddRange(new object[] { "Tất cả", "7 ngày trước", "30 ngày trước" });
            sortType.Location = new Point(649, 7);
            sortType.Name = "sortType";
            sortType.Size = new Size(113, 28);
            sortType.TabIndex = 0;
            sortType.Text = "Tất cả";
            sortType.TextChanged += sortType_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(customer);
            groupBox2.Controls.Add(priceTotal);
            groupBox2.Controls.Add(tableId);
            groupBox2.Controls.Add(dateTime);
            groupBox2.Controls.Add(nameBill);
            groupBox2.Location = new Point(5, -5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(630, 41);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // customer
            // 
            customer.AutoSize = true;
            customer.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customer.Location = new Point(505, 14);
            customer.Name = "customer";
            customer.Size = new Size(81, 21);
            customer.TabIndex = 28;
            customer.Text = "Khách hàng :";
            // 
            // priceTotal
            // 
            priceTotal.AutoSize = true;
            priceTotal.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            priceTotal.Location = new Point(214, 14);
            priceTotal.Name = "priceTotal";
            priceTotal.Size = new Size(49, 21);
            priceTotal.TabIndex = 27;
            priceTotal.Text = "Giá trị :";
            // 
            // tableId
            // 
            tableId.AutoSize = true;
            tableId.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tableId.Location = new Point(93, 14);
            tableId.Name = "tableId";
            tableId.Size = new Size(37, 21);
            tableId.TabIndex = 26;
            tableId.Text = "Bàn :";
            // 
            // dateTime
            // 
            dateTime.AutoSize = true;
            dateTime.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTime.Location = new Point(325, 14);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(44, 21);
            dateTime.TabIndex = 25;
            dateTime.Text = "Ngày :";
            // 
            // nameBill
            // 
            nameBill.AutoSize = true;
            nameBill.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nameBill.Location = new Point(6, 14);
            nameBill.Name = "nameBill";
            nameBill.Size = new Size(26, 21);
            nameBill.TabIndex = 24;
            nameBill.Text = "ID :";
            // 
            // BillShowInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 450);
            Controls.Add(groupBox2);
            Controls.Add(sortType);
            Controls.Add(billFullShow);
            Name = "BillShowInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DANH SÁCH HOÁ ĐƠN";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel billFullShow;
        private GroupBox groupBox2;
        private Label customer;
        private Label priceTotal;
        private Label tableId;
        private Label dateTime;
        private Label nameBill;
        private ComboBox sortType;
    }
}