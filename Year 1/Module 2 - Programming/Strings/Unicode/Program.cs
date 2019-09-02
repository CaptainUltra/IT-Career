using System;

namespace Unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int intValue = int.Parse(Console.ReadLine());
            string hexValue = intValue.ToString("X");
            Console.WriteLine(hexValue);*/
            string c = Console.ReadLine();
            foreach(char a in c)
            System.Console.WriteLine("\\u" + ((int) a).ToString("X").PadLeft(4, '0'));
        }
    }
}
