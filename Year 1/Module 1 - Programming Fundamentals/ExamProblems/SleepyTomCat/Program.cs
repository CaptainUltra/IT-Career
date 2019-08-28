using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nachin ot video
            //Config-like
            var totalNumberOfDays = 365;
            var playedMinsHoliday = 127;
            var playedMinsWorkday = 63;
            var normMinsPlayed = 30000;
            //Config-like--end
            var numberOfHolidays = int.Parse(Console.ReadLine());
            var numberOfWorkdays = totalNumberOfDays - numberOfHolidays;
            var numberPlayedMinsHoliday = numberOfHolidays * playedMinsHoliday;
            var numberPlayedMinsWorkday = numberOfWorkdays * playedMinsWorkday;
            var numberOfMinsPlayed = numberPlayedMinsHoliday + numberPlayedMinsWorkday;
            if(numberOfMinsPlayed>normMinsPlayed)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{(numberOfMinsPlayed - normMinsPlayed) / 60} hours and {(numberOfMinsPlayed - normMinsPlayed) % 60} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{(normMinsPlayed - numberOfMinsPlayed) / 60} hours and {(normMinsPlayed - numberOfMinsPlayed) % 60} minutes less for play");
            }
        }
    }
}
