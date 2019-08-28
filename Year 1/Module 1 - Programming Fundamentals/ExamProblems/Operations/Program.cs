using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var d = Console.ReadLine();
            var e="";
            switch(d)
            {
                case "+":
                    if ((a + b) % 2 == 0) e = "even";
                    else e = "odd";
                    Console.WriteLine($"{a} + {b} = {a+b} - {e}");
                    break;
                case "-":
                    if ((a - b) % 2 == 0) e = "even";
                    else e = "odd";
                    Console.WriteLine($"{a} - {b} = {a - b} - {e}");
                    break;
                case "*":
                    if ((a * b) % 2 == 0) e = "even";
                    else e = "odd";
                    Console.WriteLine($"{a} * {b} = {a * b} - {e}");
                    break;
                case "/":
                    if (b == 0) Console.WriteLine($"Cannot divide {a} by zero"); 
                    else Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                    break;
                case "%":
                    if (b == 0) Console.WriteLine($"Cannot divide {a} by zero");
                    else Console.WriteLine($"{a} % {b} = {a % b}");
                    break;
            }
        }
    }
}
