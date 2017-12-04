using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;

namespace MedClerk.Utilities
{
    class Password
    {
        /// <summary>
        /// Will generate an MD5 hash of provided password string 
        /// </summary>
        /// <param name="password">The password string to hash</param>
        /// <returns>String of MD5 hash</returns>
        public static string Hash(string password)
        {
            if (String.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException();
            }

            using (MD5 Md5 = MD5.Create())
            {
                var bytes = new UTF8Encoding().GetBytes(password);
                var hashBytes = Md5.ComputeHash(bytes);

                var hexidecimalHash = BitConverter.ToString(hashBytes);
                return hexidecimalHash.ToLower().Replace("-", "");
            }
        }
    }
}