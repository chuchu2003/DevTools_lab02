using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Wintellect.PowerCollections
{
    public class Stack<T> : IEnumerable<T>
    {
        private T[] Array; // stack
        public int Capacity { get { return Array.Length; } } // максимальный размер стека
        private int count = 0; // текущее число элементов в стеке
        public int Count { get { return count; } }

        public Stack(int count)
        {
            this.Array = new T[count];
        }

        public void Push(T item)
        {
            if (this.count == this.Capacity)
            {
                throw new Exception("Стек переполнен");
            }

            this.Array[this.count++] = item;
        }

        public T Top()
        {
            if (this.count == 0)
            {
                throw new Exception("Стек пуст");
            }

            return this.Array[this.count - 1];
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new Exception("Стек пуст");
            }

            T returnValue = this.Top();

            this.Array = this.Array.Where((value, index) => index != this.count).ToArray();
            this.count--;

            return returnValue;
        }
        public IEnumerator<T> GetEnumerator()
        {
            if (count == 0)
                yield break;

            for (int i = count; i > 0; i--)
                yield return Array[i - 1];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}