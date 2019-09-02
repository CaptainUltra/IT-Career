using System;
using System.Linq;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            var input = Console.ReadLine();
            while(input != "END OF GAME")
            {
                if(!words.ContainsKey(input))
                {
                    words.Add(input, 0);
                }
                var pts = 0;
                foreach (var letter in input)
                {
                    pts += (int)letter;
                }
                if(input[0]>='A' && input[0]<='Z') pts+=15;
                if(input[input.Length-1] == 't') pts += 20;
                if(input.Length >= 10) pts += 30;
                words[input] = pts;
                input = Console.ReadLine();
            }
            foreach (var kvp in words.OrderByDescending(x =>x.Value))
            {
                System.Console.WriteLine("Winner is word: {0}", kvp.Key);
                System.Console.WriteLine("Points: {0}", kvp.Value);
                break;
            }
        }
    }
}
