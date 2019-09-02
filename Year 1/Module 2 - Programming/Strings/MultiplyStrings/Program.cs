using System;

namespace MultiplyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string str1 = input[0];
            string str2 = input[1];
            System.Console.WriteLine(Sum(str1, str2));
        }

        private static int Sum(string str1, string str2)
        {
            int sum =0;
            if(str1.Length > str2.Length)
            {
                for(int i = 0; i<str2.Length; i++)
                {
                    sum += str1[i]*str2[i];
                }
                for(int i = str2.Length; i<str1.Length; i++)
                {
                    sum += str1[i];
                }
            }
            else if(str1.Length < str2.Length)
            {
                for(int i = 0; i<str1.Length; i++)
                {
                    sum += str1[i]*str2[i];
                }
                for(int i = str1.Length; i<str2.Length; i++)
                {
                    sum += str2[i];
                }
            }
            else
            {
                for(int i = 0; i<str1.Length; i++)
                {
                    sum += str1[i]*str2[i];
                }
            }
            return sum;
        }
    }
}
