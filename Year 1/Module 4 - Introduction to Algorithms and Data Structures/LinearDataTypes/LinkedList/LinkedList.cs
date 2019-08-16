using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList<T>
    {
        class Node<T>
        {
            private T value;
            private Node<T> next;

            public Node(T value, Node<T> prevNode)
            {
                this.Value = value;
                prevNode.Next = this;
            }
            public Node(T value)
            {
                this.Value = value;
                Next = null;
            }
            public T Value { get => this.value; set => this.value = value; }
            public Node<T> Next { get => next; set => next = value; }
        }
        private Node<T> head;
        private Node<T> tail;
        private int count;

        private int Count { get => count; set => count = value; }

        public LinkedList() { }
        public void Add(T value)
        {
            Node<T> newNode;
            if (head == null)
            {
                //If list is empty add new item as head and tail
                newNode = new Node<T>(value);
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode = new Node<T>(value, tail);
                tail = newNode;
            }
            Count++;
        }
        public bool Remove(int index)
        {
            if (index >= 0 && index < this.Count)//Validate index
            {
                if (index == 0)//Check if head needs to be removed
                {
                    head = head.Next;
                    this.count--;
                    return true;
                }
                Node<T> currentNode = head;
                Node<T> prevNode = null;
                for (int i = 1; i <= index; i++)
                {

                    this.Count--;
                    if (prevNode != null)
                    {
                        if (tail == currentNode)
                        {
                            tail = prevNode;
                            return true;
                        }
                        prevNode.Next = currentNode.Next;
                        return true;
                    }

                    prevNode = currentNode;
                    currentNode = currentNode.Next;
                }
            }
            return false;
        }
        public bool Remove(T value)
        {
            //If head matches value and needs to be removed
            if (head.Value.Equals(value))
            {
                if (head.Next != null)
                {
                    head = head.Next;
                }
                this.Count--;
                return true;
            }

            Node<T> currentNode = head;
            Node<T> prevNode = null;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    this.Count--;
                    if (prevNode != null)
                    {
                        if (tail == currentNode)
                        {
                            tail = prevNode;
                            return true;
                        }
                        prevNode.Next = currentNode.Next;
                        return true;
                    }
                }
                prevNode = currentNode;
                currentNode = currentNode.Next;
            }
            return false;
        }
        public int IndexOf(T value)
        {
            int currentIndex = 0;
            Node<T> currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return currentIndex;
                }
                currentNode = currentNode.Next;
                currentIndex++;
            }
            return -1;
        }
        public bool Contains(T value)
        {
            Node<T> currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.Count)
                {
                    Node<T> currentNode = head;
                    for (int i = 0; i < index; i++)
                    {
                        currentNode = currentNode.Next;
                    }
                    return currentNode.Value;
                }
                else throw new IndexOutOfRangeException("Index not found");
            }
            set
            {
                if (index >= 0 && index < this.Count)
                {
                    Node<T> currentNode = head;
                    for (int i = 0; i <= index; i++)
                    {
                        currentNode = currentNode.Next;
                    }
                    currentNode.Value = value;
                }
            }
        }
    }
}