using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExamples.Solutions
{
    public class DublicateNumbers
    {
        public bool DublicateDetector3(int[] p)
        {
            HashSet<int> set = new HashSet<int>();
            set = p.ToHashSet();
            return set.Count != p.Length;
        }
        public bool DublicateDetector2(int[] p)
        {
            Array.Sort(p);
            for (int i = 0; i < p.Length - 1; i++)
            {
                if (p[i] == p[i + 1])
                    return true;
            }
            return false;
        }
        public bool DublicateDetector(int[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                for (int j = 0; j < p.Length; j++)
                {
                    if (p[j] == p[i] && i != j)
                        return true;
                }
            }
            return false;
        }
    }
}
