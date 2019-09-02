using System;

namespace MagicChangingWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            for(int i = 0;i<str1.Length;i++)
            {
                int k = str1.IndexOf(str1[i]);
                while(k>=0) 
                {
                    str1 = str1.Remove(k, 1);
                    k = str1.IndexOf(str1[i].ToString(),2);
                }
            }
            for(int i = 0;i<str1.Length;i++)
            {
                int k = str2.IndexOf(str2[i]);
                while(k>=0) 
                {
                    str2 = str2.Remove(k, 1);
                    k = str2.IndexOf(str2[i].ToString(),2);
                }
            }
            if(str1.Length == str2.Length) System.Console.WriteLine("True");
            else System.Console.WriteLine("False");
        }
    }
}
