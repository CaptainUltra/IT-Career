using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets_Exam4_Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var cat = Console.ReadLine();
            var people = int.Parse(Console.ReadLine());
            double ticketPrice = 0;
            if (people < 5) budget -= budget * 0.75;
                else if(people < 10) budget -= budget * 0.60;
                    else if (people < 25) budget -= budget * 0.50;
                        else if (people < 50) budget -= budget * 0.40;
                            else budget -= budget * 0.25;
            if (cat == "VIP") ticketPrice = 499.99;
            else ticketPrice = 249.99;
            if (budget >= ticketPrice * people) Console.WriteLine("Yes!You have {0:f2} leva left.", budget - ticketPrice * people);
            else Console.WriteLine("Not enough money! You need {0:f2} leva.", ticketPrice * people - budget);
        }
    }
}
