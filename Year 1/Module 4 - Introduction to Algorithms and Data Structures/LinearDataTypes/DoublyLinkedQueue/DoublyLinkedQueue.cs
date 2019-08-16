using System;

namespace DoublyLinkedQueue
{
    class DoublyLinkedQueue<T>
    {
        private class Node<T>
        {
            private T value;
            private Node<T> next;
            private Node<T> prev;
            public Node(T value)
            {
                this.Value = value;
            }
            public Node<T> Next { get => next; set => next = value; }
            public Node<T> Prev { get => prev; set => prev = value; }
            public T Value { get => value; private set => this.value = value; }
        }
        private Node<T> head;
        private Node<T> tail;
        private int count;
        public DoublyLinkedQueue() {}

        public int Count { get => count; set => count = value; }
        
        public void Add(T element)
        {
            if(this.Count == 0)
            {
                this.head = this.tail = new Node<T>(element);
            }
            else
            {
                var newTail = new Node<T>(element);
                newTail.Prev = this.tail;
                this.tail.Next = newTail;
                this.tail = newTail;
            }
            this.Count++;
        }
        public T RemoveFirst()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("List empty");
            }
            var firstElement = this.head.Value;
            this.head = this.head.Next;
            if(this.head != null)
            {
                this.head.Prev = null;
            }
            else
            {
                this.tail = null;
            }
            this.Count--;
            return firstElement;
        }
        public T[] ToArray()
        {
            var resultArr = new T[this.Count];
            var currentNode = this.head;
            int i = 0;
            while(currentNode != null)
            {
                resultArr[i] = currentNode.Value;
                currentNode = currentNode.Next;
                i++;
            }
            return resultArr;
        }
    }
}