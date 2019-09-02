using System;
using System.Linq;

namespace SafeArrayProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ').ToArray();
            string[] command = new string[3];
            do
            {
                command = Console.ReadLine().Split(' ').ToArray();
                switch(command[0])
                {
                    case "Distinct": str = str.Distinct().ToArray();break;
                    case "Reverse": Array.Reverse(str);break;
                    case "Replace":
                    { 
                    int num= int.Parse(command[1]);
                    if(num > str.Length || num < 0) System.Console.WriteLine("Invalid input!");
                    else str[num]=command[2];
                    break;
                    }
                    default: System.Console.WriteLine("Invalid input!"); break;
                }
            }while(command[0] != "END");
            System.Console.WriteLine(String.Join(", ", str));
        }
    }
}