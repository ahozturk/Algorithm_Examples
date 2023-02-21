using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExamples.Solutions
{
    public class MajorityElement
    {
        /// <summary>
        /// Finding Majority element of array, majority means an element of array have 1/2 or much frequancy
        /// </summary>
        /// <returns>Returns majority element</returns>
        public static int FindMajorityElementBoyerMoore(int[] p)
        {
            int count = 1, number = p[0];
            for (int i = 1; i < p.Length; i++)
                if (number == p[i])
                    count++;
                else
                {
                    if (count == 0)
                        number = p[i];
                    else
                        count--;
                }
            return number;
        }

        public int FindMajorityElement(int[] p)
        {
            Dictionary<int, int> elements = new Dictionary<int, int>();
            int max = int.MinValue; //Key
            int maxCount = int.MinValue; //Value
            foreach (int i in p)
            {
                if (elements.ContainsKey(i))
                {
                    elements[i] += 1;
                    if (maxCount < elements[i])
                    {
                        maxCount = elements[i];
                        max = i;
                    }
                }
                else
                    elements.Add(i, 1);
            }

            return max;
        }
    }
}
