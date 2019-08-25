using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var elt = int.Parse(Console.ReadLine());
            bool flag = false;
            for(int i = 1; i< arr.Length; i++)
            {
                if(arr[i] == elt) 
                {
                    flag = true;
                    break;
                }
            }
            if(flag) System.Console.WriteLine("{0} Exists in the List ", elt);
            else System.Console.WriteLine("{0} Not exists in the List", elt);*/
            //-----------------------------------------------------------------
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = new int[arr.Length + 1];
            var elt = int.Parse(Console.ReadLine());
            for(int i = 0; i< arr.Length; i++)
            {
                if(arr[i] < elt) arr2[i] = arr[i];
                else
                {
                    for (int j = args.Length - 1; j >= i; j--)
                    {
                        arr2[j+1] = arr[j];
                    }
                    arr2[i] = elt;
                    break;
                }
            }
            System.Console.WriteLine(String.Join(' ', arr2));
        }
    }
}
