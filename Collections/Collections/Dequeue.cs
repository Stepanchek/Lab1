using System.Collections.Generic;
using Collections.Interfaces;

namespace Collections.Collections
{
    public sealed class Dequeue<T> : IQueue<T>, IStack<T>
    {
        private readonly LinkedList<T> _collection = new();

        public bool IsEmpty => _collection.Count == 0;

        public void PushFront(T item)
        {
            _collection.AddFirst(item);
        }

        public void PushBack(T item)
        {
            _collection.AddLast(item);
        }

        public T PopFront()
        {
            var item = _collection.First.Value;
            
            _collection.RemoveFirst();

            return item;
        }

        public T PopBack()
        {
            var item = _collection.Last.Value;
            
            _collection.RemoveLast();

            return item;
        }

        void IQueue<T>.Enqueue(T item)
        {
            PushBack(item);
        }
        
        T IQueue<T>.Dequeue()
        {
            return PopFront();
        }
        
        void IStack<T>.Push(T item)
        {
            PushFront(item);
        }
        
        T IStack<T>.Pop()
        {
            return PopFront();
        }
    }
}