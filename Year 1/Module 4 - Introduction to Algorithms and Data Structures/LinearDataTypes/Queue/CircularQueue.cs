using System;

namespace Queue
{
    public class CircularQueue<T>
    {
        private const int DefaultCapacity = 4;
        private T[] elements;
        private int startIndex = 0;//Index of first element in the queue
        private int endIndex = 0;//Index after the last added element
        private int count = 0;

        public int Count { get => count; set => count = value; }

        public CircularQueue()
        {
            this.elements = new T[16];
        }
        public CircularQueue(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
        }
        public void Enqueue(T element)
        {
            if(this.Count >= this.elements.Length)
            {
                this.Grow();
            }
            //Add element to the end index and update it
            this.elements[this.endIndex] = element;
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.Count++;
        }
        public T Dequeue()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty!");
            }
            var result = this.elements[startIndex];
            this.startIndex = (this.startIndex + 1) % this.elements.Length; //Remove element by updating start index
            this.Count--;
            return result;
        }
        public T[] ToArray()
        {
            var resultArray = new T[this.elements.Length];
            this.CopyAllElementsTo(resultArray);
            return resultArray;
        }
        private void Grow()
        {
            var newElements = new T[2 * this.elements.Length];
            this.CopyAllElementsTo(newElements);
            this.elements = newElements;
            this.startIndex = 0;
            this.endIndex = this.Count;
        }
        private void CopyAllElementsTo(T[] resultArr)
        {
            int sourceIndex = this.startIndex;
            int destinationIndex = 0;
            for(int i = 0; i < this.Count; i++)
            {
                resultArr[destinationIndex] = this.elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length;
                destinationIndex++;
            }  
        }
    }
}