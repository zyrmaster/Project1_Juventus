namespace GUI
{
    partial class BillCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillCount));
            nameBill = new Label();
            dateTime = new Label();
            tableId = new Label();
            priceTotal = new Label();
            customer = new Label();
            deleteBtn = new Button();
            infoBtn = new Button();
            SuspendLayout();
            // 
            // nameBill
            // 
            nameBill.AutoSize = true;
            nameBill.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nameBill.Location = new Point(0, 6);
            nameBill.Name = "nameBill";
            nameBill.Size = new Size(60, 21);
            nameBill.TabIndex = 19;
            nameBill.Text = "Hoá đơn :";
            // 
            // dateTime
            // 
            dateTime.AutoSize = true;
            dateTime.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTime.Location = new Point(316, 8);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(44, 21);
            dateTime.TabIndex = 20;
            dateTime.Text = "Ngày :";
            // 
            // tableId
            // 
            tableId.AutoSize = true;
            tableId.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tableId.Location = new Point(85, 8);
            tableId.Name = "tableId";
            tableId.Size = new Size(37, 21);
            tableId.TabIndex = 21;
            tableId.Text = "Bàn :";
            // 
            // priceTotal
            // 
            priceTotal.AutoSize = true;
            priceTotal.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            priceTotal.Location = new Point(198, 8);
            priceTotal.Name = "priceTotal";
            priceTotal.Size = new Size(49, 21);
            priceTotal.TabIndex = 22;
            priceTotal.Text = "Giá trị :";
            // 
            // customer
            // 
            customer.AutoSize = true;
            customer.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customer.Location = new Point(510, 8);
            customer.Name = "customer";
            customer.Size = new Size(81, 21);
            customer.TabIndex = 23;
            customer.Text = "Khách hàng :";
            // 
            // deleteBtn
            // 
            deleteBtn.FlatStyle = FlatStyle.Popup;
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.Location = new Point(709, 5);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(32, 24);
            deleteBtn.TabIndex = 24;
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // infoBtn
            // 
            infoBtn.FlatStyle = FlatStyle.Popup;
            infoBtn.Image = (Image)resources.GetObject("infoBtn.Image");
            infoBtn.Location = new Point(671, 5);
            infoBtn.Name = "infoBtn";
            infoBtn.Size = new Size(32, 24);
            infoBtn.TabIndex = 25;
            infoBtn.UseVisualStyleBackColor = true;
            infoBtn.Click += infoBtn_Click;
            // 
            // BillCount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            Controls.Add(infoBtn);
            Controls.Add(deleteBtn);
            Controls.Add(customer);
            Controls.Add(priceTotal);
            Controls.Add(tableId);
            Controls.Add(dateTime);
            Controls.Add(nameBill);
            Name = "BillCount";
            Size = new Size(747, 37);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameBill;
        private Label dateTime;
        private Label tableId;
        private Label priceTotal;
        private Label customer;
        private Button deleteBtn;
        private Button infoBtn;
    }
}
