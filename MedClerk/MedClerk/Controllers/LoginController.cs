using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClerk.Utilities;

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
            var passwordHash = Password.Hash(password);
            bool isVerified = Password.Verify(username, passwordHash);
            return isVerified ? true : false;
        }
    }
}
