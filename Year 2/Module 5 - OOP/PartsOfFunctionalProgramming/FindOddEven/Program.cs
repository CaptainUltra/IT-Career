using System;
using System.Linq;

namespace FindOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int[] nums = Enumerable.Range(min, max - min + 1).ToArray();
            int[] result = new int[nums.Count()];
            if(type == "odd")
            {
                result = Array.FindAll(nums, x => x % 2 != 0);
            }
            else
            {
                result = Array.FindAll(nums, x => x % 2 == 0);
            }
            System.Console.WriteLine(String.Join(' ', result));           
        }
    }
}
