using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MedClerk.Database;
namespace MedClerk.Models
{
    class PatientModel
    {
        public static DataTable getPatients()
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlGetPatientNames();

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }
        private static string SqlGetPatientNames()
        {
            return String.Format("SELECT [PATIENT NAME] " +
                                 "FROM [Patients] ");
        }
        public static DataTable getStaff()
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlGetStaffNames();

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }
        private static string SqlGetStaffNames()
        {
            return String.Format("SELECT [NAME] " +
                                 "FROM [Staff] ");
        }
        public static DataTable getAppointments(string date)
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlGetAppointments(date);

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }
        private static string SqlGetAppointments(string date)
        {
            return String.Format("SELECT [Appointments].[Time], " +
                                        "[Staff].[Room], " +
                                        "[Staff].[Title], " +
                                        "[Staff].[Name], " +
                                        "[Patients].[Patient Name] " +
                                 "FROM [Appointments] " +
                                 "INNER JOIN [Staff] ON [Appointments].[Staff Id] = [Staff].[Staff Id] " +
                                 "INNER JOIN [Patients] ON [Appointments].[Patient Id] = [Patients].[Patient Id] " +
                                 "WHERE CONVERT(DATE, [Appointments].[Date], 103) = CONVERT(DATE, '{0}', 103);", date.ToString());
        }
    }
}
