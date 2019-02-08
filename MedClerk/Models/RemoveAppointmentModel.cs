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
        private int staffId;
        private int patientId;
        private string time;
        private string date;
        public RemoveAppointmentModel(string date, string time, string staffMember, string patientMember)
        {
            this.patientMember = patientMember;
            this.staffMember = staffMember;
            this.time = time;
            this.date = date;
        }
        public int getPatientID(string patientMember)
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlGetPatientId(patientMember);

            database.OpenConnection();
            var results = database.ExecuteQuery(sql);
            database.CloseConnection();

            var patientId = results.Tables[0].Rows[0]["Patient Id"];
            return Int32.Parse(patientId.ToString());
        }
        private static string SqlGetPatientId(string patientMember)
        {
            return String.Format("SELECT [Patients].[Patient Id] FROM [Patients] WHERE [Patients].[Patient Name] = '{0}';", patientMember);
        }
        public int getStaffID(string staffMember)
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlGetStaffId(staffMember);

            database.OpenConnection();
            var results = database.ExecuteQuery(sql);
            database.CloseConnection();
            var staffId = results.Tables[0].Rows[0]["Staff Id"];
            return Int32.Parse(staffId.ToString());
        }
        private static string SqlGetStaffId(string staffMember)
        {
            return String.Format("SELECT [Staff].[Staff Id] FROM [Staff] WHERE [Staff].[Name] = '{0}';", staffMember);
        }
        public bool RemoveAppointment()
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);

            // Get staff ID
            this.staffId = getStaffID(this.staffMember);
            this.patientId = getPatientID(this.patientMember);

            // Remove 
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
            return String.Format("DELETE FROM [Appointments] WHERE [Date] = CONVERT(DATE, '"+ date +"', 103) AND [Time] = '" + time + "' AND [Staff Id] = " + this.staffId + " AND [Patient Id] = " + this.patientId +";");
        }
    }
}