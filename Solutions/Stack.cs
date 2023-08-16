using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExamples.Solutions
{
    /// <summary>
    /// When using this class, you may have to type the entire path of this class, like AlgorithProject.Solutions.Stack<int>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Stack<T>
    {
        
        private List<T> list;
        public Stack() => list = new List<T>();
        public T Pop()
        {
            if (!IsEmpty())
            {
                T temp = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return temp;
            }
            throw new IndexOutOfRangeException();
        }
        public void Push(T p) => list.Add(p);
        public bool IsEmpty() => list.Count == 0;
        public T ShowLast() => list[list.Count - 1];
        public int Size() => list.Count;
    }
}
