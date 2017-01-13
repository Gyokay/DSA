namespace Stack.Contracts
{
    public interface IStack<T>
    {
        void Push(T data);

        T Pop();

        T Peek();
    }
}
