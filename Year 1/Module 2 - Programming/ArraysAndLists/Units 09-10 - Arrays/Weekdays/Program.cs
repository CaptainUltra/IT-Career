using System;

namespace Weekdays
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            if(n<1||n>7) System.Console.WriteLine("Invalid!");
            else System.Console.WriteLine("{0}", days[n-1]);
        }
    }
}
