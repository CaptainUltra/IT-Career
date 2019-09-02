using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            System.Console.WriteLine(IfPalindrome(str));
        }

        private static bool IfPalindrome(string str)
        {
            bool flag = false;
            for(int i = 0; i<str.Length/2;i++)
            {
                if(str[i]==str[str.Length-1-i]) flag = true;
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
