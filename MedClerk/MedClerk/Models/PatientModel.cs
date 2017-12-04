using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MedClerk.Database;

namespace MedClerk.Models
{
    class PatientModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        // Constructor for empty object
        public PatientModel() { Id = 0; FullName = "No Name"; DateOfBirth = DateTime.Today; Address = "No Address";  }

        // Constructor for creating full object
        public PatientModel(int id, string name, DateTime dob, string address)
        {
            this.Id = id;
            this.FullName = name;
            this.DateOfBirth = dob;
            this.Address = address;
        }

        public static DataTable getPatients()
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlGetPatientNames();

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }

        /// <summary>
        /// Search for a patient by Id only. 
        /// </summary>
        /// <returns>DataTable: Results set of patient record found</returns>
        public DataTable FindPatientById()
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlFindPatientById(this.Id);

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }

        /// <summary>
        /// Search for a patient by Name and Date of Birth only.
        /// </summary>
        /// <returns>DataTable: Results set of patient record found</returns>
        public DataTable FindPatientByNameAndAddress()
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlFindPatientByNameAndAddress(this.FullName, this.Address);

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }

        /// <summary>
        /// Search for a patient by Name and Date of Birth only. 
        /// </summary>
        /// <returns>DataTable: Results set of patient record found</returns>
        public DataTable FindPatientByNameAndDateOfBirth()
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlFindPatientByNameAndDateOfBirth(this.FullName, this.DateOfBirth);

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }

        public static DataTable getStaff()
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlGetStaffNames();

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }
        
        public static DataTable getAppointments(string date)
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlGetAppointments(date);

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }

        public DataTable getPrescription()
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlGetPrescription(this.Id);

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }

        public DataTable getTests()
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlGetTestResults(this.Id);

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }

        /*public DataTable extendPrescription(DateTime startDate, DateTime endDate, int patientId)
        {
            var connection = Properties.Settings.Default.DBSource;
            var database = new DatabaseManager(connection);
            var sql = SqlExtendPrescription(startDate, endDate, patientId);

            database.OpenConnection();

            var results = database.ExecuteQuery(sql);

            database.CloseConnection();

            DataTable table = results.Tables[0];
            return table;
        }*/

        private static string SqlGetPatientNames()
        {
            return String.Format("SELECT[Patient Id], [Patient Name] FROM [Patients] ");
        }

        private static string SqlGetStaffNames()
        {
            return String.Format("SELECT[Staff Id], [Name] FROM [Staff] ");
        }

        private static string SqlFindPatientById(int id)
        {
            return String.Format("SELECT * FROM [Patients] WHERE [Patient Id] = {0};", id);
        }

        private static string SqlFindPatientByNameAndAddress(string name, string address)
        {
            return String.Format("SELECT * FROM [Patients] WHERE [Patient Name] = '{0}' AND [Address] = '{1}';", name, address);
        }

        private static string SqlFindPatientByNameAndDateOfBirth(string name, DateTime dob)
        {
            return String.Format("SELECT * FROM [Patients] WHERE [Patient Name] = '{0}' AND [Date of Birth] = CONVERT(DATE, '{1}', 103);", name, dob.ToString("dd/MM/yyyy"));
        }

        private static string SqlGetAppointments(string date)
        {
            return String.Format("SELECT [Appointments].[Time], " +
                                        "[Staff].[Room], " +
                                        "[Staff].[Title], " +
                                        "[Staff].[Name], " +
                                        "[Patients].[Patient Name] " +
                                 "FROM [Appointments] " +
                                 "INNER JOIN [Staff] ON [Appointments].[Staff Id] = [Staff].[Staff Id] " +
                                 "INNER JOIN [Patients] ON [Appointments].[Patient Id] = [Patients].[Patient Id] " +
                                 "WHERE CONVERT(DATE, [Appointments].[Date], 103) = CONVERT(DATE, '{0}', 103);", date.ToString());
        }

        private static string SqlGetPrescription(int Id)
        {
            return String.Format("SELECT * FROM [Prescriptions] WHERE [Patient_Id] = {0}", Id);
        }

        private static string SqlGetTestResults(int Id)
        {
            return String.Format("SELECT [Patients].[Patient Id], [Patients].[Patient Name], [Tests].[Name] AS 'Test Name', [Tests].[Description], [Test Results].[Date], [Test Results].[Result]" +
                                    "FROM[Test Results]" + 
                                    "INNER JOIN[Patients] ON[Test Results].[Patient_Id] = [Patients].[Patient Id]" +
                                    "INNER JOIN[Tests] ON[Test Results].[Test_Id] = [Tests].[Id]" +
                                    "WHERE[Patients].[Patient Id] = {0};", Id);
        }

        /*private static string SqlExtendPrescription(DateTime startDate, DateTime endDate, int patientId)
        {
            return String.Format("UPDATE [Prescriptions]" +
                                 "SET [Start_Date] = {0}, [End_Date] = {1}" +
                                 "WHERE [Patient_Id] = {2}", startDate, endDate, patientId);
        }*/
    }
}
