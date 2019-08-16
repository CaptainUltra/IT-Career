using System;

namespace Stack
{
    public class ArrayStack<T>
    {
        private const int InititalCapacity = 4;
        private T[] elements;
        private int count = 0;

        public int Count { get => count; set => count = value; }
        public ArrayStack(int capacity = InititalCapacity)
        {
            this.elements = new T[capacity];
        }
        public void Push(T element)
        {
            if(this.Count == this.elements.Length)
            {
                this.Grow();
            }
            this.elements[this.Count] = element;
            this.Count++;
        }
        public T Pop()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("Stack empty!");
            }
            this.Count--;
            return this.elements[this.Count];
        }
        public T[] ToArray()
        {
            var resultArr = new T[2 * this.elements.Lengths];
            this.CopyAllElementsTo(resultArr);
            return resultArr;
        }
        private void Grow()
        {
            var newElements = new T[2 * this.elements.Length];
            this.CopyAllElementsTo(newElements);
            this.elements = newElements;
        }
        private void CopyAllElementsTo(T[] resultArr)
        {
            for(int i = 0; i < this.Count; i++)
            {
                resultArr[i] = this.elements[i];
            }  
        }
    }
}