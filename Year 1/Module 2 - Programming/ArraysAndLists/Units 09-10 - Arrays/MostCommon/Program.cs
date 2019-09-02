using System;
using System.Linq;

namespace MostCommon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxEnc = 0;
            int found = items[0];
            for(int i = 0; i<items.Length; i++)
            {
                int x = items[i];
                int br = 0;
                for(int j = 0;j < items.Length; j++)
                    if(items[j]==x)br++;
                if(br>maxEnc) 
                {
                    maxEnc = br;
                    found = items[i];
                }
            }
            System.Console.WriteLine(found);
        }
    }
}
