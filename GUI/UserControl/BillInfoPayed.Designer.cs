namespace GUI
{
    partial class BillInfoPayed
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
            sizeProduct = new Label();
            nameProduct = new Label();
            countQuantily = new Label();
            price = new Label();
            totalPrice = new Label();
            SuspendLayout();
            // 
            // sizeProduct
            // 
            sizeProduct.AutoSize = true;
            sizeProduct.Location = new Point(130, 5);
            sizeProduct.Name = "sizeProduct";
            sizeProduct.Size = new Size(54, 20);
            sizeProduct.TabIndex = 9;
            sizeProduct.Text = "Size : ?";
            // 
            // nameProduct
            // 
            nameProduct.AutoSize = true;
            nameProduct.Location = new Point(3, 5);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(109, 20);
            nameProduct.TabIndex = 7;
            nameProduct.Text = "Trà đào cam sả";
            // 
            // countQuantily
            // 
            countQuantily.AutoSize = true;
            countQuantily.Location = new Point(270, 5);
            countQuantily.Name = "countQuantily";
            countQuantily.Size = new Size(17, 20);
            countQuantily.TabIndex = 12;
            countQuantily.Text = "1";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(199, 5);
            price.Name = "price";
            price.Size = new Size(17, 20);
            price.TabIndex = 13;
            price.Text = "1";
            // 
            // totalPrice
            // 
            totalPrice.AutoSize = true;
            totalPrice.Location = new Point(305, 5);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(17, 20);
            totalPrice.TabIndex = 14;
            totalPrice.Text = "1";
            // 
            // BillInfoPayed
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(totalPrice);
            Controls.Add(price);
            Controls.Add(countQuantily);
            Controls.Add(sizeProduct);
            Controls.Add(nameProduct);
            Name = "BillInfoPayed";
            Size = new Size(390, 32);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label sizeProduct;
        private Label nameProduct;
        private Label countQuantily;
        private Label price;
        private Label totalPrice;
    }
}
