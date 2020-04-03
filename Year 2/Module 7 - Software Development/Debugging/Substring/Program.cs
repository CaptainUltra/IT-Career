using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine()) + 1;

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                var texty = (char)text[i];
                if (texty == (char)Search)
                {
                    hasMatch = true;

                    if (i + jump >= text.Length)
                    {
                        jump = Math.Abs(text.Length - i);
                    }

                    string matchedString = text.Substring(i, jump);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
