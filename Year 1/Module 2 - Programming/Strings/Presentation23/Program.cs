using System;

namespace Prez23Zabraneni_dumi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] prohibited = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();
            string result = "";
            for(int i = 0; i<prohibited.Length;i++)
            {
                result = text.Replace(new string('*', prohibited[i].Length), prohibited[i]);
            }
        }
    }
}
