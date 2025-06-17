namespace MyShelf.UI
{
    partial class CreateMyShelfAccountForm
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
            label1 = new Label();
            usernameTextBox = new TextBox();
            cancelButton = new Button();
            clearFormButton = new Button();
            createMSClientAccount = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            passwordTextBox = new TextBox();
            addressStreetTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            emailTextBox = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            lastNameTextBox = new TextBox();
            addressCityTextBox = new TextBox();
            label7 = new Label();
            addressStateTextBox = new TextBox();
            addressZipTextBox = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(6, 53);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(216, 27);
            usernameTextBox.TabIndex = 1;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(6, 108);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(193, 35);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // clearFormButton
            // 
            clearFormButton.Location = new Point(6, 67);
            clearFormButton.Name = "clearFormButton";
            clearFormButton.Size = new Size(193, 35);
            clearFormButton.TabIndex = 7;
            clearFormButton.Text = "Clear";
            clearFormButton.UseVisualStyleBackColor = true;
            clearFormButton.Click += ClearFormButton_Click;
            // 
            // createMSClientAccount
            // 
            createMSClientAccount.Location = new Point(6, 26);
            createMSClientAccount.Name = "createMSClientAccount";
            createMSClientAccount.Size = new Size(193, 35);
            createMSClientAccount.TabIndex = 12;
            createMSClientAccount.Text = "Create Account";
            createMSClientAccount.UseVisualStyleBackColor = true;
            createMSClientAccount.Click += CreateMSClientAccount_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 13;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 97);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 14;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 85);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 15;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 182);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 16;
            label5.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 182);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 17;
            label6.Text = "Email:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(6, 120);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(216, 27);
            passwordTextBox.TabIndex = 18;
            // 
            // addressStreetTextBox
            // 
            addressStreetTextBox.Location = new Point(6, 108);
            addressStreetTextBox.Name = "addressStreetTextBox";
            addressStreetTextBox.PlaceholderText = "Street";
            addressStreetTextBox.Size = new Size(216, 27);
            addressStreetTextBox.TabIndex = 19;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(6, 46);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(216, 27);
            firstNameTextBox.TabIndex = 20;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(228, 205);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.PlaceholderText = "(***)-***-****";
            phoneNumberTextBox.Size = new Size(216, 27);
            phoneNumberTextBox.TabIndex = 21;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(6, 205);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email@You.com";
            emailTextBox.Size = new Size(216, 27);
            emailTextBox.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(usernameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 174);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Login Info";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(addressZipTextBox);
            groupBox2.Controls.Add(addressStateTextBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(addressCityTextBox);
            groupBox2.Controls.Add(lastNameTextBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(phoneNumberTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(emailTextBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(addressStreetTextBox);
            groupBox2.Controls.Add(firstNameTextBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 249);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personal Information";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(createMSClientAccount);
            groupBox3.Controls.Add(cancelButton);
            groupBox3.Controls.Add(clearFormButton);
            groupBox3.Location = new Point(257, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(205, 174);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Menu";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(228, 46);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(216, 27);
            lastNameTextBox.TabIndex = 23;
            // 
            // addressCityTextBox
            // 
            addressCityTextBox.Location = new Point(228, 108);
            addressCityTextBox.Name = "addressCityTextBox";
            addressCityTextBox.PlaceholderText = "City";
            addressCityTextBox.Size = new Size(216, 27);
            addressCityTextBox.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(228, 23);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 25;
            label7.Text = "Last Name:";
            // 
            // addressStateTextBox
            // 
            addressStateTextBox.Location = new Point(6, 141);
            addressStateTextBox.Name = "addressStateTextBox";
            addressStateTextBox.PlaceholderText = "State";
            addressStateTextBox.Size = new Size(216, 27);
            addressStateTextBox.TabIndex = 26;
            // 
            // addressZipTextBox
            // 
            addressZipTextBox.Location = new Point(228, 141);
            addressZipTextBox.Name = "addressZipTextBox";
            addressZipTextBox.PlaceholderText = "Zip";
            addressZipTextBox.Size = new Size(216, 27);
            addressZipTextBox.TabIndex = 27;
            // 
            // CreateMyShelfAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(474, 449);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CreateMyShelfAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create My Shelf Account";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox usernameTextBox;
        private Button cancelButton;
        private Button clearFormButton;
        private Button createMSClientAccount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox passwordTextBox;
        private TextBox addressStreetTextBox;
        private TextBox firstNameTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox emailTextBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label7;
        private TextBox addressCityTextBox;
        private TextBox lastNameTextBox;
        private TextBox addressZipTextBox;
        private TextBox addressStateTextBox;
    }
}