using System;

namespace ArrayList
{
    public class ArrayList<T>
    {
        private const int IniticalCapacity = 2;
        private T[] data;
        private int count;
        public T this[int index]
        {
            get
            {
                ValidateIndex(index);
                return data[index];
            }
            set
            {
                ValidateIndex(index);
                data[index] = value;
            }
        }
        public ArrayList() 
        { 
            this.data = new T[IniticalCapacity];
            this.Count = 0;
        }
        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }
        public void Add(T item)
        {
            if(this.Count == this.data.Length)
            {
                this.Resize();
            }

            data[Count] = item;
            this.Count++;
        }
        public T RemoveAt(int index)
        {
            ValidateIndex(index);
            T element = this.data[index];
            this.data[index] = default(T);
            this.Sift(index);
            this.Count--;
            if (this.Count <= this.data.Length / 4)
            {
                this.Shrink();
            }
            return element;

        }
        public int Capacity()
        {
            return this.data.Length;
        }

        private void Resize()
        {
            T[] newDataArr = new T[data.Length * 2];
            for (int i = 0; i < data.Length; i++)
            {
                newDataArr[i] = data[i];
            }
            this.data = newDataArr;
        }

        private void ValidateIndex(int index)
        {
            if (index >= Count) throw new IndexOutOfRangeException("Check the index");
        }
        private void Sift(int index)
        {
            for (int i = index; i < this.Count; i++)
            {
                this.data[i] = this.data[i + 1];
            }
        }
        private void Shrink()
        {
            T[] newDataArr = new T[this.data.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                newDataArr[i] = this.data[i];
            }
            this.data = newDataArr;
        }
    }
}