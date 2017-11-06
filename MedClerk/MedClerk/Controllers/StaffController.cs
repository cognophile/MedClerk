using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClerk.Utilities;
using MedClerk.Models;
using System.Data;

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

        public static List<string> FindStaff(Views.StaffView staffView)
        {
            var date = staffView.getSelectedDate();
            var data = StaffModel.getRegister(date.Date.ToString("d"));

            List<string> staff = new List<string>();

            foreach (DataRow row in data.Rows)
            {
                staff.Add(String.Concat(row["Title"].ToString(), ". ", row["First Name"].ToString(), " ", row["Last Name"].ToString()));
            }

            return staff;
        }
    }
}
