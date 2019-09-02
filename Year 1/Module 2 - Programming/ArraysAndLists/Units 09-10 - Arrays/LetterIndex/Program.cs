using System;

namespace LetterIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string str = Console.ReadLine();
            char[] items = str.ToCharArray(0, str.Length);
            for(int i =0; i<items.Length;i++)
            {
                System.Console.WriteLine("{0} -> {1}", items[i], (int) (char.ToUpper(items[i]) - 64));
            }*/
            //------------------------
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            //char[] letters = Enumerable.Range('a', 'z' - 'A' + 1).Select(i => (Char)i).ToArray();ne raboti
            string str = Console.ReadLine();
            char[] items = str.ToCharArray(0, str.Length);
            for(int i = 0; i<items.Length;i++)
            {
                System.Console.WriteLine("{0} -> {1}", items[i], items[i] - 'a');
            }
        } 
    }
}
