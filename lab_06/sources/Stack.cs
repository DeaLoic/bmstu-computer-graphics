using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_06
{
    public class Stack<T>
    {
        private List<T> items; // элементы стека
        private int count;  // количество элементов
        public Stack()
        {
            items = new List<T>();
        }

        public bool IsEmpty
        {
            get { return count == 0; }
        }

        public int Count
        {
            get { return count; }
        }

        public void Push(T item)
        {
            items.Add(item);
            count++;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            T item = items.Last();
            items.RemoveAt(--count);
            return item;
        }
        
        public T Peek()
        {
            return items.Last();
        }
    }
}
