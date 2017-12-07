using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClerk.Utilities;
using MedClerk.Models;

namespace MedClerk.Controllers
{
    class LoginController
    {
        /// <summary>
        /// Login the user identified by the given credentials
        /// </summary>
        /// <param name="username">User account username string</param>
        /// <param name="password">User plain-text password string</param>
        /// <returns>True if match found, else false</returns>
        public static Boolean Login(string username, string password)
        {
            bool isVerified; 
            //try
            //{
                var passwordHash = Password.Hash(password);
                isVerified = UserModel.Verify(username, passwordHash);
                return isVerified ? true : false;
            //}
            //catch (Exception ex)
            //{

            //}
        }

        public static void Logout(Views.MainMenu menuForm)
        {
            Views.LoginView login = new Views.LoginView();
            menuForm.Hide();
            login.Closed += (senderObj, eventArgs) => menuForm.Close();
            login.Show();
        }

        public static void LoadMenu(Views.LoginView loginForm)
        {
            Views.MainMenu menu = new Views.MainMenu();
            loginForm.Hide();
            menu.Closed += (senderObj, eventArgs) => loginForm.Close();
            menu.Show();
        }
    }
}
