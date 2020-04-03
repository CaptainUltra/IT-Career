using System;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ArraySlider
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            BigInteger[] numbers = Regex.Split(input, "\\s+").Where(n=> n!="").Select(n => BigInteger.Parse(n)).ToArray();
            var command = Console.ReadLine();
            long arrayIndex = 0;
            while (command != "stop")
            {
                var commandArgs = command.Split(' ');
                var positionArgument = long.Parse(commandArgs[0]);
                var mathOperationSymbol = commandArgs[1];
                var mathArgument = long.Parse(commandArgs[2]);
                positionArgument = positionArgument % numbers.Length;
                arrayIndex += positionArgument;
                var position = arrayIndex % numbers.Length;
                if (position < 0)
                {
                    position += numbers.Length;
                }
                if (position >= numbers.Length)
                {
                    position -= numbers.Length;
                }
                switch (mathOperationSymbol)
                {
                    case "+":
                        if ((numbers[position] + mathArgument) < 0)
                        {
                            numbers[position] = 0;
                        }
                        else numbers[position] = numbers[position] + mathArgument;
                        break;
                    case "-":
                        if (numbers[position] < mathArgument)
                        {
                            numbers[position] = 0;
                        }
                        else numbers[position] = numbers[position] - mathArgument;
                        break;
                    case "*":
                         if ((numbers[position] * mathArgument) < 0)
                        {
                            numbers[position] = 0;
                        }
                        else numbers[position] = numbers[position] * mathArgument;
                        break;
                    case "/": 
                        if ((numbers[position] / mathArgument) < 0)
                        {
                            numbers[position] = 0;
                        }
                        else numbers[position] = numbers[position] / mathArgument;
                        break;
                    case "&":
                         if ((numbers[position] & mathArgument) < 0)
                        {
                            numbers[position] = 0;
                        }
                        else numbers[position] = numbers[position] & mathArgument;
                        break;
                    case "|":
                        if ((numbers[position] | mathArgument) < 0)
                        {
                            numbers[position] = 0;
                        }
                        else numbers[position] = numbers[position] | mathArgument;
                        break;
                    case "^": 
                        if ((numbers[position] ^ mathArgument) < 0)
                        {
                            numbers[position] = 0;
                        }
                        else numbers[position] = numbers[position] ^ mathArgument;
                        break;
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
