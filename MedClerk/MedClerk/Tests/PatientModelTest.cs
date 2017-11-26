using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClerk.Utilities;
using NUnit.Framework;
using MedClerk.Models;
using MedClerk.Controllers;
using System.Transactions;
using System.Data;

namespace MedClerk.Tests
{
    class PatientModelTest
    {
        private TransactionScope rollback;
        private List<object> patient; 
        
        private const int ID_COLUMN = 0;
        private const int NAME_COLUMN = 1;
        private const int ADDRESS_COLUMN = 2;
        private const int DOB_COLUMN = 3;

        [SetUp]
        public void SetUp()
        {
            rollback = new TransactionScope();
            patient = new List<object>
            {
                300,
                "Stephen Jones",
                "21 Dudley Close",
                new DateTime(1970, 07, 01)
            };
        }

        [TearDown]
        public void TearDown()
        {
            rollback.Dispose();
        }

        [Test]
        public void IntegrationTest_EnsureDatabaseIsReadable_TestSearchById_ReturnsExpectedPatientName()
        {
            var expected = patient[NAME_COLUMN].ToString();

            var resultsSet = PatientController.FindPatient(300);
            List<DataRow> tableList = resultsSet.AsEnumerable().ToList();

            var actual = tableList[0].ItemArray[NAME_COLUMN];

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IntegrationTest_EnsureDatabaseIsReadable_TestSearchByNameAndAddress_ReturnsExpectedPatientId()
        {
            var expected = 300;
            var patientName = patient[NAME_COLUMN].ToString();
            var patientAddress = patient[ADDRESS_COLUMN].ToString();

            var resultsSet = PatientController.FindPatient(patientName, patientAddress);
            List<DataRow> tableList = resultsSet.AsEnumerable().ToList();

            var actual = tableList[0].ItemArray[ID_COLUMN];

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IntegrationTest_EnsureDatabaseIsReadable_TestSearchByNameAndDateOfBirth_ReturnsExpectedPatientId()
        {
            var expected = 300;
            var patientName = patient[NAME_COLUMN].ToString();
            DateTime patientDob = Convert.ToDateTime(patient[DOB_COLUMN]);

            var resultsSet = PatientController.FindPatient(patientName, patientDob);
            List<DataRow> tableList = resultsSet.AsEnumerable().ToList();

            var actual = tableList[0].ItemArray[ID_COLUMN];

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void IntegrationTest_EnsureDatabaseIsWritable_ReturnsTrueIfPatientCreated()
        {
            throw new NotImplementedException();
        }
    }
}
