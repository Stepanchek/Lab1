using System.Collections.Generic;

namespace Collections.Collections
{
    internal sealed class Queue<T> : IQueue<T>
    {
        private readonly LinkedList<T> _collection = new();

        public bool IsEmpty => _collection.Count == 0;
        
        public void Enqueue(T item)
        {
            _collection.AddLast(item);
        }
        
        public T Dequeue()
        {
            var item = _collection.First.Value;
            
            _collection.RemoveFirst();

            return item;
        }
    }
}