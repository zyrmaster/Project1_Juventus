namespace GUI
{
    partial class ctProductSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctProductSetting));
            profileProduct = new PictureBox();
            nameProduct = new Label();
            cateSort = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)profileProduct).BeginInit();
            SuspendLayout();
            // 
            // profileProduct
            // 
            profileProduct.Image = (Image)resources.GetObject("profileProduct.Image");
            profileProduct.Location = new Point(17, 14);
            profileProduct.Name = "profileProduct";
            profileProduct.Size = new Size(112, 104);
            profileProduct.SizeMode = PictureBoxSizeMode.Zoom;
            profileProduct.TabIndex = 0;
            profileProduct.TabStop = false;
            profileProduct.Click += profileProduct_Click;
            // 
            // nameProduct
            // 
            nameProduct.AutoSize = true;
            nameProduct.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameProduct.Location = new Point(14, 133);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(66, 24);
            nameProduct.TabIndex = 1;
            nameProduct.Text = "Trà xanh";
            // 
            // cateSort
            // 
            cateSort.AutoSize = true;
            cateSort.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cateSort.Location = new Point(17, 157);
            cateSort.Name = "cateSort";
            cateSort.Size = new Size(63, 24);
            cateSort.TabIndex = 2;
            cateSort.Text = "Đồ uống";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 8);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(217, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 192);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 192);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 224, 192);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(8, 191);
            panel4.Name = "panel4";
            panel4.Size = new Size(209, 9);
            panel4.TabIndex = 7;
            // 
            // ctProductSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cateSort);
            Controls.Add(nameProduct);
            Controls.Add(profileProduct);
            Name = "ctProductSetting";
            Size = new Size(225, 200);
            Click += ctProductSetting_Click;
            ((System.ComponentModel.ISupportInitialize)profileProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox profileProduct;
        private Label nameProduct;
        private Label cateSort;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
