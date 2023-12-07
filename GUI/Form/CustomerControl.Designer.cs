namespace GUI
{
    partial class CustomerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerControl));
            customerPanel = new FlowLayoutPanel();
            listCustomerBtn = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            nameFind = new TextBox();
            refersh = new Button();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            idCustomer = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // customerPanel
            // 
            customerPanel.AutoScroll = true;
            customerPanel.Location = new Point(5, 41);
            customerPanel.Name = "customerPanel";
            customerPanel.Size = new Size(679, 406);
            customerPanel.TabIndex = 0;
            // 
            // listCustomerBtn
            // 
            listCustomerBtn.BackColor = Color.SeaShell;
            listCustomerBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listCustomerBtn.Image = (Image)resources.GetObject("listCustomerBtn.Image");
            listCustomerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            listCustomerBtn.Location = new Point(16, 40);
            listCustomerBtn.Name = "listCustomerBtn";
            listCustomerBtn.Padding = new Padding(20, 0, 0, 0);
            listCustomerBtn.Size = new Size(156, 49);
            listCustomerBtn.TabIndex = 7;
            listCustomerBtn.Text = "Thêm";
            listCustomerBtn.UseVisualStyleBackColor = false;
            listCustomerBtn.Click += listCustomerBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(refersh);
            groupBox1.Controls.Add(listCustomerBtn);
            groupBox1.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(690, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(192, 446);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "CHỨC NĂNG";
            // 
            // button1
            // 
            button1.BackColor = Color.SeaShell;
            button1.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(16, 388);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(156, 49);
            button1.TabIndex = 10;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(nameFind);
            groupBox2.Location = new Point(10, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(171, 221);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Kiếm";
            // 
            // nameFind
            // 
            nameFind.Location = new Point(14, 47);
            nameFind.Name = "nameFind";
            nameFind.Size = new Size(144, 32);
            nameFind.TabIndex = 0;
            nameFind.Text = "Nhập tên để tìm kiếm";
            nameFind.Click += nameFind_Click;
            nameFind.TextChanged += nameFind_TextChanged;
            // 
            // refersh
            // 
            refersh.BackColor = Color.SeaShell;
            refersh.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            refersh.Image = (Image)resources.GetObject("refersh.Image");
            refersh.ImageAlign = ContentAlignment.MiddleLeft;
            refersh.Location = new Point(16, 106);
            refersh.Name = "refersh";
            refersh.Padding = new Padding(20, 0, 0, 0);
            refersh.Size = new Size(156, 49);
            refersh.TabIndex = 8;
            refersh.Text = "Làm mới";
            refersh.UseVisualStyleBackColor = false;
            refersh.Click += refersh_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(idCustomer);
            groupBox3.Location = new Point(5, -7);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(679, 47);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(575, 20);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 8;
            label5.Text = "Chức năng :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(496, 20);
            label4.Name = "label4";
            label4.Size = new Size(36, 17);
            label4.TabIndex = 10;
            label4.Text = "Điểm :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(276, 20);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 9;
            label3.Text = "Địa chỉ :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(155, 20);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 8;
            label2.Text = "Số điện thoại :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 20);
            label1.Name = "label1";
            label1.Size = new Size(87, 17);
            label1.TabIndex = 7;
            label1.Text = "Tên khách hàng :";
            // 
            // idCustomer
            // 
            idCustomer.AutoSize = true;
            idCustomer.Font = new Font("Bahnschrift Light Condensed", 8F, FontStyle.Regular, GraphicsUnit.Point);
            idCustomer.Location = new Point(6, 21);
            idCustomer.Name = "idCustomer";
            idCustomer.Size = new Size(22, 17);
            idCustomer.TabIndex = 6;
            idCustomer.Text = "ID :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 32);
            textBox1.TabIndex = 1;
            textBox1.Text = "Nhập địa chỉ tìm kiếm";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // CustomerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(customerPanel);
            Name = "CustomerControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DANH SÁCH KHÁCH HÀNG";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel customerPanel;
        private Button listCustomerBtn;
        private GroupBox groupBox1;
        private Button refersh;
        private GroupBox groupBox2;
        private TextBox nameFind;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label idCustomer;
        private Label label5;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
    }
}