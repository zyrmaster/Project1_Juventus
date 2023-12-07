namespace GUI
{
    partial class BillHistory
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
            billName = new Label();
            customerName = new Label();
            tableId = new Label();
            SuspendLayout();
            // 
            // billName
            // 
            billName.AutoSize = true;
            billName.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            billName.Location = new Point(2, 2);
            billName.Name = "billName";
            billName.Size = new Size(72, 24);
            billName.TabIndex = 0;
            billName.Text = "Hoá Đơn 1";
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerName.Location = new Point(2, 39);
            customerName.Name = "customerName";
            customerName.Size = new Size(109, 24);
            customerName.TabIndex = 1;
            customerName.Text = "Phạm Tiến Đức";
            // 
            // tableId
            // 
            tableId.AutoSize = true;
            tableId.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tableId.Location = new Point(106, 2);
            tableId.Name = "tableId";
            tableId.Size = new Size(50, 24);
            tableId.TabIndex = 2;
            tableId.Text = "Bàn : 1";
            // 
            // BillHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableId);
            Controls.Add(customerName);
            Controls.Add(billName);
            Name = "BillHistory";
            Size = new Size(172, 66);
            Load += BillHistory_Load;
            Click += BillHistory_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label billName;
        private Label customerName;
        private Label tableId;
    }
}
