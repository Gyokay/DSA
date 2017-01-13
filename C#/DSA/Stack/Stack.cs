using System;
using Stack.Contracts;

namespace Stack
{
    public class Stack<T> : IStack<T>
    {
        private T[] stack;
        private int topIndex;

        public Stack(int capacity)
        {
            this.stack = new T[capacity];
            this.topIndex = 0;
        }

        public Stack(int capacity, T firstElement) : this(capacity)
        {
            this.stack[topIndex++] = firstElement;
        }

        public int Count
        {
            get { return topIndex; }
        }

        public void Push(T data)
        {
            if (this.isFull())
            {
                throw new InvalidOperationException("Stack is full");
            }

            this.stack[topIndex++] = data;
        }

        public T Pop()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return this.stack[--topIndex];
        }

        public T Peek()
        {
            if (this.isEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return this.stack[this.topIndex - 1];
        }

        private bool isFull()
        {
            return this.stack.Length == this.topIndex;
        }

        private bool isEmpty()
        {
            return topIndex == 0;
        }
    }
}
