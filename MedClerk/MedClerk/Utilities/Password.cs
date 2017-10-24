using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MedClerk.Database;
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

        /// <summary>
        /// Verifies a user with matching password exists in the database
        /// </summary>
        /// <param name="username">User account username string</param>
        /// <param name="passwordHash">Hashed user password string</param>
        /// <returns>True if match exists, else false</returns>
        public static Boolean Verify(string username, string passwordHash)
        {
            var connection = Properties.Settings.Default.DBSource;
            var sql = String.Format("SELECT [User].Username FROM dbo.[User] " +
                                    "WHERE Username = '{0}' AND " +
                                    "PasswordHash = '{1}';", username, passwordHash);
            var database = new DatabaseManager(connection);

            database.OpenConnection();
            var results = database.ExecuteQuery(sql);
            database.CloseConnection();


            try {
                DataTable table = results.Tables[0];
                var user = table.Rows[0].ItemArray.GetValue(0).ToString();
                // TODO: Remove magic numbers
                if (user == username) { return true; } else { return false; }

            } catch (IndexOutOfRangeException) {
                return false;
            } catch (Exception) {
                return false;
            }
        }
    }
}