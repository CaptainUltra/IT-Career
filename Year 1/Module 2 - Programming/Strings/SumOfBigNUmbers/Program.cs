using System;

namespace SumOfBigNUmbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int n = str1.Length;
            if(str1.Length>str2.Length)
            {
                str2 = string.Concat(new string('0', str1.Length-str2.Length), str2);
            }
            else if(str2.Length>str1.Length)
            {
                str1 = string.Concat(new string('0', str2.Length-str1.Length), str1);
                n = str2.Length;
            }
            string result = "";
            int p = 0;
            for(int i = n - 1; i >=0;i--)
            {
                int k = (str1[i] - '0')+(str2[i] - '0');
                k += p;
                p = k / 10;
                k = k % 10;
                result = string.Concat(k.ToString(), result);
            }
            if(p!=0)result = string.Concat(p.ToString(), result);
            System.Console.WriteLine(result);
        }
    }
}
