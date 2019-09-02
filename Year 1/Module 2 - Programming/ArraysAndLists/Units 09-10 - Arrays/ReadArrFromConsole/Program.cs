using System;
using System.Linq;

namespace ReadArrFromConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var n = int.Parse(Console.ReadLine());
            var nums = new int[n];
            for(int i = 0; i<n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Готово, въведохме мавсива.");
            //System.Console.WriteLine(nums);//System.Int32[]
            System.Console.WriteLine(String.Join(" ", nums));*/
            //---Vtori nachin
            /*string values=Console.ReadLine();
            string[] items= values.Split(' ');
            long sum =0;
            var nums = new int [items.Length];
            for(int i =0; i<items.Length;i++)
            {
                nums[i] = ibnt.Parse(items[i]);
                sum += nums[i];
            }*/
            //--------------------------
            int[] items = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Сумата е: "+ items.Sum());
        }
    }
}
