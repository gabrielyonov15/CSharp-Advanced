﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DateModifier
{
    public class DateModifier
    {
        public static double GetDaysBetweenDates(string dateOne, string dateTwo)
        {
            var firstDate = DateTime.ParseExact(dateOne, "yyyy MM dd", CultureInfo.InvariantCulture);
            var secondDate = DateTime.ParseExact(dateTwo, "yyyy MM dd", CultureInfo.InvariantCulture);
            if (firstDate > secondDate)
            {
                return GetDaysBetweenDates(dateTwo, dateOne);
            }
            return (secondDate - firstDate).Days;
        }
    }
}
