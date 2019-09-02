using System;
using System.Linq;

namespace ArrayProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());
            string[] command = new string[3];
            for(int i =0;i<n;i++)
            {
                command = Console.ReadLine().Split(' ').ToArray();
                switch(command[0])
                {
                    case "Distinct": str = str.Distinct().ToArray();break;
                    case "Reverse": Array.Reverse(str);break;
                    case "Replace": str[int.Parse(command[1])]=command[2];break;
                }
            }
            System.Console.WriteLine(String.Join(", ", str));
        }
    }
}
