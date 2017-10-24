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
using MedClerk.Views;

namespace MedClerk
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(usernameTextBox.Text) || String.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("You must enter credentials into both fields!", "Missing required fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                usernameTextBox.Clear();
                passwordTextBox.Clear();
                return;
            }

            if (LoginController.Login(usernameTextBox.Text, passwordTextBox.Text))
            {
                Views.MainMenu menu = new Views.MainMenu();
                this.Hide();
                menu.Closed += (senderObj, eventArgs) => this.Close();
                menu.Show();
            } else {
                MessageBox.Show("The provided credentials cannot be verified. Please try again.", "Invalid Login!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Clear();
                passwordTextBox.Clear();
            } 
        }
    }
}
