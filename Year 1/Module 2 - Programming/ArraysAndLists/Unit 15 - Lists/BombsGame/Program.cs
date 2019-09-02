using System;
using System.Linq;
using System.Collections.Generic;

namespace BombsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> param = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for(int i = 0; i<nums.Count;i++)
            {
                if(nums[i]== param[0])
                {
                    for(int j = 0; j< param[1]*2+1;j++)
                    if(i-param[1]<nums.Count)nums.RemoveAt(i-param[1]);
                    else break;
                }
            }
            System.Console.WriteLine(nums.Sum());
        }
    }
}
