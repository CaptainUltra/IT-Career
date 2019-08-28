using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hrs_exam = int.Parse(Console.ReadLine());
            var min_exam = int.Parse(Console.ReadLine());
            int exam = hrs_exam * 60 + min_exam;
            var hrs_arrival = int.Parse(Console.ReadLine());
            var min_arrival = int.Parse(Console.ReadLine());
            int arrival = hrs_arrival * 60 + min_arrival;
            if (arrival>exam)
            {
                Console.WriteLine("Late");
                if (arrival - exam >= 60)
                {
                    if ((arrival - exam) % 60 < 10) Console.WriteLine($"{(arrival - exam) / 60}:0{(arrival - exam) % 60} hours after the start");
                    else Console.WriteLine($"{(arrival - exam) / 60}:{(arrival - exam) % 60} hours after the start");
                }
                else Console.WriteLine($"{arrival - exam} minutes after the start");
            }
            else if (arrival == exam || arrival >= exam-30)
            {
                Console.WriteLine("On time");
                if (exam - arrival < 60 && (exam - arrival) % 60 != 0) Console.WriteLine($"{exam-arrival} minutes before the start");
            }
            else
            {
                Console.WriteLine("Early");
                if (exam - arrival >= 60)
                {
                    if ((exam - arrival) % 60 < 10)
                        Console.WriteLine($"{(exam - arrival) / 60}:0{(exam - arrival) % 60} hours before the start");
                    else Console.WriteLine($"{(exam - arrival) / 60}:{(exam - arrival) % 60} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{exam - arrival} minutes before the start");
                    if (exam - arrival < 10) Console.WriteLine($"0{exam - arrival} minutes before the start");
                }
            }
        }
    }
}
