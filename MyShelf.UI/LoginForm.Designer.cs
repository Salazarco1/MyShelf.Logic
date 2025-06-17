namespace MyShelf.UI
{
    partial class LoginForm
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
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            createAccountButton = new Button();
            label4 = new Label();
            showPasswordCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(55, 88);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(194, 27);
            userNameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(55, 163);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(194, 27);
            passwordTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(97, 246);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(101, 33);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 65);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 140);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Password:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 9);
            label3.Name = "label3";
            label3.Size = new Size(260, 35);
            label3.TabIndex = 5;
            label3.Text = "Welcome To My Shelf!";
            // 
            // createAccountButton
            // 
            createAccountButton.Location = new Point(75, 305);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(148, 33);
            createAccountButton.TabIndex = 6;
            createAccountButton.Text = "Create Account";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += CreateAccountButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 282);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 7;
            label4.Text = "Or";
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            showPasswordCheckBox.Location = new Point(138, 196);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.RightToLeft = RightToLeft.Yes;
            showPasswordCheckBox.Size = new Size(111, 19);
            showPasswordCheckBox.TabIndex = 9;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(321, 350);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(label4);
            Controls.Add(createAccountButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button createAccountButton;
        private Label label4;
        private CheckBox showPasswordCheckBox;
    }
}
