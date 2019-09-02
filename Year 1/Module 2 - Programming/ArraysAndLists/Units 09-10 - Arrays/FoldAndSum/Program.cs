using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] left= new int[items.Length/4];
            int[] right= new int[items.Length/4];
            int[] mid= new int[items.Length/2];
            //Arr.Copy(source, index, destnation, intex, lenght )
            Array.Copy(items,0,left,0,items.Length/4);
            Array.Copy(items,items.Length/4,mid,0,items.Length/2);
            Array.Copy(items,items.Length/4 + items.Length/2,right,0,items.Length/4);
            /*System.Console.WriteLine(String.Join(' ', left));
            System.Console.WriteLine(String.Join(' ', mid));
            System.Console.WriteLine(String.Join(' ', right));*/
            Array.Reverse(left);
            Array.Reverse(right);
            int[] sum = new int[items.Length/2];
            for(int i = 0;i<mid.Length/2;i++)
            {
                sum[i] += left[i] + mid[i];
                sum[i+mid.Length/2] = right[i] + mid[i+mid.Length/2]; 
            }
            System.Console.WriteLine(String.Join(' ', sum));
        }
    }
}
