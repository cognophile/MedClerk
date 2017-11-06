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

        static string sqlGetStaffInformation(string date)
        {
            return String.Format("SELECT [Staff].[Title], " +
                                        "[Staff].[First Name], " +
                                        "[Staff].[Last Name] " +
                                 "FROM dbo.[Staff] " +
                                 "INNER JOIN [Appointments] ON [Staff Id] = [Appointments.Staff Id] " +
                                 "WHERE [Date] = CAST({0} AS DATE);", date);
        }
    }
}
