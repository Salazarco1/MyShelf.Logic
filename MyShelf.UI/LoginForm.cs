using MyShelf.Logic.Users;

namespace MyShelf.UI
{
    public partial class LoginForm : Form
    {
        //private readonly UnitOfWork _unitOfWork { get; set; }
        private MSClient Testclient = new MSClient(1234, "Test Client", "TestClient", "TestClientPassword", "1234 s 5678 w", "123-456-7890", "Email@You.com");
        public LoginForm()
        {
            InitializeComponent();
            passwordTextBox.UseSystemPasswordChar = true;
            userNameTextBox.Text = "TestClient";
            passwordTextBox.Text = "TestClientPassword";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text != null && passwordTextBox.Text != null)
            {
                var validClient = ValidateLoginAttempt(userNameTextBox.Text, passwordTextBox.Text);

                if (validClient != null)
                {
                    MyShelfHomePageForm homePageForm = new MyShelfHomePageForm(validClient);
                    homePageForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private MSClient ValidateLoginAttempt(string username, string password)
        {
            if (username != null && password != null)
            {
                //impliment unit of work here to validate login attempt
                if (username == Testclient.Username && password == Testclient.Password)
                {
                    return Testclient;
                }
            }
            return null;
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            CreateMyShelfAccountForm createAccountForm = new CreateMyShelfAccountForm();
            createAccountForm.Show();
            this.Hide();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(showPasswordCheckBox.Checked == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
