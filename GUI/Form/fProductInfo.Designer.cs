﻿namespace GUI
{
    partial class fProductInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProductInfo));
            panel1 = new Panel();
            label2 = new Label();
            priceProductTxt = new NumericUpDown();
            priceProduct = new Label();
            sizeProductTxt = new ComboBox();
            label1 = new Label();
            cateProductTxt = new ComboBox();
            cateProduct = new Label();
            nameProductTxt = new TextBox();
            nameProduct = new Label();
            idProductTxt = new TextBox();
            idSp = new Label();
            titleProduct = new Label();
            deleteBtn = new Button();
            saveBtn = new Button();
            exitBtn = new Button();
            addBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceProductTxt).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(priceProductTxt);
            panel1.Controls.Add(priceProduct);
            panel1.Controls.Add(sizeProductTxt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cateProductTxt);
            panel1.Controls.Add(cateProduct);
            panel1.Controls.Add(nameProductTxt);
            panel1.Controls.Add(nameProduct);
            panel1.Controls.Add(idProductTxt);
            panel1.Controls.Add(idSp);
            panel1.Location = new Point(8, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 362);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(316, 281);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 15;
            label2.Text = "Nghìn VNĐ";
            // 
            // priceProductTxt
            // 
            priceProductTxt.BorderStyle = BorderStyle.None;
            priceProductTxt.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceProductTxt.Location = new Point(108, 279);
            priceProductTxt.Name = "priceProductTxt";
            priceProductTxt.Size = new Size(206, 28);
            priceProductTxt.TabIndex = 12;
            // 
            // priceProduct
            // 
            priceProduct.AutoSize = true;
            priceProduct.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceProduct.Location = new Point(6, 277);
            priceProduct.Name = "priceProduct";
            priceProduct.Size = new Size(60, 24);
            priceProduct.TabIndex = 10;
            priceProduct.Text = "Giá tiền";
            // 
            // sizeProductTxt
            // 
            sizeProductTxt.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sizeProductTxt.FormattingEnabled = true;
            sizeProductTxt.Items.AddRange(new object[] { "S", "M", "L", "Khác" });
            sizeProductTxt.Location = new Point(110, 217);
            sizeProductTxt.Name = "sizeProductTxt";
            sizeProductTxt.Size = new Size(108, 32);
            sizeProductTxt.TabIndex = 9;
            sizeProductTxt.Text = "Size";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 217);
            label1.Name = "label1";
            label1.Size = new Size(59, 24);
            label1.TabIndex = 6;
            label1.Text = "Kích cỡ";
            // 
            // cateProductTxt
            // 
            cateProductTxt.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cateProductTxt.FormattingEnabled = true;
            cateProductTxt.Items.AddRange(new object[] { "Đồ uống", "Đồ ăn", "Dịch vụ" });
            cateProductTxt.Location = new Point(110, 163);
            cateProductTxt.Name = "cateProductTxt";
            cateProductTxt.Size = new Size(278, 32);
            cateProductTxt.TabIndex = 5;
            cateProductTxt.Text = "Chọn loại";
            // 
            // cateProduct
            // 
            cateProduct.AutoSize = true;
            cateProduct.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cateProduct.Location = new Point(6, 163);
            cateProduct.Name = "cateProduct";
            cateProduct.Size = new Size(72, 24);
            cateProduct.TabIndex = 4;
            cateProduct.Text = "Phân loại";
            // 
            // nameProductTxt
            // 
            nameProductTxt.BorderStyle = BorderStyle.None;
            nameProductTxt.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameProductTxt.Location = new Point(107, 115);
            nameProductTxt.Name = "nameProductTxt";
            nameProductTxt.Size = new Size(278, 25);
            nameProductTxt.TabIndex = 3;
            // 
            // nameProduct
            // 
            nameProduct.AutoSize = true;
            nameProduct.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameProduct.Location = new Point(3, 111);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(100, 24);
            nameProduct.TabIndex = 2;
            nameProduct.Text = "Tên sản phẩm";
            // 
            // idProductTxt
            // 
            idProductTxt.BorderStyle = BorderStyle.None;
            idProductTxt.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idProductTxt.Location = new Point(109, 54);
            idProductTxt.Name = "idProductTxt";
            idProductTxt.Size = new Size(278, 25);
            idProductTxt.TabIndex = 1;
            // 
            // idSp
            // 
            idSp.AutoSize = true;
            idSp.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idSp.Location = new Point(5, 50);
            idSp.Name = "idSp";
            idSp.Size = new Size(97, 24);
            idSp.TabIndex = 0;
            idSp.Text = "Mã sản phẩm";
            // 
            // titleProduct
            // 
            titleProduct.AutoSize = true;
            titleProduct.Font = new Font("Bahnschrift Light Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            titleProduct.Location = new Point(99, 9);
            titleProduct.Name = "titleProduct";
            titleProduct.Size = new Size(221, 41);
            titleProduct.TabIndex = 1;
            titleProduct.Text = "Quản lý sản phẩm";
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Tomato;
            deleteBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteBtn.Location = new Point(256, 451);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Padding = new Padding(20, 0, 0, 0);
            deleteBtn.Size = new Size(137, 50);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Xóa";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Visible = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.LightSeaGreen;
            saveBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.Image = (Image)resources.GetObject("saveBtn.Image");
            saveBtn.ImageAlign = ContentAlignment.MiddleLeft;
            saveBtn.Location = new Point(42, 451);
            saveBtn.Name = "saveBtn";
            saveBtn.Padding = new Padding(20, 0, 0, 0);
            saveBtn.Size = new Size(137, 50);
            saveBtn.TabIndex = 7;
            saveBtn.Text = "Lưu";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Visible = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Tomato;
            exitBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtn.Image = (Image)resources.GetObject("exitBtn.Image");
            exitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            exitBtn.Location = new Point(244, 451);
            exitBtn.Name = "exitBtn";
            exitBtn.Padding = new Padding(20, 0, 0, 0);
            exitBtn.Size = new Size(137, 50);
            exitBtn.TabIndex = 8;
            exitBtn.Text = "Hủy";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Visible = false;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.SpringGreen;
            addBtn.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.Image = (Image)resources.GetObject("addBtn.Image");
            addBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addBtn.Location = new Point(42, 451);
            addBtn.Name = "addBtn";
            addBtn.Padding = new Padding(20, 0, 0, 0);
            addBtn.Size = new Size(137, 50);
            addBtn.TabIndex = 9;
            addBtn.Text = "Thêm";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Visible = false;
            addBtn.Click += addBtn_Click;
            // 
            // fProductInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(424, 530);
            Controls.Add(addBtn);
            Controls.Add(exitBtn);
            Controls.Add(saveBtn);
            Controls.Add(deleteBtn);
            Controls.Add(titleProduct);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fProductInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceProductTxt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label idSp;
        private Label titleProduct;
        private TextBox idProductTxt;
        private Label label1;
        private ComboBox cateProductTxt;
        private Label cateProduct;
        private TextBox nameProductTxt;
        private Label nameProduct;
        private NumericUpDown priceProductTxt;
        private Label priceProduct;
        private ComboBox sizeProductTxt;
        private Button deleteBtn;
        private Button saveBtn;
        private Button exitBtn;
        private Button addBtn;
        private Label label2;
    }
}