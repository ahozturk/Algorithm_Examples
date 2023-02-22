using System;
using System.Collections;
using System.Collections.Generic;

namespace Solutions
{
    public class MyStack
    {
        System.Collections.Generic.Queue<int> q;
        System.Collections.Generic.Queue<int> tempQ;
        public MyStack()
        {
            q = new System.Collections.Generic.Queue<int>();
            tempQ = new System.Collections.Generic.Queue<int>();
        }

        public void Push(int x)
        {
            q.Enqueue(x);
        }

        public int Pop()
        {
            int lenght = q.Count;
            for (int i = 0; i < lenght; i++)
            {
                if (i == lenght - 1) //if it's last item
                {
                    int tempItem = q.Dequeue();
                    q = tempQ;
                    tempQ = new();
                    return tempItem;
                }
                tempQ.Enqueue(q.Dequeue());
            }
            throw new IndexOutOfRangeException();
        }

        public int Top()
        {
            int lenght = q.Count;
            for (int i = 0; i < lenght; i++)
            {
                if (i == lenght - 1) //if it's last item
                {
                    int tempItem = q.Dequeue();
                    tempQ.Enqueue(tempItem);
                    q = tempQ;
                    tempQ = new();
                    return tempItem;
                }
                tempQ.Enqueue(q.Dequeue());
            }
            throw new IndexOutOfRangeException();

        }

        public bool Empty() => q.Count == 0;
    }
}
