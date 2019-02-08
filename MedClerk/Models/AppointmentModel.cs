using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MedClerk.Database;

namespace MedClerk.Models
{
    class AppointmentModel
    {
        private int staffId;
        private int patientId;
        private string appointmentTime;
        private string appointmentDate;

        public AppointmentModel(int staffId, int patientId, string appointmentTime, string appointmentDate)
        {
            this.staffId = staffId;
            this.patientId = patientId;
            this.appointmentTime = appointmentTime;
            this.appointmentDate = appointmentDate;

        }
        public bool SaveAppointment()
        {
            // Reference the fields above with 'this.staffId' etc.
            // Get the SQLQuery from the private function below: 
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlWriteAppointmentRecordToAppointmentsTable();

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
            
            
            // Pass that SQL to the database through the ExecuteCommand() function for now. (We can refactor this later)
            // return true only if the write to the database is successful
        }

        private string SqlWriteAppointmentRecordToAppointmentsTable()
        {
            return String.Format("INSERT INTO [Appointments] ([Staff Id], [Patient Id], [Date], [Time]) VALUES ({0}, {1}, CONVERT(DATE, '{2}', 103), CONVERT(TIME, '{3}'));", 
                                staffId, patientId, appointmentDate, appointmentTime);
        }
    }
}
