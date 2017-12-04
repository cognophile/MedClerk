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
        private const int RESULTS_TABLE = 0;
        private const int FIRST_RESULT = 0;
        private const int USERNAME = 0;

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
            var sql = SqlValidateUserCredntialsExistInUserTable(username, passwordHash);

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            try
            {
                DataTable table = results.Tables[RESULTS_TABLE];
                var user = table.Rows[FIRST_RESULT].ItemArray.GetValue(USERNAME).ToString();
                
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

        protected static string SqlValidateUserCredntialsExistInUserTable(string user, string hash)
        {
            return String.Format("SELECT [User].Username FROM dbo.[User] WHERE Username = '{0}' AND PasswordHash = '{1}';", user, hash);
        }
    }
}
