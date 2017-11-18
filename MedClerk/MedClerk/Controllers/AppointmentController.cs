using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClerk.Utilities;
using MedClerk.Models;
using System.Globalization;

namespace MedClerk.Controllers
{
    class AppointmentController
    {
        public static void LoadAppointment(Views.MainMenu menu)
        {
            Views.AppointmentManagementView appointment = new Views.AppointmentManagementView();
            menu.Hide();
            appointment.Closed += (senderObj, EventArgs) => menu.Close();
            appointment.Show();
        }
        public static void LoadMainMenu(Views.AppointmentManagementView appointment)
        {
            Views.MainMenu menu = new Views.MainMenu();
            appointment.Hide();
            menu.Closed += (senderObj, EventArgs) => appointment.Close();
            menu.Show();
        }
        public static List<string> ProduceAppointments(DateTime dateTime)
        {
            List<string> appointments = new List<string>();
            var date = Convert.ToString(dateTime);
            var results = PatientModel.getAppointments(date);

            foreach (DataRow row in results.Rows)
            {
                var item = String.Concat(row["Time"].ToString(), ". ", row["Room"].ToString(), ". ", row["Title"].ToString(), ". ", row["Name"].ToString(), ". ", row["Patient Name"].ToString());

                if (appointments.Contains(item))
                {
                    continue;
                }

                appointments.Add(item);
            }

            return appointments;
        }
        public static List<string> ProducePatients()
        {
            List<string> patients = new List<string>();
            var results = PatientModel.getPatients();
            patients.Insert(0, "Choose Patient");
            foreach (DataRow row in results.Rows)
            {
                var item = String.Concat(row["Patient Name"].ToString());

                if (patients.Contains(item))
                {
                    continue;
                }

                patients.Add(item);
            }

            return patients;
        }
        public static List<string> ProduceStaff()
        {
            List<string> staff = new List<string>();
            var results = PatientModel.getStaff();
            staff.Insert(0, "Choose Staff Member");
            foreach (DataRow row in results.Rows)
            {
                var item = String.Concat(row["Name"].ToString());

                if (staff.Contains(item))
                {
                    continue;
                }

                staff.Add(item);
            }

            return staff;
        }
        public static List<TimeSpan> ProduceTime()
        {
            var times = new List<TimeSpan>();
            double interval = 15;
            DateTime start = new DateTime(2017,1,1,09, 00, 0);
            DateTime end = new DateTime(2017, 1, 1,14, 00, 0);
            for (var ts = start; ts <= end; ts = ts.AddMinutes(interval))
            {
                times.Add(ts.TimeOfDay);
            }
            return times;
        }
        
    }
}
