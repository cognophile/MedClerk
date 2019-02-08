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
        //private TransactionScope rollback;
        //private List<object> patientForQueries;
        //private List<object> patientForCommands; 

        //private const int ID_COLUMN = 0;
        //private const int NAME_COLUMN = 1;
        //private const int ADDRESS_COLUMN = 2;
        //private const int DOB_COLUMN = 3;

        //[SetUp]
        //public void SetUp()
        //{
        //    rollback = new TransactionScope();
        //    patientForQueries = new List<object>
        //    {
        //        300,
        //        "Stephen Jones",
        //        "21 Dudley Close",
        //        new DateTime(1970, 07, 01)
        //    };

        //    patientForCommands = new List<object>
        //    {
        //        1,
        //        "Test Patient",
        //        "123 Test Address Town Postcode",
        //        new DateTime(1970, 01, 01)
        //    };
        //}

        //[TearDown]
        //public void TearDown()
        //{
        //    rollback.Dispose();
        //}

        //[Test]
        //public void IntegrationTest_EnsureDatabaseIsReadable_TestSearchById_ReturnsExpectedPatientName()
        //{
        //    var expected = patientForQueries[NAME_COLUMN].ToString();

        //    var resultsSet = PatientController.FindPatient(300);
        //    List<DataRow> tableList = resultsSet.AsEnumerable().ToList();

        //    var actual = tableList[0].ItemArray[NAME_COLUMN];

        //    Assert.That(actual, Is.EqualTo(expected));
        //}

        //[Test]
        //public void IntegrationTest_EnsureDatabaseIsReadable_TestSearchByNameAndAddress_ReturnsExpectedPatientId()
        //{
        //    var expected = 300;
        //    var patientName = patientForQueries[NAME_COLUMN].ToString();
        //    var patientAddress = patientForQueries[ADDRESS_COLUMN].ToString();

        //    var resultsSet = PatientController.FindPatient(patientName, patientAddress);
        //    List<DataRow> tableList = resultsSet.AsEnumerable().ToList();

        //    var actual = tableList[0].ItemArray[ID_COLUMN];

        //    Assert.That(actual, Is.EqualTo(expected));
        //}

        //[Test]
        //public void IntegrationTest_EnsureDatabaseIsReadable_TestSearchByNameAndDateOfBirth_ReturnsExpectedPatientId()
        //{
        //    var expected = 300;
        //    var patientName = patientForQueries[NAME_COLUMN].ToString();
        //    DateTime patientDob = Convert.ToDateTime(patientForQueries[DOB_COLUMN]);

        //    var resultsSet = PatientController.FindPatient(patientName, patientDob);
        //    List<DataRow> tableList = resultsSet.AsEnumerable().ToList();

        //    var actual = tableList[0].ItemArray[ID_COLUMN];

        //    Assert.That(actual, Is.EqualTo(expected));
        //}

        //[Test]
        //public void IntegrationTest_EnsureDatabaseIsWritable_ReturnsTrueIfPatientCreated()
        //{
        //    var expected = true;
        //    var name = patientForCommands[NAME_COLUMN].ToString();
        //    var dob = patientForCommands[DOB_COLUMN].ToString();
        //    var address = patientForCommands[ADDRESS_COLUMN].ToString();

        //    var isSuccessful = PatientController.AddPatient(name, address, Convert.ToDateTime(dob));

        //    Assert.That(isSuccessful, Is.EqualTo(expected));
        //}
    }
}

