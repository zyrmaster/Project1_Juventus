namespace GUI
{
    partial class ProductSell
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
            pictureBox1 = new PictureBox();
            nameProduct = new Label();
            priceProduct = new Label();
            sizeProduct = new Label();
            cateSort = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Ephoto360_com_16553fda5091e4;
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // nameProduct
            // 
            nameProduct.AutoSize = true;
            nameProduct.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nameProduct.Location = new Point(1, 64);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(93, 21);
            nameProduct.TabIndex = 16;
            nameProduct.Text = "Trà đào cam sả";
            // 
            // priceProduct
            // 
            priceProduct.AutoSize = true;
            priceProduct.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            priceProduct.Location = new Point(0, 44);
            priceProduct.Name = "priceProduct";
            priceProduct.Size = new Size(58, 21);
            priceProduct.TabIndex = 17;
            priceProduct.Text = "Giá : 20K";
            // 
            // sizeProduct
            // 
            sizeProduct.AutoSize = true;
            sizeProduct.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sizeProduct.Location = new Point(52, 21);
            sizeProduct.Name = "sizeProduct";
            sizeProduct.Size = new Size(51, 21);
            sizeProduct.TabIndex = 18;
            sizeProduct.Text = "Size : M";
            // 
            // cateSort
            // 
            cateSort.AutoSize = true;
            cateSort.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cateSort.Location = new Point(52, 0);
            cateSort.Name = "cateSort";
            cateSort.Size = new Size(54, 21);
            cateSort.TabIndex = 19;
            cateSort.Text = "Đồ uống";
            // 
            // ProductSell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(cateSort);
            Controls.Add(sizeProduct);
            Controls.Add(priceProduct);
            Controls.Add(nameProduct);
            Controls.Add(pictureBox1);
            Name = "ProductSell";
            Size = new Size(134, 86);
            MouseDoubleClick += ProductSell_MouseDoubleClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label nameProduct;
        private Label priceProduct;
        private Label sizeProduct;
        private Label cateSort;
    }
}
