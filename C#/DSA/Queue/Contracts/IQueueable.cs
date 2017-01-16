namespace Queue.Contracts
{
    public interface IQueueable<T>
    {
        void Enqueue(T data);

        T Dequeue();

        T Front { get; }

        T Rear { get; }
    }
}
