using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DetailedList
{
    public class DetailedListClass<T> : IEnumerable
        where T : IComparable<T>
    {
        private List<T> items;
        public DetailedListClass()
        {
            this.items = new List<T>();
        }
        public void Add(T element)
        {
            this.items.Add(element);
        }
        public T Remove(int index)
        {
            var element = this.items.Last();
            this.items.RemoveAt(this.items.Count - 1);
            return element;
        }
        public bool Contains(T element)
        {
            if (this.items.Contains(element))
            {
                return true;
            }
            return false;
        }
        public void Swap(int index1, int index2)
        {
            var tmp = this.items[index1];
            this.items[index1] = this.items[index2];
            this.items[index2] = tmp;
        }
        public void Sort()
        {
            this.items.Sort();
        }
        public int CountGreaterThan(T element)
        {
            int count = 0;
            foreach (var item in this.items)
            {
                if (item.CompareTo(element) > 0) count++;
            }
            return count;
        }
        public T Max()
        {
            var max = this.items.Max();
            return max;
        }
        public T Min()
        {
            var min = this.items.Min();
            return min;
        }
        public IEnumerator GetEnumerator()
        {
            return this.items.GetEnumerator();
        }
        /*public override ToString()
        {
            return $"{}";
        }*/

    }
}