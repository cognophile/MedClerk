using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClerk.Utilities;
using NUnit.Framework;

namespace MedClerk.Tests
{
    class PasswordTest
    {
        [Test]
        public void TestPasswordHashing_ReturnsExpected_Md5HashValue()
        {
            // Arrange
            var password = "password";
            var expected = "5f4dcc3b5aa765d61d8327deb882cf99";

            // Act
            var passwordHash = Password.Hash(password);

            // Assert
            Assert.That(passwordHash, Is.EqualTo(expected));
        }
    }
}
