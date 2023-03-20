using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class LZWAlgorithm
    {
        public string Decrypt(string text)//banana_bandana
        {
            List<string> dict = CreateFirstDictionary(text);

            string cumulative = "";
            Queue<int> result = new Queue<int>();
            for(int i = 0; i < dict.Count; i++)
            {
                if (dict.Contains(cumulative + text[i].ToString()))
                {
                    cumulative = cumulative + text[i].ToString();
                }
                else
                {
                    result.Enqueue(dict.IndexOf(cumulative));
                    dict.Add(cumulative + text[i].ToString());
                    cumulative = text[i].ToString();
                }
                if(i == dict.Count - 1)
                    result.Enqueue(dict.IndexOf(cumulative));
            }

            Console.WriteLine(string.Join(",", result.GetAll()));
            string metin = "";
            foreach (var i in result.GetAll())
            {
                metin += dict[i];
            }
            return metin;
        }

        List<string> CreateFirstDictionary(string text)
        {
            List<string> dictionary = new List<string>();
            foreach (char word in text)
                if (!dictionary.Contains(word.ToString()))
                    dictionary.Add(word.ToString());
            return dictionary;
        }
    }
}
