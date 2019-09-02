using System;

namespace SumOfLastKNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] seq = new int[n];
            seq[0] = 1;
            for(int i = 1; i<=n;i++)
            {
                int j = i - 1;
                seq[i] = seq[j];
                while((j>0) && (i-j<k))
                {
                    j--;
                    seq[i] += seq[j];
                }
            }
            System.Console.WriteLine(String.Join(' ', seq));
        }
    }
}
