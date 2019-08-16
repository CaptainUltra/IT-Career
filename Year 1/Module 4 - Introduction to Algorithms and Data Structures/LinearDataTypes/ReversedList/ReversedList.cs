using System;
using System.Collections.Generic;
using System.Text;

namespace ReversedList
{
    class ReversedList<T>
    {
        private const int DefaultCapacity = 4;
        private T[] elements;
        private int count;
        public ReversedList(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
        }
        public ReversedList(List<T> collection)
        {
            this.elements = new T[collection.Count];
            for (int i = 0; i < collection.Count; i++)
            {
                elements[i] = collection[i];
            }
        }

        public int Count { get => Count1; set => Count1 = value; }
        public void Add(T element)
        {
            if(this.Count == this.elements.Length)
            {
                this.Grow();
            }
            //Add element to the first index available from the back
            this.elements[this.elements.Length - 1 - this.Count] = element;
            this.Count++;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int currentCount = this.Count;
            int pos = this.elements.Length - 1;
            while(currentCount > 1)
            {
                sb.Append(this.elements[pos] + ", ");
                currentCount--;
                pos--;
            }
            sb.Append(this.elements[pos]);
            return sb.ToString();
        } 
        public int Capacity()
        {
            return this.elements.Length;
        }
        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Invalid index!");
                }
                return this.elements[this.elements.Length - 1 - index];
            }
            set
            {
                if(index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Invalid index!");
                }
                this.elements[this.elements.Length - 1 - index] = value;
            }
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            for (int i = this.elements.Length - index - 1; i > this.elements.Length - count; i--)
            {
                this.elements[i] = this.elements[i-1];
            }
            this.Count--;
        }
        private void Grow()
        {
            T[] newElements = new T[this.elements.Length *2];
            for (int i = newElements.Length - 1; i > this.elements.Length ; i--)
            {
                newElements[i] = elements[i - this.elements.Length];
            }
            this.elements = newElements;
        }

    }
}