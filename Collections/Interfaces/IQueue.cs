namespace Collections
{
    public interface IQueue<T>
    {
        void Enqueue(T item);

        T Dequeue();
    }
}