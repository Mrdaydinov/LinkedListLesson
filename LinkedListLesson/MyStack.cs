using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLesson
{
    internal class MyStack<T>
    {
        private T[] _items;
        public int Count { get; private set; }

        int _capacity = 4;

        public MyStack()
        {
            _items = new T[_capacity];
        }

        public MyStack(int capacity)
        {
            _capacity = capacity;
            _items = new T[_capacity];
        }

        public void Push(T item)
        {
            if (Count == _items.Length)
            {
                T[] tempItems = new T[_items.Length * 2];
                for (int i = 0; i < Count; i++)
                    tempItems[i] = _items[i];
                _items = tempItems;
            }

            _items[Count++] = item;
        }

        public T Pop()
        {

            if (Count == 0)
                throw new InvalidOperationException("Stack is empty");
            T item = _items[--Count];
            _items[Count] = default(T);

            if (Count > 0 && Count < _items.Length / 2)
            {
                T[] tempItems = new T[_items.Length / 2];
                for (int i = 0; i < Count; i++)
                    tempItems[i] = _items[i];
                _items = tempItems;
            }

            return item;
        }

        public T Peek()
        {
            return _items[Count - 1];
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return _items[i];
            }
        }
    }
}
