using MyShelf.Logic.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShelf.UI
{
    public partial class CreateMyShelfAccountForm : Form
    {
        public CreateMyShelfAccountForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void ClearFormButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            firstNameTextBox.Clear();
            addressStreetTextBox.Clear();
            phoneNumberTextBox.Clear();
            emailTextBox.Clear();
        }

        private void CreateMSClientAccount_Click(object sender, EventArgs e)
        {
            int id = 123;
            string name = string.Concat(firstNameTextBox.Text, " ", lastNameTextBox.Text);
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string address = string.Concat(addressStreetTextBox.Text, " ", addressCityTextBox.Text, " ", addressStateTextBox.Text, ",", addressZipTextBox.Text);
            string phoneNumber = phoneNumberTextBox.Text;
            string email = emailTextBox.Text;

            MSClient newMSClient = new MSClient(123, name, username, password, address, phoneNumber, email);
        }
    }
}
