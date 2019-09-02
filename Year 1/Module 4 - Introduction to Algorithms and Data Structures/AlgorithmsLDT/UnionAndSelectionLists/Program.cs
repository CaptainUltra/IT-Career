using System;
using System.Collections.Generic;

namespace UnionAndSelectionLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int>{1, 2, 3, 4, 5};
            var list2 = new List<int>{1, 5, 6, 7, 8};
        }
        private static List<int> UnionList(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>(list1);
            foreach (var num in list2)
            {
                if(!result.Contains(num))
                {
                    result.Add(num);
                }
            }
            return result;
        }
        private static List<int> SelectionList(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();
            foreach (var item in list1)
            {
                if(list2.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
