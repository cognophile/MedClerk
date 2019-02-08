﻿using System;
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
        public void TestConverUsToUkFormat_GivenADefaultUsFormat_ReturnsExpectedUkDateFormatString()
        {
            // Arrange
            var expected = "21/12/2017";
            DateTime testDate = new DateTime(2017, 12, 21);
            var testDateStr = testDate.ToString();
            
            // Act
            var date = DateTimeFormatter.ConvertUsToUkFormat(testDateStr);

            // Assert
            Assert.That(date, Is.EqualTo(expected));
        }

        [Test]
        public void TestConvertUsToUKFormat_GivenUSDateFormat_ReturnsGivenDateInUKFormat()
        {
            // Arrange
            var usDateFormat = "11/29/2017 11:00:00 AM";
            var expected = "29/11/2017";

            // Act
            var date = DateTimeFormatter.ConvertUsToUkFormat(usDateFormat);

            // Assert
            Assert.That(date, Is.EqualTo(expected));
        }

        [Test]
        public void TestConvertUsToUKFormat_GivenUKDateFormat_With24HrTime_ReturnsGivenDateInUKFormat()
        {
            // Arrange
            var usDateFormat = "29/11/2017 14:00:00";
            var expected = "29/11/2017";

            // Act
            var date = DateTimeFormatter.ConvertUsToUkFormat(usDateFormat);

            // Assert
            Assert.That(date, Is.EqualTo(expected));
        }

        [Test]
        public void TestConvertUsToUKFormat_GivenUKDateFormat_WithoutTime_ReturnsGivenDateInUKFormat()
        {
            // Arrange
            var usDateFormat = "29/11/2017";
            var expected = "29/11/2017";

            // Act
            var date = DateTimeFormatter.ConvertUsToUkFormat(usDateFormat);

            // Assert
            Assert.That(date, Is.EqualTo(expected));
        }

        [Test]
        public void TestConvertUsToUkFormat_GivenUKFormat_MissingTimeDefinition_ReturnTodaysDateInUKFormat()
        {
            // Arrange
            var usDateFormat = "10/29/2017";
            var expected = DateTime.Today.ToString("dd/MM/yyyy");

            // Act
            var date = DateTimeFormatter.ConvertUsToUkFormat(usDateFormat);

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
