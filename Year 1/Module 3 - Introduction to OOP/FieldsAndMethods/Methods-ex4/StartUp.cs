using System;

namespace Methods_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            var year1 = Console.ReadLine();
            var year2 = Console.ReadLine();
            DateModifier date = new DateModifier();
            var days = date.DaysBetween(year1,year2);
            System.Console.WriteLine(days);
        }
    }
}
