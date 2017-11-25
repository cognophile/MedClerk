using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClerk.Database;

namespace MedClerk.Models
{
    class RemoveAppointmentModel
    {
        private string patientMember;
        private string staffMember;
        private string date;
        public RemoveAppointmentModel(string date, string staffMember, string patientMember)
        {
            this.patientMember = patientMember;
            this.staffMember = staffMember;
            this.date = date;
        }
        public string getPatientID(string patientMember)
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlGetPatientId(patientMember);

            database.OpenConnection();
            var results = database.ExecuteQuery(sql);
            database.CloseConnection();

            string patientId = results.ToString();
            return patientId;
        }
        private static string SqlGetPatientId(string patientMember)
        {
            return String.Format("SELECT[Patient].[Patient Id] FROM [Patient] WHERE[Patient].[Patient Name] LIKE '‰{0}%';", patientMember);
        }
        public string getStaffID(string staffMember)
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlGetStaffId(staffMember);

            database.OpenConnection();
            var results = database.ExecuteQuery(sql);
            database.CloseConnection();
            //string staffId = results.ToString();
            return results.ToString();
        }
        private static string SqlGetStaffId(string staffMember)
        {
            return String.Format("SELECT[Staff].[Staff Id] FROM [Staff] WHERE[Staff].[Staff Name] LIKE '‰{0}%';", staffMember);
        }
        public bool RemoveAppointment()
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlDeleteAppointmentRecordFromAppointmentsTable();

            database.OpenConnection();
            var result = database.ExecuteCommand(sql);
            database.CloseConnection();

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string SqlDeleteAppointmentRecordFromAppointmentsTable()
        {
            return String.Format("DELETE FROM [Appointments] WHERE [Date] = '" + date + "'[Staff Id] = '" + staffMember + "'[Patient Id] = '" + patientMember );
        }
    }
}