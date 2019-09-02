using System;

namespace Zad05
{
    class DecimalToHexAndBinary
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string s = Convert.ToString(a,16);
            System.Console.WriteLine("{0} -> 0x{1}",a,s.ToUpper());
            System.Console.WriteLine("{0} -> {1}", a, Convert.ToString(a,2));
        }
    }
}
