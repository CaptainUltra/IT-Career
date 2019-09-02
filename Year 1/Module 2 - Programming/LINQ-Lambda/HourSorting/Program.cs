using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace HourSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = new List<DateTime>();
            string[] input = Console.ReadLine().Split(' ');
            for(int i = 0; i < input.Length;i++)
            {
                time.Add(DateTime.ParseExact(input[i], "HH:mm", CultureInfo.InvariantCulture));
            }
            time = time.OrderBy(x => x).ToList();
            var tim = time.ToString("HH:mm");
            System.Console.WriteLine(String.Join(", ", tim));
        }
    }
}
