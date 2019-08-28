using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm_Exam5_Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededHrs = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var extra = int.Parse(Console.ReadLine());
            double daysLeft = days * 0.9;
            double workHrs = daysLeft * 8;
            var extraHrs = extra * 2 * days;
            var allHrs = Math.Floor(extraHrs + workHrs);
            if (allHrs >= neededHrs) Console.WriteLine("Yes!{0} hours left.", allHrs - neededHrs);
            else Console.WriteLine("Not enough time!{0} hours needed.", neededHrs - allHrs);
        }
    }
}
