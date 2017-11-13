using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedClerk.Utilities
{
    /// <summary>
    /// Provides formatting manipulations using 'DateTime' functions.
    /// </summary>
    class DateTimeFormatter
    {
        /// <summary>
        /// Function to convert from a US format date (MM/dd/yyyy) to UK format (dd/MM/yyyy)
        /// </summary>
        /// <param name="usFormat">String representation of a date, in US format 'MM/dd/yyyy' including time, in default 12-hour format.</param>
        /// <returns>String representing the UK format of the given Date</returns>
        public static string ConvertToUkFormat(string dateTime)
        {
            try
            {
                DateTime dt = DateTime.ParseExact(dateTime, "MM/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                return dt.ToString("d/MM/yyyy");
            }
            catch (FormatException)
            {
                return DateTime.Today.ToString("d/MM/yyyy");
            }
        }

        /// <summary>
        /// Function to remove the seconds from a Time string
        /// </summary>
        /// <param name="time">A string represenation of the time in "HH:mm:ss" format.</param>
        /// <returns>String representation of the time without the seconds appended. Eg. "HH:mm".</returns>
        public static string RemoveSeconds(string time)
        {
            return DateTime.Parse(time.ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
        }
    }
}
