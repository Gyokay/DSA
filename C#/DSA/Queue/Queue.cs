using System;
using Queue.Contracts;
using LinkedList.Contracts;

namespace Queue
{
    public class Queue<T> : IQueueable<T>
    {
        private ILinkedList<T> list;
        private T front; 
        private T rear;

        public Queue(ILinkedList<T> linkedList)
        {
            this.list = linkedList;
        }

        public Queue(ILinkedList<T> linkedList, T firstElement) : this(linkedList)
        {
            this.list.Add(firstElement);
        }

        public void Enqueue(T data)
        {
            this.list.Prepend(data);

            if (this.list.Head == null)
            {
                this.front = data;
            }

            this.rear = data;
        }

        public T Dequeue()
        {
            try
            {
                return this.list.RemoveLast();
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            finally
            {
                if (this.list.Head == null)
                {
                    this.rear = default(T);
                    this.front = default(T);
                }
                else
                {
                    var currentNode = this.list.Head;

                    while (currentNode.Next != null)
                    {
                        currentNode = currentNode.Next;
                    }

                    this.front = currentNode.Data;
                }
            }
        }

        public T Front
        {
            get { return this.front; }
            private set { this.front = value; }
        }

        public T Rear
        {
            get { return this.rear; }
            private set { this.rear = value; }
        }
    }
}
