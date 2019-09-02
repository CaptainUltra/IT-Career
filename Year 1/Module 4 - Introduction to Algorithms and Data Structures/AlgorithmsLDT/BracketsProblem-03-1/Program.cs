using System;
using System.Collections.Generic;

namespace BracketsProblem_03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == '(')
                {
                    stack.Push(i);
                }
                else if (ch == ')' && stack.Count != 0)
                {
                    int j = stack.Pop();
                    result = input.Substring(j, i - j + 1);
                    System.Console.WriteLine(result);
                }
                else throw new Exception("Invalid bracket count");
            }
        }
    }
}
