using MedClerk.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedClerk.Models
{
    class StaffModel
    {
        public static DataTable getRegister(string date)
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = sqlGetStaffInformation(date);

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }

        private static string sqlGetStaffInformation(string date)
        {
            return String.Format("SELECT [Staff].[Title], " +
                                        "[Staff].[First Name], " +
                                        "[Staff].[Last Name], " +
                                        "[Appointments].[Date] " +
                                 "FROM [Appointments] " +
                                 "INNER JOIN [Staff] ON [Appointments].[Staff Id] = [Staff].[Staff Id] " +
                                 "WHERE [Appointments].[Date] = CONVERT(DATE, '{0}', 103);", date);
        }
    }
}
