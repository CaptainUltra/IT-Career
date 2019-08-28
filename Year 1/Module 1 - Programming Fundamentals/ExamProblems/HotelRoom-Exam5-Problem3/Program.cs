using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom_Exam5_Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;
            if (month == "May" || month == "October")
            {
                if (nights <= 7) studioPrice = nights * 50;
                else if (nights < 14) studioPrice = 0.95 * (nights * 50);
                else studioPrice = 0.7 * (nights * 50);
                apartmentPrice = nights * 65;
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14) studioPrice = 0.8 * (nights * 75.2);
                else studioPrice = nights * 75.2;
                apartmentPrice = nights * 68.7;
            }
            else
            {
                studioPrice = nights * 76;
                apartmentPrice = nights * 77;
            }
            if (nights > 14) apartmentPrice = 0.9 * apartmentPrice;
            Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
        }
    }
}
