using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class DailyTemperatureProblem
    {
        public List<int> DailyTempProblem(List<int> p)
        {
            List<int> result = new List<int>();//{0
            for (int i = 0; i < p.Count; i++)//1
            {
                result.Add(0);
                int count = 0;//1
                for (int j = i + 1; j < p.Count; j++)//1
                {
                    count++;
                    if (p[i] < p[j])
                    {
                        result[i] = count;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
