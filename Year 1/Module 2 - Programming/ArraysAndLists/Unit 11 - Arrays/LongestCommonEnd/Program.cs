using System;
using System.Linq;

namespace LongestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split(' ').ToArray();
            string[] str2 = Console.ReadLine().Split(' ').ToArray();
            int br = 0;
            int max = 0;
            for(int i = 0; i<Math.Min(str1.Length, str2.Length); i++)
            {
                if(str1[i]==str2[i])
                {
                    br++;    
                }
                else break;
            }
            if(br > max) max = br;
            br = 0;
            for(int i = Math.Min(str1.Length, str2.Length)-1; i>=0; i--)
            {
                if(str1[i]==str2[i])
                {
                    br++;    
                }
                else break;
            }
            if(br > max) max = br;
            System.Console.WriteLine(max);
        }
    }
}
