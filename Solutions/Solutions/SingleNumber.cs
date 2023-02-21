using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExamples.Solutions
{
    public class SingleNumber
    {
        public int FindSingleNumber(int[] p)
        {
            int result = 0;
            foreach (int i in p)
            {
                result ^= i;
            }
            return result;
        }
    }
}
