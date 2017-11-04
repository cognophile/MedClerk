using MedClerk.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedClerk.Models
{
    class UserModel
    {
        /// <summary>
        /// Verifies a user with matching password exists in the database
        /// </summary>
        /// <param name="username">User account username string</param>
        /// <param name="passwordHash">Hashed user password string</param>
        /// <returns>True if match exists, else false</returns>
        public static Boolean Verify(string username, string passwordHash)
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = sqlValidateUserCredntialsExistInUserTable(username, passwordHash);

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            try
            {
                DataTable table = results.Tables[0];
                var user = table.Rows[0].ItemArray.GetValue(0).ToString();
                // TODO: Remove magic numbers
                if (user == username) { return true; } else { return false; }
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected static string sqlValidateUserCredntialsExistInUserTable(string user, string hash)
        {
            return String.Format("SELECT [User].Username FROM dbo.[User] WHERE Username = '{0}' AND PasswordHash = '{1}';", user, hash);
        }
    }
}
