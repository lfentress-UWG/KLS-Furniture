using KLS_Furniture.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace KLS_Furniture.View
{
    /// <summary>
    /// Represents a login form for employee authentication.
    /// </summary>
    public partial class LoginForm : Form
    {
        private MainForm mainForm;
        private readonly AuthController authController;

        /// <summary>
        /// Initializes a new instance of the LoginForm class.
        /// </summary>
        public LoginForm(AuthController authController)
        {
            this.authController = authController;

            InitializeComponent();
            ClearErrorMessage();

            this.AcceptButton = buttonLogin;
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ClearErrorMessage();

            string userName = textBoxUserName.Text.Trim();
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(userName))
            {
                labelErrorMessage.Text = "Username is required.";
                textBoxUserName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                labelErrorMessage.Text = "Password is required.";
                textBoxPassword.Focus();
                return;
            }

            bool isValid;

            try
            {
                isValid = authController.Login(userName, password);
            }
            catch (DataException)
            {
                labelErrorMessage.Text = "Database is unavailable. Please try again.";
                return;
            }
            catch (Exception)
            {
                labelErrorMessage.Text = "Unexpected error. Please try again.";
                return;
            }

            if (!isValid)
            {
                labelErrorMessage.Text = "Invalid username or password.";
                textBoxPassword.Clear();
                textBoxPassword.Focus();
                return;
            }

            if (mainForm == null || mainForm.IsDisposed)
            {
                // TODO - set contoller for main form
                mainForm = new MainForm();
                // TODO - set login form for main form
                //mainForm.SetLoginForm(this);
            }

            ResetLoginForm();

            Hide();
            mainForm.Show();
        }

        private void ClearErrorMessage()
        {
            labelErrorMessage.Text = "";
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            ClearErrorMessage();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            ClearErrorMessage();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
            base.OnFormClosing(e);
        }

        private void ResetLoginForm()
        {
            textBoxUserName.Text = "";
            textBoxPassword.Text = "";
            labelErrorMessage.Text = "";
        }
    }
}