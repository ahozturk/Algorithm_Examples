using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Queue<T>
    {
        private List<T> list;
        public Queue()
        {
            list = new List<T>();
        }
        public void Enqueue(T item) => list.Add(item);
        public T Dequeue()
        {
            if (list.Count != 0)
            {
                T temp = list[0];
                list.RemoveAt(0);
                return temp;
            }
            throw new IndexOutOfRangeException();
        }
        public bool IsEmpty() => list.Count == 0;
        public int Size() => list.Count;
    }
}
