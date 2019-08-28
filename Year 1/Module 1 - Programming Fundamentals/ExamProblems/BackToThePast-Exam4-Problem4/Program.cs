using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast_Exam4_Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            var legacy = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            int sum = 0;
            var time = year - 1800;
            for (int i = 0; i <= time; i++)
            {
                if(i%2==0)
                {
                    sum += 12000;
                }
                else
                {
                    sum += 12000 + 50 * (18 + i);
                }
            }
            if (sum <= legacy) Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", legacy - sum);
            else Console.WriteLine("He will need {0:f2} dollars to survive.", sum - legacy);
        }
    }
}
