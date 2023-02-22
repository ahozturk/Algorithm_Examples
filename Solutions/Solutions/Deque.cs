using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Deque<T>
    {
        private List<T> list;

        public Deque() => list = new List<T>();

        public void AddRight(T p) => list.Add(p);
        public void AddLeft(T p) => list.Insert(0, p);
        public T PopRight()
        {
            if (!IsEmpty())
            {
                T temp = list[Size() - 1];
                list.RemoveAt(Size() - 1);
                return temp;
            }
            throw new IndexOutOfRangeException();
        }
        public T PopLeft()
        {
            if (!IsEmpty())
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
