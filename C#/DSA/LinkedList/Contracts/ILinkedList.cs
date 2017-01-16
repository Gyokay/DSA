namespace LinkedList.Contracts
{
    public interface ILinkedList<T>
    {
        void Add(T data);

        void Prepend(T data);

        T RemoveLast();

        INode<T> Head { get; }
    }
}
