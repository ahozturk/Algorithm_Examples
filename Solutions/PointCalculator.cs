using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public static class PointCalculator
    {
        //Leetcode Baseball game problem: https://leetcode.com/problems/baseball-game
        public static void Execute()
        {
            var operationTest1 = new string[] { "5", "2", "C", "D", "+" };
            var operationTest2 = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };
            var operationTest3 = new string[] { "1", "C" };
            Console.WriteLine(CalPoints(operationTest1)); //30
            Console.WriteLine(CalPoints(operationTest2)); //27
            Console.WriteLine(CalPoints(operationTest3)); //0

        }
        public static int CalPoints2(string[] operations)
        {
            var scores = new System.Collections.Generic.Stack<int>();
            for (int i = 0; i < operations.Length; i++)
            {
                string o = operations[i];
                if (o == "+")
                {
                    int last = scores.ToArray()[0];
                    int secToLast = scores.ToArray()[1];
                    scores.Push(last + secToLast);
                }
                else if (o == "C")
                    scores.Pop();
                else if (o == "D")
                    scores.Push(scores.Peek() * 2);
                else
                {
                    int.TryParse(o, out int number);
                    scores.Push(number);
                }
            }
            return scores.Sum();
        }
        public static int CalPoints(string[] operations)
        {
            List<int> scores = new();
            for (int i = 0; i < operations.Length; i++)
            {
                string o = operations[i];
                if (o == "+")
                    scores.Add(scores[scores.Count - 1] + scores[scores.Count - 2]);
                else if (o == "C")
                    scores.RemoveAt(scores.Count - 1);
                else if (o == "D")
                    scores.Add(scores[scores.Count - 1] * 2);
                else
                {
                    int.TryParse(o, out int number);
                    scores.Add(number);
                }
            }
            return scores.Sum();
        }
    }
}
