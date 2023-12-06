namespace GUI
{
    partial class CustomerAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerAdd));
            groupBox1 = new GroupBox();
            addressTxt = new TextBox();
            label3 = new Label();
            phoneTxt = new TextBox();
            label2 = new Label();
            customerIdTxt = new TextBox();
            label1 = new Label();
            customerNameTxt = new TextBox();
            customer = new Label();
            button1 = new Button();
            confirmBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Menu;
            groupBox1.Controls.Add(addressTxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(phoneTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(customerIdTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(customerNameTxt);
            groupBox1.Controls.Add(customer);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(-2, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 328);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÊM KHÁCH HÀNG";
            // 
            // addressTxt
            // 
            addressTxt.BackColor = SystemColors.ScrollBar;
            addressTxt.BorderStyle = BorderStyle.None;
            addressTxt.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addressTxt.Location = new Point(88, 169);
            addressTxt.Multiline = true;
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(267, 98);
            addressTxt.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 169);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 24;
            label3.Text = "Địa chỉ :";
            // 
            // phoneTxt
            // 
            phoneTxt.BackColor = SystemColors.ScrollBar;
            phoneTxt.BorderStyle = BorderStyle.None;
            phoneTxt.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTxt.Location = new Point(88, 129);
            phoneTxt.Name = "phoneTxt";
            phoneTxt.Size = new Size(267, 25);
            phoneTxt.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 129);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 22;
            label2.Text = "Điện thoại :";
            // 
            // customerIdTxt
            // 
            customerIdTxt.BackColor = SystemColors.ScrollBar;
            customerIdTxt.BorderStyle = BorderStyle.None;
            customerIdTxt.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerIdTxt.Location = new Point(88, 43);
            customerIdTxt.Name = "customerIdTxt";
            customerIdTxt.Size = new Size(267, 25);
            customerIdTxt.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 47);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 20;
            label1.Text = "Mã khách :";
            // 
            // customerNameTxt
            // 
            customerNameTxt.BackColor = SystemColors.ScrollBar;
            customerNameTxt.BorderStyle = BorderStyle.None;
            customerNameTxt.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerNameTxt.Location = new Point(88, 87);
            customerNameTxt.Name = "customerNameTxt";
            customerNameTxt.Size = new Size(267, 25);
            customerNameTxt.TabIndex = 19;
            // 
            // customer
            // 
            customer.AutoSize = true;
            customer.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customer.Location = new Point(1, 87);
            customer.Name = "customer";
            customer.Size = new Size(81, 21);
            customer.TabIndex = 18;
            customer.Text = "Khách hàng :";
            // 
            // button1
            // 
            button1.BackColor = Color.SeaShell;
            button1.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(242, 343);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(124, 50);
            button1.TabIndex = 11;
            button1.Text = "Rời bỏ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.SeaShell;
            confirmBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmBtn.Image = (Image)resources.GetObject("confirmBtn.Image");
            confirmBtn.ImageAlign = ContentAlignment.MiddleLeft;
            confirmBtn.Location = new Point(41, 346);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Padding = new Padding(20, 0, 0, 0);
            confirmBtn.Size = new Size(124, 50);
            confirmBtn.TabIndex = 10;
            confirmBtn.Text = "Xác nhận";
            confirmBtn.TextAlign = ContentAlignment.MiddleRight;
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // CustomerAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 408);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(confirmBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CustomerAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JUVENTUS SOFTWARE";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox addressTxt;
        private Label label3;
        private TextBox phoneTxt;
        private Label label2;
        private TextBox customerIdTxt;
        private Label label1;
        private TextBox customerNameTxt;
        private Label customer;
        private Button button1;
        private Button confirmBtn;
    }
}