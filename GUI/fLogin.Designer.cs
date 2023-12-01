namespace GUI
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            login_label = new Label();
            name_label = new Label();
            username_label = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            password_Label = new Label();
            ShowPasscheckBox = new CheckBox();
            SavePassCheckBox = new CheckBox();
            LoginButton = new Button();
            FailShowButton = new Button();
            RequestLabelLink = new LinkLabel();
            decLabel = new Label();
            WebLabel = new Label();
            SuspendLayout();
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Font = new Font("Bahnschrift Light Condensed", 40F, FontStyle.Regular, GraphicsUnit.Point);
            login_label.ForeColor = Color.Black;
            login_label.Location = new Point(134, 29);
            login_label.Name = "login_label";
            login_label.Size = new Size(153, 81);
            login_label.TabIndex = 0;
            login_label.Text = "Login";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name_label.ForeColor = Color.Black;
            name_label.Location = new Point(224, 96);
            name_label.Name = "name_label";
            name_label.Size = new Size(133, 24);
            name_label.TabIndex = 1;
            name_label.Text = "Juventus Software";
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username_label.ForeColor = SystemColors.ActiveCaptionText;
            username_label.Location = new Point(23, 182);
            username_label.Name = "username_label";
            username_label.Size = new Size(76, 24);
            username_label.TabIndex = 2;
            username_label.Text = "Username";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.ForeColor = SystemColors.ActiveCaptionText;
            usernameTextBox.Location = new Point(53, 217);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(298, 32);
            usernameTextBox.TabIndex = 3;
            usernameTextBox.Text = "Tên đăng nhập...";
            usernameTextBox.Click += usernameTextBox_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.ForeColor = SystemColors.ActiveCaptionText;
            passwordTextBox.Location = new Point(53, 298);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(298, 32);
            passwordTextBox.TabIndex = 5;
            passwordTextBox.Text = "PasswordLogin";
            passwordTextBox.Click += passwordTextBox_Click;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // password_Label
            // 
            password_Label.AutoSize = true;
            password_Label.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password_Label.ForeColor = SystemColors.ActiveCaptionText;
            password_Label.Location = new Point(23, 263);
            password_Label.Name = "password_Label";
            password_Label.Size = new Size(74, 24);
            password_Label.TabIndex = 4;
            password_Label.Text = "Password";
            // 
            // ShowPasscheckBox
            // 
            ShowPasscheckBox.AutoSize = true;
            ShowPasscheckBox.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShowPasscheckBox.Location = new Point(224, 263);
            ShowPasscheckBox.Name = "ShowPasscheckBox";
            ShowPasscheckBox.Size = new Size(126, 28);
            ShowPasscheckBox.TabIndex = 6;
            ShowPasscheckBox.Text = "Hiện mật khẩu";
            ShowPasscheckBox.UseVisualStyleBackColor = true;
            ShowPasscheckBox.CheckedChanged += ShowPasscheckBox_CheckedChanged;
            // 
            // SavePassCheckBox
            // 
            SavePassCheckBox.AutoSize = true;
            SavePassCheckBox.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SavePassCheckBox.Location = new Point(53, 353);
            SavePassCheckBox.Name = "SavePassCheckBox";
            SavePassCheckBox.Size = new Size(118, 28);
            SavePassCheckBox.TabIndex = 7;
            SavePassCheckBox.Text = "Lưu thông tin";
            SavePassCheckBox.UseVisualStyleBackColor = true;
            SavePassCheckBox.CheckedChanged += SavePassCheckBox_CheckedChanged;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(53, 403);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(108, 38);
            LoginButton.TabIndex = 8;
            LoginButton.Text = "Đăng nhập";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // FailShowButton
            // 
            FailShowButton.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FailShowButton.Location = new Point(206, 404);
            FailShowButton.Name = "FailShowButton";
            FailShowButton.Size = new Size(108, 38);
            FailShowButton.TabIndex = 9;
            FailShowButton.Text = "Báo Lỗi";
            FailShowButton.UseVisualStyleBackColor = true;
            FailShowButton.Click += FailShowButton_Click;
            // 
            // RequestLabelLink
            // 
            RequestLabelLink.AutoSize = true;
            RequestLabelLink.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RequestLabelLink.Location = new Point(286, 509);
            RequestLabelLink.Name = "RequestLabelLink";
            RequestLabelLink.Size = new Size(118, 21);
            RequestLabelLink.TabIndex = 10;
            RequestLabelLink.TabStop = true;
            RequestLabelLink.Text = "Hướng dẫn sử dụng";
            // 
            // decLabel
            // 
            decLabel.AutoSize = true;
            decLabel.Font = new Font("Bahnschrift Light Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            decLabel.Location = new Point(50, 474);
            decLabel.Name = "decLabel";
            decLabel.Size = new Size(310, 24);
            decLabel.TabIndex = 11;
            decLabel.Text = "Phát triển và vận hành bởi Juventus Software";
            // 
            // WebLabel
            // 
            WebLabel.AutoSize = true;
            WebLabel.Font = new Font("Bahnschrift Light Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            WebLabel.Location = new Point(0, 506);
            WebLabel.Name = "WebLabel";
            WebLabel.Size = new Size(186, 21);
            WebLabel.TabIndex = 12;
            WebLabel.Text = "Website : juventussoftware.com";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(400, 530);
            Controls.Add(WebLabel);
            Controls.Add(decLabel);
            Controls.Add(RequestLabelLink);
            Controls.Add(FailShowButton);
            Controls.Add(LoginButton);
            Controls.Add(SavePassCheckBox);
            Controls.Add(ShowPasscheckBox);
            Controls.Add(passwordTextBox);
            Controls.Add(password_Label);
            Controls.Add(usernameTextBox);
            Controls.Add(username_label);
            Controls.Add(name_label);
            Controls.Add(login_label);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += fLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label login_label;
        private Label name_label;
        private Label username_label;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label password_Label;
        private CheckBox ShowPasscheckBox;
        private CheckBox SavePassCheckBox;
        private Button LoginButton;
        private Button FailShowButton;
        private LinkLabel RequestLabelLink;
        private Label decLabel;
        private Label WebLabel;
    }
}