using System;

namespace MergeSortRecursive
{
    public class MergeSort<T> where T : IComparable
    {
        private static T[] aux;
        public static void Sort(T[] arr)
        {

        }
        private static void Merge(T[] arr, int lo, int mid, int hi)
        {
            if (IsLess(arr[mid], arr[mid + 1]))
            {
                return;
            }
            else
            {
                for (int index = lo; index < hi + 1; index++)
                {
                    aux[index] = arr[index];
                }
            }
            int i = lo;
            int j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if (k > mid)
                {
                    arr[k] = aux[j++];
                }
                else if (k > hi)
                {
                    arr[k] = aux[i++];
                }
                else if (IsLess(aux[i], aux[j]))
                {
                    arr[k] = aux[i++];
                }
                else
                {
                    arr[k] = aux[j++];
                }
            }
        }
        private static void Sort(T[] arr, int lo, int hi)
        {
            if (lo >= hi)
            {
                return;
            }
            else
            {
                Sort(arr, lo, mid);
                Sort(arr, mid + 1, hi);
                Merge(arr, lo, mid, hi);
            }
        }
        public static void Sort(T[] arr)
        {
            aux = new T[arr.Length];
            Sort(arr, 0, arr.Length - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
