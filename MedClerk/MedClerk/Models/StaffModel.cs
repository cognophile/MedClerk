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
        public static DataTable getStaffRegister(string date)
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

        public static DataTable getStaffMemberTimetable(string staffMember, string date)
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = sqlGetStaffMemberTimetable(staffMember, date);

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }

        private static string sqlGetStaffInformation(string date)
        {
            return String.Format("SELECT [Staff].[Title], " +
                                        "[Staff].[Name] " +
                                 "FROM [Appointments] " +
                                 "INNER JOIN [Staff] ON [Appointments].[Staff Id] = [Staff].[Staff Id] " +
                                 "WHERE [Appointments].[Date] = CONVERT(DATE, '{0}', 103);", date);
        }

        private static string sqlGetStaffMemberTimetable(string staffName, string date)
        {
            return String.Format("SELECT [Appointments].[Time], " +
                                        "[Patients].[Name] " +  
                                 "FROM [Appointments] " +
                                 "INNER JOIN [Staff] ON [Appointments].[Staff Id] = [Staff].[Staff Id] " +
                                 "INNER JOIN [Patients] ON [Appointments].[Patient Id] = [Patients].[Patient Id] " +
                                 "WHERE [Appointments].[Date] = CONVERT(DATE, '{0}', 103) " +
                                 "AND [Staff].[Name] = '{1}';", date, staffName);
        }
    }
}
