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
    class StaffController
    {
        public static void LoadStaff(Views.MainMenu menu)
        {
            Views.StaffView staff = new Views.StaffView();
            menu.Hide();
            staff.Closed += (senderObj, EventArgs) => menu.Close();
            staff.Show();
        }

        public static void LoadMainMenu(Views.StaffView staff)
        {
            Views.MainMenu menu = new Views.MainMenu();
            staff.Hide();
            menu.Closed += (senderObj, EventArgs) => staff.Close();
            menu.Show();
        }

        /// <summary>
        /// Method to produce the on-duty staff register according to staff with bookings on a selected date. 
        /// </summary>
        /// <param name="dateTime">The date selected from the DatePicker</param>
        /// <returns>String list of staff members with appointments on the selected date.</returns>
        public static List<string> ProduceRegister(DateTime dateTime)
        {
            List<string> staff = new List<string>();

            var date = Convert.ToString(dateTime);//DateTimeFormatter.ConvertToUkFormat(dateTime.ToString());
            var results = StaffModel.getStaffRegister(date);
     
            foreach (DataRow row in results.Rows)
            {
                var item = String.Concat(row["Title"].ToString(), ". ", row["Name"].ToString());

                if (staff.Contains(item))
                {
                    continue;
                }

                staff.Add(item);
            }

            return staff;
        }

        /// <summary>
        /// Method to produce the timetable of the selected member of staff, on the selected date.
        /// </summary>
        /// <param name="dateTime">Date to view the time table for (same as date selected for register viewing)</param>
        /// <param name="staffMember">Name of the staff member to retrieve the tiemtable for</param>
        /// <returns>String list of times mapped to patient names which the member of staff has an appointment for.</returns>
        public static List<string> ProduceTimetable(DateTime dateTime, string staffMember)
        {
            List<string> staff = new List<string>();
            staffMember = staffMember.Split('.').Last().Trim();

            var date = Convert.ToString(dateTime);//DateTimeFormatter.ConvertToUkFormat(dateTime.ToString());
            var results = StaffModel.getStaffMemberTimetable(staffMember, date);

            foreach (DataRow row in results.Rows)
            {
                var time = DateTimeFormatter.RemoveSeconds(row["Time"].ToString());
                var patient = row["Name"].ToString();

                var item = String.Concat(time, ": ", patient);

                if (staff.Contains(item))
                {
                    continue;
                }

                staff.Add(item);
            }

            return staff;
        }
    }
}
