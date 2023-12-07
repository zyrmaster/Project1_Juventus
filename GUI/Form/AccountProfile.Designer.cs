namespace GUI
{
    partial class AccountProfile
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            rePassword = new TextBox();
            label6 = new Label();
            newPassword = new TextBox();
            label5 = new Label();
            passwordAccount = new TextBox();
            label4 = new Label();
            usernameAccount = new TextBox();
            label3 = new Label();
            displayNameAccount = new TextBox();
            label2 = new Label();
            idAccount = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            EmployeeAccountID = new TextBox();
            label8 = new Label();
            salaryEmployee = new TextBox();
            label9 = new Label();
            potisionEmployee = new TextBox();
            label10 = new Label();
            displayEmployee = new TextBox();
            label11 = new Label();
            IDEmployee = new TextBox();
            label12 = new Label();
            groupBox3 = new GroupBox();
            roleName = new TextBox();
            label13 = new Label();
            roleId = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(rePassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(newPassword);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(passwordAccount);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(usernameAccount);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(displayNameAccount);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(idAccount);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(13, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 353);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN";
            // 
            // button2
            // 
            button2.Location = new Point(212, 288);
            button2.Name = "button2";
            button2.Size = new Size(145, 43);
            button2.TabIndex = 13;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(36, 288);
            button1.Name = "button1";
            button1.Size = new Size(145, 43);
            button1.TabIndex = 12;
            button1.Text = "Đổi mật khẩu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rePassword
            // 
            rePassword.BorderStyle = BorderStyle.FixedSingle;
            rePassword.Location = new Point(141, 225);
            rePassword.Name = "rePassword";
            rePassword.Size = new Size(206, 32);
            rePassword.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 229);
            label6.Name = "label6";
            label6.Size = new Size(71, 24);
            label6.TabIndex = 10;
            label6.Text = "Nhập lại :";
            // 
            // newPassword
            // 
            newPassword.BorderStyle = BorderStyle.FixedSingle;
            newPassword.Location = new Point(141, 187);
            newPassword.Name = "newPassword";
            newPassword.Size = new Size(206, 32);
            newPassword.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 191);
            label5.Name = "label5";
            label5.Size = new Size(106, 24);
            label5.TabIndex = 8;
            label5.Text = "Mật khẩu mới :";
            // 
            // passwordAccount
            // 
            passwordAccount.BorderStyle = BorderStyle.FixedSingle;
            passwordAccount.Location = new Point(141, 149);
            passwordAccount.Name = "passwordAccount";
            passwordAccount.PasswordChar = '*';
            passwordAccount.Size = new Size(206, 32);
            passwordAccount.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 153);
            label4.Name = "label4";
            label4.Size = new Size(77, 24);
            label4.TabIndex = 6;
            label4.Text = "Mật khẩu :";
            // 
            // usernameAccount
            // 
            usernameAccount.BorderStyle = BorderStyle.FixedSingle;
            usernameAccount.Enabled = false;
            usernameAccount.Location = new Point(141, 111);
            usernameAccount.Name = "usernameAccount";
            usernameAccount.Size = new Size(206, 32);
            usernameAccount.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 115);
            label3.Name = "label3";
            label3.Size = new Size(79, 24);
            label3.TabIndex = 4;
            label3.Text = "Tài khoản :";
            // 
            // displayNameAccount
            // 
            displayNameAccount.BorderStyle = BorderStyle.FixedSingle;
            displayNameAccount.Enabled = false;
            displayNameAccount.Location = new Point(141, 73);
            displayNameAccount.Name = "displayNameAccount";
            displayNameAccount.Size = new Size(206, 32);
            displayNameAccount.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 77);
            label2.Name = "label2";
            label2.Size = new Size(92, 24);
            label2.TabIndex = 2;
            label2.Text = "Tên hiển thị :";
            // 
            // idAccount
            // 
            idAccount.BorderStyle = BorderStyle.FixedSingle;
            idAccount.Enabled = false;
            idAccount.Location = new Point(141, 37);
            idAccount.Name = "idAccount";
            idAccount.Size = new Size(57, 32);
            idAccount.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 39);
            label1.Name = "label1";
            label1.Size = new Size(36, 24);
            label1.TabIndex = 0;
            label1.Text = "Mã :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(EmployeeAccountID);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(salaryEmployee);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(potisionEmployee);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(displayEmployee);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(IDEmployee);
            groupBox2.Controls.Add(label12);
            groupBox2.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(423, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 230);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "NHÂN VIÊN";
            // 
            // EmployeeAccountID
            // 
            EmployeeAccountID.BorderStyle = BorderStyle.FixedSingle;
            EmployeeAccountID.Enabled = false;
            EmployeeAccountID.Location = new Point(132, 191);
            EmployeeAccountID.Name = "EmployeeAccountID";
            EmployeeAccountID.Size = new Size(206, 32);
            EmployeeAccountID.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 195);
            label8.Name = "label8";
            label8.Size = new Size(101, 24);
            label8.TabIndex = 20;
            label8.Text = "Mã tài khoản :";
            // 
            // salaryEmployee
            // 
            salaryEmployee.BorderStyle = BorderStyle.FixedSingle;
            salaryEmployee.Enabled = false;
            salaryEmployee.Location = new Point(132, 153);
            salaryEmployee.Name = "salaryEmployee";
            salaryEmployee.Size = new Size(206, 32);
            salaryEmployee.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 157);
            label9.Name = "label9";
            label9.Size = new Size(57, 24);
            label9.TabIndex = 18;
            label9.Text = "Lương :";
            // 
            // potisionEmployee
            // 
            potisionEmployee.BorderStyle = BorderStyle.FixedSingle;
            potisionEmployee.Enabled = false;
            potisionEmployee.Location = new Point(132, 115);
            potisionEmployee.Name = "potisionEmployee";
            potisionEmployee.Size = new Size(206, 32);
            potisionEmployee.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 119);
            label10.Name = "label10";
            label10.Size = new Size(70, 24);
            label10.TabIndex = 16;
            label10.Text = "Chức vụ :";
            // 
            // displayEmployee
            // 
            displayEmployee.BorderStyle = BorderStyle.FixedSingle;
            displayEmployee.Enabled = false;
            displayEmployee.Location = new Point(132, 77);
            displayEmployee.Name = "displayEmployee";
            displayEmployee.Size = new Size(206, 32);
            displayEmployee.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 81);
            label11.Name = "label11";
            label11.Size = new Size(92, 24);
            label11.TabIndex = 14;
            label11.Text = "Tên hiển thị :";
            // 
            // IDEmployee
            // 
            IDEmployee.BorderStyle = BorderStyle.FixedSingle;
            IDEmployee.Enabled = false;
            IDEmployee.Location = new Point(132, 41);
            IDEmployee.Name = "IDEmployee";
            IDEmployee.Size = new Size(57, 32);
            IDEmployee.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 43);
            label12.Name = "label12";
            label12.Size = new Size(36, 24);
            label12.TabIndex = 12;
            label12.Text = "Mã :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(roleName);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(roleId);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(426, 244);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(342, 122);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "ROLE";
            // 
            // roleName
            // 
            roleName.BorderStyle = BorderStyle.FixedSingle;
            roleName.Enabled = false;
            roleName.Location = new Point(153, 79);
            roleName.Name = "roleName";
            roleName.Size = new Size(158, 32);
            roleName.TabIndex = 25;
            roleName.Text = "Loại tài khoản";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 79);
            label13.Name = "label13";
            label13.Size = new Size(109, 24);
            label13.TabIndex = 24;
            label13.Text = "Loại tài khoản :";
            // 
            // roleId
            // 
            roleId.BorderStyle = BorderStyle.FixedSingle;
            roleId.Enabled = false;
            roleId.Location = new Point(153, 31);
            roleId.Name = "roleId";
            roleId.Size = new Size(158, 32);
            roleId.TabIndex = 23;
            roleId.TextChanged += textBox7_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 33);
            label7.Name = "label7";
            label7.Size = new Size(36, 24);
            label7.TabIndex = 22;
            label7.Text = "Mã :";
            // 
            // AccountProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 375);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ TÀI KHOẢN";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox idAccount;
        private Button button1;
        private TextBox rePassword;
        private Label label6;
        private TextBox newPassword;
        private Label label5;
        private TextBox passwordAccount;
        private Label label4;
        private TextBox usernameAccount;
        private Label label3;
        private TextBox displayNameAccount;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox EmployeeAccountID;
        private Label label8;
        private TextBox salaryEmployee;
        private Label label9;
        private TextBox potisionEmployee;
        private Label label10;
        private TextBox displayEmployee;
        private Label label11;
        private TextBox IDEmployee;
        private Label label12;
        private GroupBox groupBox3;
        private TextBox roleId;
        private Label label7;
        private Button button2;
        private TextBox roleName;
        private Label label13;
    }
}