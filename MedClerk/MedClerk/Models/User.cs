using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClerk.Database;
using System.Data;

namespace MedClerk.Models
{
    class User
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
            var sql = String.Format("SELECT [User].Username FROM dbo.[User] " +
                                    "WHERE Username = '{0}' AND " +
                                    "PasswordHash = '{1}';", username, passwordHash);
            var database = new DatabaseManager(connection);

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
    }
}
