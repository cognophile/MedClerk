using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClerk.Utilities;
using MedClerk.Models;
using MedClerk.Views;
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
                var item = String.Concat(row["Time"].ToString(), "\t\t", row["Room"].ToString(), "\t\t", row["Title"].ToString(), ".", row["Name"].ToString(), "\t\t", row["Patient Name"].ToString());

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
                var item = String.Concat(row["Patient Id"].ToString(), ": ",row["Patient Name"].ToString());

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
                var item = String.Concat(row["Staff Id"].ToString(), ": ", row["Name"].ToString());

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
        
        public static List<string> CreateAppointment(int staffID, int patientID, string chosenTime, string chosenDate)
        {
            // Surround this in a try/catch in case we can't write to the database. 
            // Where you catch the exception, send the message back to the view to display in a text box. 

            var appointment = new AppointmentModel(staffID, patientID, chosenTime, chosenDate);
            var result = appointment.SaveAppointment();
            // If result is all good, return true (it saved to the database)
            // If the save failed, it'll go into the exception catch block where you can send back the error message something like:  
            // catch (Exception ex) {
            //      return e.GetMessage();
            // }

            if (result)
            {
                var app = ProduceAppointments(Convert.ToDateTime(chosenDate));
                return app;
            } 
            else
            {
                List<string> noResults = new List<string>();
                return noResults;
            }
        }
        public static bool RemoveAppointments(string date, string time, string staffMember, string patientMember)
        {
            var appointment = new RemoveAppointmentModel(date, time, staffMember, patientMember);
            var result = appointment.RemoveAppointment();
            if (result)
            {
                //List<string> entryDeleted = new List<string>();
                //return entryDeleted;
                return true;
            }
            else
            {
                //List<string> noResults = new List<string>();
                //return noResults;
                return false; 
            }
        }
    }
}
