using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClerk.Utilities;
using MedClerk.Models;

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

    }
}
