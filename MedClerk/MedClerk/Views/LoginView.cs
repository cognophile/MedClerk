using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedClerk.Controllers;

namespace MedClerk.Views
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            this.enterButton.Enabled = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (LoginController.Login(usernameTextBox.Text, passwordTextBox.Text))
            {
                LoginController.LoadMenu(this);

            } else {
                MessageBox.Show("The provided credentials cannot be verified. Please try again.", "Invalid Login!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Clear();
                passwordTextBox.Clear();
            } 
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.usernameTextBox.Text) && !String.IsNullOrWhiteSpace(this.passwordTextBox.Text))
            {
                this.enterButton.Enabled = true;
                return;
            }

            this.enterButton.Enabled = false;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.passwordTextBox.Text) && !String.IsNullOrWhiteSpace(this.usernameTextBox.Text))
            {
                this.enterButton.Enabled = true;
                return;
            }

            this.enterButton.Enabled = false;
        }
    }
}
