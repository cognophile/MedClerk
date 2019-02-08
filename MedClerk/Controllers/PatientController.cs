﻿using System;
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

        /// <summary>
        /// Locate a patient 
        /// - 3 OVERLOADS: int id | string name, string address | string name, DateTime dob
        /// </summary>
        /// <param name="id">Integer: id</param>
        /// <returns>DataTable: Results Set of Query</returns>
        public static DataTable FindPatient(int id)
        {
            PatientModel patient = new PatientModel { Id = id };
            return patient.FindPatientById();
        }

        /// <summary>
        /// Locate a patient 
        /// - 3 OVERLOADS: int id | string name, string address | string name, DateTime dob
        /// </summary>
        /// <param name="name">String: Full Name</param>
        /// <param name="address">String: Full Address</param>
        /// <returns>DataTable: Results Set of Query</returns>
        public static DataTable FindPatient(string name, string address)
        {
            PatientModel patient = new PatientModel
            {
                FullName = name,
                Address = address
            };

            return patient.FindPatientByNameAndAddress();
        }

        /// <summary>
        /// Locate a patient 
        /// - 3 OVERLOADS: int id | string name, string address | string name, DateTime dob
        /// </summary>
        /// <param name="name">String: Full Name</param>
        /// <param name="dob">DateTime: Date of Birth</param>
        /// <returns>DataTable: Results Set of Query</returns>
        public static DataTable FindPatient(string name, DateTime dob)
        {
            PatientModel patient = new PatientModel
            {
                FullName = name,
                DateOfBirth = dob
            };

            return patient.FindPatientByNameAndDateOfBirth();
        }

        public static bool AddPatient(string name, string address, DateTime dob)
        {
            // Surround this in a try/catch in case we can't write to the database. 
            // Where you catch the exception, send the message back to the view to display in a text box. 

            PatientModel patient = new PatientModel(0, name, dob, address);
            var result = patient.SavePatient();
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static void LoadPatientProfile(Views.PatientManagementView managementForm, string id, string name, string dob, string address)
        {
            Views.PatientProfileView patientProfile = new Views.PatientProfileView(id, name, dob, address);
            managementForm.Hide();
            patientProfile.Closed += (senderObj, EventArgs) => managementForm.Close();
            patientProfile.Show();
        }

        internal static void BackToPatientManagement(Views.PatientProfileView patientProfile)
        {
            Views.PatientManagementView patientManagement = new Views.PatientManagementView();
            patientProfile.Hide();
            patientManagement.Closed += (senderObj, EventArgs) => patientProfile.Close();
            patientManagement.Show();
        }

        public static DataTable obtainPrescription(int oPiD)
        {
            PatientModel patient = new PatientModel { Id = oPiD };
            return patient.getPrescription();
        }

        public static DataTable obtainTests(int oTiD)
        {
            PatientModel patient = new PatientModel { Id = oTiD };
            return patient.getTests();
        }

        public static bool extendPrescription(int prescriptionId, int patientId, DateTime newEndDate)
        {
            PatientModel patientID = new PatientModel { Id = patientId };
            return patientID.extendPrescription(prescriptionId, newEndDate);
        }
    }
}
