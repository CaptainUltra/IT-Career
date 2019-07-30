using System;

namespace DoublyLinkedList
{
    class DoublyLinkedList<T>
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
        public DoublyLinkedList() {}

        public int Count { get => count; set => count = value; }
        public void AddFirst(T element)
        {
            if(this.Count == 0)
            {
                //If list is empty add the element as a head and a tail
                this.head = this.tail = new Node<T>(element);
            }
            else
            {
                //Make a new element and link it with the existing head
                //Assign the new element as the new head
                var newHead = new Node<T>(element);
                newHead.Next = this.head;
                this.head.Prev = newHead;
                this.head = newHead;
            }
            this.Count++;
        }
        public void AddLast(T element)
        {
            if(this.Count == 0)
            {
                //If list is empty add the element as a head and a tail
                this.head = this.tail = new Node<T>(element);
            }
            else
            {
                //Make a new element and link it with the existing tail
                //Assign the new element as the new tail
                var newTail = new Node<T>(element);
                newTail.Prev = this.tail;
                this.tail.Next = newTail;
                this.tail = newTail;
            }
            this.Count++;
        }
        public void ForEach(Action<T> action)
        {
            var currentNode = this.head;
            while(currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next; 
            }
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
                //If tere are many items remove link to the first one
                this.head.Prev = null;
            }
            else
            {
                //If there is only one item in the list
                //Make head == tail == null
                this.tail = null;
            }
            this.Count--;
            return firstElement;
        }
        public T RemoveLast()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("List empty");
            }
            var lastElement = this.tail.Value;
            this.tail = this.tail.Prev;
            if(this.tail != null)
            {
                //If tere are many items remove link to the last one
                this.tail.Next = null;
            }
            else
            {
                //If there is only one item in the list
                //Make head == tail == null
                this.head = null;
            }
            this.Count--;
            return lastElement;
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
        public IEnumerable<T> GetEnumerator()
        {
            var currentNode = this.head;
            while(currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }
    }
}