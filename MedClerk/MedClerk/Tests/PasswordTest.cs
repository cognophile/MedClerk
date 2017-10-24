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
            var password = "example-password";
            var expected = "cc4436eff149ba9761aaac07b36360ea";

            // Act
            var passwordHash = Password.Hash(password);

            // Assert
            Assert.That(passwordHash, Is.EqualTo(expected));
        }

        [Test]
        public void TestPasswordHashing_NullPassword_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Password.Hash(null));
        }
    }
}
