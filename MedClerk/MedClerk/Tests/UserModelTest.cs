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
        [Test]        
        public void IntegrationTest_EnsureDatabaseIsReadable_ReturnsTrueIfValidUser()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                var username = "reception";
                var hashedPassword = Password.Hash("password");

                bool isValid = UserModel.Verify(username, hashedPassword);

                Assert.That(isValid, Is.EqualTo(true));
            }
        }

        [Test]
        public void IntegrationTest_EnsureDatabaseIsWritable_ReturnsTrueIfUserCreated()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                throw new NotImplementedException();
            }
        }

        [Test]
        public void UnitTest_CheckSqlQuery_ReturnsExpectedQueryString_WhenGivenValues()
        {
            throw new NotImplementedException();
        }

    }
}
