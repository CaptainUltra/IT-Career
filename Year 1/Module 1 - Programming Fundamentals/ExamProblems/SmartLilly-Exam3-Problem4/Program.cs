using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly_Exam3_Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var price_washer = double.Parse(Console.ReadLine());
            var price_toy = int.Parse(Console.ReadLine());
            int toys = 0;
            int money = 0;
            int rise = 10;
            var allMoney = 0;
            for (int i = 0; i < age; i++)
            {
                if(i % 2 == 0)
                {
                    toys++;
                }
                else
                {
                    money += rise;
                    rise += 10;
                    money -= 1;
                }
            }
            allMoney = (price_toy * toys) + money;
            if (allMoney >= price_washer) Console.WriteLine("Yes! {0:f2}", allMoney-price_washer);
            else Console.WriteLine("No! {0:f2}", price_washer-allMoney);
        }
    }
}
