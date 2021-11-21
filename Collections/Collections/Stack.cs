using System.Collections.Generic;
using Collections.Interfaces;

namespace Collections.Collections
{
    public sealed class Stack<T> : IStack<T>
    {
        private readonly LinkedList<T> _collection = new();

        public bool IsEmpty => _collection.Count == 0;
        
        public void Push(T item)
        {
            _collection.AddFirst(item);
        }
        
        public T Pop()
        {
            var item = _collection.First.Value;
            
            _collection.RemoveFirst();

            return item;
        }
    }
}