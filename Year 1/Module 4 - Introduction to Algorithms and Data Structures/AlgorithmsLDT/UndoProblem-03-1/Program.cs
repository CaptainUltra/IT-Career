using System;
using System.Collections.Generic;

namespace UndoProblem_03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<string> stack = new Stack<string>();
                while(input != "exit")
            {
                if(input == "back")
                {
                    if(stack.Count > 1)
                    {
                        stack.Pop();
                        System.Console.WriteLine(stack.Peek());
                    }
                    else throw new InvalidOperationException("No previous page!");
                }
                else
                {
                    stack.Push(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
