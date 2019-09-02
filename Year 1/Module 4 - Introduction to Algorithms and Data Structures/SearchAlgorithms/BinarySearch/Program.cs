using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int x = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;
            if(Find(a, left, right, x))
            {
                System.Console.WriteLine("Ima");
            }
            else
            {
                System.Console.WriteLine("nema");
            }
        }
        //True or false wheter it's contained or not
        private static bool Find(int[] a, int left, int right, int x)
        {
            if(right < left) return false; 
            int mid = (right - left) / 2;
            if(a[mid] == x)
            {
                return true;
            }
            if(a[mid] > x)
            {
                right = mid - 1;
                return Find(a, left, right, x);
            }
            if(a[mid] < x)
            {
                left = mid + 1;
                Find(a, left, right, x);
            }
            return false;
        }
        //Return index of the wanted element, if not contained return -1
        private static int binarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l) { 
            int mid = l + (r - l) / 2; 
  
            // If the element is present at the middle itself 
            if (arr[mid] == x) 
                return mid; 
  
            // If element is smaller than mid, then it can only be present in left subarray 
            if (arr[mid] > x) 
                return binarySearch(arr, l, mid - 1, x); 
  
            // Else the element can only be present in right subarray 
            return binarySearch(arr, mid + 1, r, x); 
        } 
  
        // We reach here when element is not present in array 
        return -1;
        }
    }
}
