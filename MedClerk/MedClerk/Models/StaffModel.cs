using MedClerk.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedClerk.Models
{
    class StaffModel
    {
        public static void Register(string title, string firstName, string lastName, string room)
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = sqlGetStaffInformation(title, firstName, lastName, room);

            database.OpenConnection();

            var result = database.ExecuteQuery(sql);

            database.CloseConnection();
        }

        static string sqlGetStaffInformation(string title, string firstName, string lastName, string room)
        {
            return String.Format("SELECT * FROM dbo.[Staff];");
        }
    }
}
