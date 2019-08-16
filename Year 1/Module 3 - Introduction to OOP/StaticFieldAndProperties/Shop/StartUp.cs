using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while(input != "Close")
            {
                var cmdArgs = input.Split();
                switch(cmdArgs[0])
                {
                    case "Sell": Market.Sell(cmdArgs[1], double.Parse(cmdArgs[2])); break;
                    case "Add": Market.Add(cmdArgs[1], cmdArgs[2], double.Parse(cmdArgs[3]), double.Parse(cmdArgs[4])); break;
                    case "Update": Market.Update(cmdArgs[1], double.Parse(cmdArgs[2])); break;
                    case "PrintA": Market.PrintA(); break;
                    case "PrintU": Market.PrintU(); break;
                    case "PrintD": Market.PrintD(); break;
                    case "Calculate": System.Console.WriteLine(Market.Calculate()); break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
