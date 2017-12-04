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
            var sql = SqlGetStaffInformation(date);

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
            var sql = SqlGetStaffMemberTimetable(staffMember, date);

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }
        private static string SqlGetStaffInformation(string date)
        {
            return String.Format("SELECT [Staff].[Title], " +
                                        "[Staff].[Name] " +
                                 "FROM [Appointments] " +
                                 "INNER JOIN [Staff] ON [Appointments].[Staff Id] = [Staff].[Staff Id] " +
                                 "WHERE CONVERT(DATE, [Appointments].[Date], 103) = CONVERT(DATE, '{0}', 103);", date.ToString());
        }

        private static string SqlGetStaffMemberTimetable(string staffName, string date)
        {
            return String.Format("SELECT [Appointments].[Time], " +
                                        "[Patients].[Patient Name] " +  
                                 "FROM [Appointments] " +
                                 "INNER JOIN [Staff] ON [Appointments].[Staff Id] = [Staff].[Staff Id] " +
                                 "INNER JOIN [Patients] ON [Appointments].[Patient Id] = [Patients].[Patient Id] " +
                                 "WHERE CONVERT(DATE, [Appointments].[Date], 103) = CONVERT(DATE, '{0}', 103) " +
                                 "AND [Staff].[Name] = '{1}';", date.ToString(), staffName);
        }
    }
}
