using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MedClerk.Utilities;
using System.Globalization;

namespace MedClerk.Tests
{
    class DateTimeFormatterTest
    {
        [Test]
        public void TestConverToUkFormat_GivenADefaultUsFormat_ReturnsExpectedUkDateFormatString()
        {
            // Arrange
            var expected = "5/12/2017";
            DateTime testDate = new DateTime(2017, 12, 5);
            var testDateStr = testDate.Date.ToString("d");
            
            // Act
            var date = DateTimeFormatter.ConvertToUkFormat(testDateStr);

            // Assert
            Assert.That(date, Is.EqualTo(expected));
        }

        [Test]
        public void TestExcludeSeconds_GivenADefaultTimeFormatString_ReturnsExpectedTimeStringWithoutSeconds()
        {
            // Arrange
            var expected = "12:30";
            var initialTime = "12:30:05";

            // Act
            var time = DateTimeFormatter.RemoveSeconds(initialTime);

            // Assert
            Assert.That(time, Is.EqualTo(expected));
        }
    }
}
