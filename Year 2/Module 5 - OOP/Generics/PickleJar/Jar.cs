
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class Jar<T> : IJar<T>, IEnumerable
    {
        private readonly List<T> items;
        public Jar()
        {
            this.items =  new List<T>();
        }
        public void Add(T item) => this.items.Add(item);
        public int Count => this.items.Count;
        public T Remove()
        {
            var element =  this.items.Last();
            this.items.RemoveAt(this.items.Count - 1);
            return element;
        }
        public IEnumerator GetEnumerator()
        {
            return this.items.GetEnumerator();
        }
    }
    