using System;
using System.Linq;

namespace ArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condensed = new int[nums.Length/2];
            for(int i = 0; i<nums.Length-1;i++)
            {
                condensed[i] = nums[i]+ nums[i+1];
            }
            int sum = 0;
            for(int i = 0;i<condensed.Length;i++)
            {
                sum += condensed[i];
            }
            System.Console.WriteLine(sum);
        }
    }
}
