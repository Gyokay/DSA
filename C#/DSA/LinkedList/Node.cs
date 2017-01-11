using LinkedList.Contracts;

namespace LinkedList
{
    public class Node<T> : INode<T>
    {
        private T data;
        private INode<T> next;

        public Node(T data)
        {
            this.Data = data;
            this.next = null;
        }

        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public INode<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
