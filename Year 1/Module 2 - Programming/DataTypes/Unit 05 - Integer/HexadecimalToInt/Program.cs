using System;

namespace HexadecimalToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var hex = Console.ReadLine();
            int dec = Convert.ToInt32(hex, 16);
            System.Console.WriteLine(dec);
        }
    }
}
