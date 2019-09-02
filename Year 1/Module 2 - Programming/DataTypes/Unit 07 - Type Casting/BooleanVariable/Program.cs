using System;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if(Convert.ToBoolean(s)) System.Console.WriteLine("Yes");
            else System.Console.WriteLine("No");
            //OtherWay
            string input = Console.ReadLine();
            bool variable = Convert.ToBoolean(input);
            if (variable == true) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }
        }
    }
}
