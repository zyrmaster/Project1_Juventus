namespace GUI
{
    partial class ctAccountManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctAccountManager));
            accountID = new Label();
            employerName = new Label();
            employerPotision = new Label();
            LuongEmployee = new Label();
            accountIDCount = new Label();
            deleteBtn = new Button();
            settingBtn = new Button();
            SuspendLayout();
            // 
            // accountID
            // 
            accountID.AutoSize = true;
            accountID.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            accountID.Location = new Point(3, 0);
            accountID.Name = "accountID";
            accountID.Size = new Size(29, 24);
            accountID.TabIndex = 0;
            accountID.Text = "Mã";
            // 
            // employerName
            // 
            employerName.AutoSize = true;
            employerName.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            employerName.Location = new Point(67, 0);
            employerName.Name = "employerName";
            employerName.Size = new Size(32, 24);
            employerName.TabIndex = 1;
            employerName.Text = "Tên";
            // 
            // employerPotision
            // 
            employerPotision.AutoSize = true;
            employerPotision.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            employerPotision.Location = new Point(172, 2);
            employerPotision.Name = "employerPotision";
            employerPotision.Size = new Size(62, 24);
            employerPotision.TabIndex = 2;
            employerPotision.Text = "Potision";
            // 
            // LuongEmployee
            // 
            LuongEmployee.AutoSize = true;
            LuongEmployee.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LuongEmployee.Location = new Point(278, 2);
            LuongEmployee.Name = "LuongEmployee";
            LuongEmployee.Size = new Size(63, 24);
            LuongEmployee.TabIndex = 3;
            LuongEmployee.Text = "1000000";
            // 
            // accountIDCount
            // 
            accountIDCount.AutoSize = true;
            accountIDCount.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            accountIDCount.Location = new Point(380, 2);
            accountIDCount.Name = "accountIDCount";
            accountIDCount.Size = new Size(63, 24);
            accountIDCount.TabIndex = 4;
            accountIDCount.Text = "1000000";
            // 
            // deleteBtn
            // 
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.Location = new Point(586, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(29, 21);
            deleteBtn.TabIndex = 5;
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // settingBtn
            // 
            settingBtn.Image = (Image)resources.GetObject("settingBtn.Image");
            settingBtn.Location = new Point(551, 5);
            settingBtn.Name = "settingBtn";
            settingBtn.Size = new Size(29, 21);
            settingBtn.TabIndex = 6;
            settingBtn.UseVisualStyleBackColor = true;
            // 
            // ctAccountManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(settingBtn);
            Controls.Add(deleteBtn);
            Controls.Add(accountIDCount);
            Controls.Add(LuongEmployee);
            Controls.Add(employerPotision);
            Controls.Add(employerName);
            Controls.Add(accountID);
            Name = "ctAccountManager";
            Size = new Size(618, 29);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label accountID;
        private Label employerName;
        private Label employerPotision;
        private Label LuongEmployee;
        private Label accountIDCount;
        private Button deleteBtn;
        private Button settingBtn;
    }
}
