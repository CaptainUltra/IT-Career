using System;

namespace Methods_ex4
{
    class DateModifier
    {
        public double DaysBetween(string year1, string year2)
        {
            DateTime date1;
            DateTime date2;
            date1 = DateTime.Parse(year1);
            date2 = DateTime.Parse(year2);
            return Math.Abs((date1 - date2).TotalDays);
        }
    }
}