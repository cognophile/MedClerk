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
        private DateTime appointmentDate;

        public AppointmentModel(int staffId, int patientId, string appointmentTime, DateTime appointmentDate)
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
            // var sql = SqlWriteAppointmentRecordToAppointmentsTable();

            // Pass that SQL to the database through the ExecuteCommand() function for now. (We can refactor this later)
            // return true only if the write to the database is successful
            throw new NotImplementedException();
        }

        private string SqlWriteAppointmentRecordToAppointmentsTable()
        {
            return String.Format("INSERT INTO Appointments (Staff Id, Patient Id, Date, Time) VALUES ({1},{2},{3},{4});", staffId, patientId, appointmentTime, appointmentDate);
        }
        
    }
}
