﻿namespace GUI
{
    partial class ProductCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCart));
            nameProduct = new Label();
            priceProduct = new Label();
            sizeProduct = new Label();
            pictureBox1 = new PictureBox();
            cateProduct = new Label();
            deleteBtn = new Button();
            countProductSell = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countProductSell).BeginInit();
            SuspendLayout();
            // 
            // nameProduct
            // 
            nameProduct.AutoSize = true;
            nameProduct.Location = new Point(58, 12);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(107, 17);
            nameProduct.TabIndex = 0;
            nameProduct.Text = "Trà đào cam sả";
            // 
            // priceProduct
            // 
            priceProduct.AutoSize = true;
            priceProduct.Location = new Point(349, 12);
            priceProduct.Name = "priceProduct";
            priceProduct.Size = new Size(67, 17);
            priceProduct.TabIndex = 1;
            priceProduct.Text = "Giá : 20K";
            // 
            // sizeProduct
            // 
            sizeProduct.AutoSize = true;
            sizeProduct.Location = new Point(191, 12);
            sizeProduct.Name = "sizeProduct";
            sizeProduct.Size = new Size(58, 17);
            sizeProduct.TabIndex = 2;
            sizeProduct.Text = "Size : M";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Ephoto360_com_16553fda5091e4;
            pictureBox1.Location = new Point(9, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // cateProduct
            // 
            cateProduct.AutoSize = true;
            cateProduct.Location = new Point(265, 12);
            cateProduct.Name = "cateProduct";
            cateProduct.Size = new Size(62, 17);
            cateProduct.TabIndex = 4;
            cateProduct.Text = "Đồ uống";
            // 
            // deleteBtn
            // 
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.Location = new Point(505, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(37, 32);
            deleteBtn.TabIndex = 5;
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // countProductSell
            // 
            countProductSell.BorderStyle = BorderStyle.None;
            countProductSell.Location = new Point(435, 11);
            countProductSell.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            countProductSell.Name = "countProductSell";
            countProductSell.Size = new Size(38, 19);
            countProductSell.TabIndex = 6;
            countProductSell.Value = new decimal(new int[] { 1, 0, 0, 0 });
            countProductSell.ValueChanged += countProductSell_ValueChanged;
            // 
            // ProductCart
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(countProductSell);
            Controls.Add(deleteBtn);
            Controls.Add(cateProduct);
            Controls.Add(pictureBox1);
            Controls.Add(sizeProduct);
            Controls.Add(priceProduct);
            Controls.Add(nameProduct);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ProductCart";
            Size = new Size(550, 41);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countProductSell).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameProduct;
        private Label priceProduct;
        private Label sizeProduct;
        private PictureBox pictureBox1;
        private Label cateProduct;
        private Button deleteBtn;
        private NumericUpDown countProductSell;
    }
}
