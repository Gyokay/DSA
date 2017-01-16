namespace Stack.Contracts
{
    public interface IStackable<T>
    {
        void Push(T data);

        T Pop();

        T Peek();
    }
}
