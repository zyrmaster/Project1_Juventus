namespace GUI
{
    partial class ctCustomerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctCustomerPanel));
            customerName = new Label();
            phoneNumber = new Label();
            idCustomer = new Label();
            addresss = new Label();
            pointCustomer = new Label();
            deleteBtn = new Button();
            settingBtn = new Button();
            SuspendLayout();
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            customerName.Location = new Point(50, 9);
            customerName.Name = "customerName";
            customerName.Size = new Size(87, 17);
            customerName.TabIndex = 5;
            customerName.Text = "Tên khách hàng :";
            // 
            // phoneNumber
            // 
            phoneNumber.AutoSize = true;
            phoneNumber.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumber.Location = new Point(159, 9);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(69, 17);
            phoneNumber.TabIndex = 6;
            phoneNumber.Text = "Số điện thoại";
            // 
            // idCustomer
            // 
            idCustomer.AutoSize = true;
            idCustomer.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            idCustomer.Location = new Point(2, 9);
            idCustomer.Name = "idCustomer";
            idCustomer.Size = new Size(27, 17);
            idCustomer.TabIndex = 7;
            idCustomer.Text = "Mã :";
            // 
            // addresss
            // 
            addresss.AutoSize = true;
            addresss.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            addresss.Location = new Point(258, 9);
            addresss.Name = "addresss";
            addresss.Size = new Size(40, 17);
            addresss.TabIndex = 8;
            addresss.Text = "Địa chỉ";
            // 
            // pointCustomer
            // 
            pointCustomer.AutoSize = true;
            pointCustomer.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            pointCustomer.Location = new Point(501, 9);
            pointCustomer.Name = "pointCustomer";
            pointCustomer.Size = new Size(31, 17);
            pointCustomer.TabIndex = 9;
            pointCustomer.Text = "Điểm";
            // 
            // deleteBtn
            // 
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.Location = new Point(626, 2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(30, 29);
            deleteBtn.TabIndex = 10;
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // settingBtn
            // 
            settingBtn.Image = (Image)resources.GetObject("settingBtn.Image");
            settingBtn.Location = new Point(590, 2);
            settingBtn.Name = "settingBtn";
            settingBtn.Size = new Size(30, 29);
            settingBtn.TabIndex = 11;
            settingBtn.UseVisualStyleBackColor = true;
            settingBtn.Click += settingBtn_Click;
            // 
            // ctCustomerPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(settingBtn);
            Controls.Add(deleteBtn);
            Controls.Add(pointCustomer);
            Controls.Add(addresss);
            Controls.Add(idCustomer);
            Controls.Add(phoneNumber);
            Controls.Add(customerName);
            Name = "ctCustomerPanel";
            Size = new Size(660, 36);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customerName;
        private Label phoneNumber;
        private Label idCustomer;
        private Label addresss;
        private Label pointCustomer;
        private Button deleteBtn;
        private Button settingBtn;
    }
}
