using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private readonly List<T> data;
        private int index = -1;

        public Stack()
        {
            this.data = new List<T>();
        }

        public void Push(params T[] items)
        {
            foreach (var item in items)
            {
                data.Insert(++index, item);
            }
        }

        public void Pop()
        {
            if (index < 0)
            {
                throw new InvalidOperationException("No elements");
            }

            index--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = index; i >= 0; i--)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
