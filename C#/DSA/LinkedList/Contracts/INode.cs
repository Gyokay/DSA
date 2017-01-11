namespace LinkedList.Contracts
{
    public interface INode<T>
    {
        T Data { get; set; }
        INode<T> Next { get; set; }
    }
}
