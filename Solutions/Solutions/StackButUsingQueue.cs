using System;
using System.Collections;
using System.Collections.Generic;

namespace Solutions
{
    public class MyStack<T>
    {
        System.Collections.Generic.Queue<T> q;
        System.Collections.Generic.Queue<T> tempQ;
        public MyStack()
        {
            q = new System.Collections.Generic.Queue<T>();
            tempQ = new System.Collections.Generic.Queue<T>();
        }

        public void Push(T x)
        {
            q.Enqueue(x);
        }

        public T Pop()
        {
            int lenght = q.Count;
            for (int i = 0; i < lenght - 1; i++)
                tempQ.Enqueue(q.Dequeue());
            T temp = q.Dequeue();
            q = tempQ;
            return temp;
        }

        public T Top()
        {
            int lenght = q.Count;
            if (lenght != 0)
            {
                for (int i = 0; i < lenght - 1; i++)
                    tempQ.Enqueue(q.Dequeue());
                T temp = q.Dequeue();
                tempQ.Enqueue(temp);
                q = tempQ;
                tempQ = new();
                return temp;
            }
            else
                throw new IndexOutOfRangeException();
        }

        public bool Empty() => q.Count == 0;
    }
}
