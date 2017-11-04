using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClerk.Utilities;
using NUnit.Framework;
using MedClerk.Models;
using System.Transactions;

namespace MedClerk.Tests
{
    class UserModelTest
    {
        private TransactionScope rollback;

        [SetUp]
        public void SetUp()
        {
            rollback = new TransactionScope();
        }

        [TearDown]
        public void TearDown()
        {
            rollback.Dispose();
        }

        [Test]        
        public void IntegrationTest_EnsureDatabaseIsReadable_ReturnsTrueIfValidUser()
        {
            var username = "reception";
            var hashedPassword = Password.Hash("password");

            bool isValid = UserModel.Verify(username, hashedPassword);

            Assert.That(isValid, Is.EqualTo(true));
        }

        [Test]
        public void IntegrationTest_EnsureDatabaseIsWritable_ReturnsTrueIfUserCreated()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void UnitTest_CheckSqlQuery_ReturnsExpectedQueryString_WhenGivenValues()
        {
            throw new NotImplementedException();
        }

    }
}
