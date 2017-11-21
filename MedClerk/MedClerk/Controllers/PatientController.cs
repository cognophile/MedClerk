using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClerk.Models;
using MedClerk.Views;
using System.Data;

namespace MedClerk.Controllers
{
    class PatientController
    {
        internal static void LoadPatientManagement(MainMenu mainMenu)
        {
            Views.PatientManagementView patientManagement = new Views.PatientManagementView();
            mainMenu.Hide();
            patientManagement.Closed += (senderObj, EventArgs) => mainMenu.Close();
            patientManagement.Show();
        }

        public static void LoadMenu(Views.PatientManagementView patientManagement)
        {
            Views.MainMenu menu = new Views.MainMenu();
            patientManagement.Hide();
            menu.Closed += (senderObj, EventArgs) => patientManagement.Close();
            menu.Show();
        }

        public static DataTable FindPatient(int id)
        {
            PatientModel patient = new PatientModel { Id = id };
            return patient.FindPatientById();
        }
        
        public static DataTable FindPatient(string name, string address)
        {
            PatientModel patient = new PatientModel
            {
                FullName = name,
                Address = address
            };

            return patient.FindPatientByNameAndAddress();
        }

        public static DataTable FindPatient(string name, DateTime dob)
        {
            PatientModel patient = new PatientModel
            {
                FullName = name,
                DateOfBirth = dob
            };

            return patient.FindPatientByNameAndDateOfBirth();
        }
    }
}
