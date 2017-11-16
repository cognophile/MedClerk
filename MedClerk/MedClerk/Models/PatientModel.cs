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
        public static DataTable getPatients(string name)
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlGetPatientName(name);

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }
        private static string SqlGetPatientName(string name)
        {
            return String.Format("SELECT [Patients].[Patient Name] " +
                                 "FROM [Patients] ", name.ToString());
        }
    }
}
