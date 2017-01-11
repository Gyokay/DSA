using LinkedList.Contracts;
using System;

namespace LinkedList
{
    public class LinkedList<T> where T : IComparable
    {
        private INode<T> head;

        public LinkedList()
        {
            this.head = null;
        }

        public INode<T> Head
        {
            get
            {
                return head;
            }
        }

        public void Add(T data)
        {
            if (this.head == null)
            {
                this.head = new Node<T>(data);
                return;
            }

            INode<T> currentNode = this.head;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = new Node<T>(data);
        }

        public int Length()
        {
            int length = 0;
            var currentNode = this.head;

            while (currentNode != null)
            {
                currentNode = currentNode.Next;
                length++;
            }

            return length;
        }

        public void Prepend(T data)
        {
            var newHead = new Node<T>(data);

            if (this.head == null)
            {
                this.head = newHead;
                return;
            }

            newHead.Next = this.head;
            this.head = newHead;
        }

        public void InsertAfter(T key, T data)
        {
            var currentNode = this.head;

            while (currentNode != null && currentNode.Data.CompareTo(key) != 0)
            {
                currentNode = currentNode.Next;
            }

            if (currentNode != null)
            {
                var newNode = new Node<T>(data);
                newNode.Next = currentNode.Next;
                currentNode.Next = newNode;
            }
        }

        public void InsertBefore(T key, T data)
        {
            INode<T> previousNode = null;
            INode<T> currentNode = this.head;

            while (currentNode != null && currentNode.Data.CompareTo(key) != 0)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            if (previousNode == null && currentNode != null)
            {
                this.Prepend(data);
                return;
            }

            if (currentNode != null)
            {
                var newNode = new Node<T>(data);

                newNode.Next = currentNode;
                previousNode.Next = newNode;
            }

        }

        public void Delete(T key)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            INode<T> currentNode = this.head;

            while (currentNode.Next != null)
            {
                Console.Write($"{currentNode.Data}, ");
                currentNode = currentNode.Next;
            }

            Console.Write(currentNode.Data);
            Console.WriteLine();
        }

    }
}
