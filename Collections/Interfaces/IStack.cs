namespace Collections.Interfaces
{
    public interface IStack<T>
    {
        void Push(T item);

        T Pop();
    }
}