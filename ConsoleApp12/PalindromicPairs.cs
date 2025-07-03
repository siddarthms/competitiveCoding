using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class PalindromicPairs
    {
        internal void init()
        {
            string[] words = new string[3] { "bat", "tab", "cat" };

            var pairs = GetThePalindromicPairs(words);

            var arrayFormat = pairs.Select(p => new int[] { p.Item1, p.Item2 }).ToList();

            Console.WriteLine(JsonConvert.SerializeObject(arrayFormat));
                
        }

        List<(int, int)> GetThePalindromicPairs(string[] input)
        {
            List<(int, int)> pairs = new List<(int, int)>();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (IsPalindrom(input[i], input[j]))
                    {
                        pairs.Add((i,j));
                    }
                }
            }

            return pairs;
        }

        bool IsPalindrom(string s1, string s2)
        {
            if(s1.Length != s2.Length)
                return false;

            for (int i = 0; i < s1.Length; i++)
            {
                if(!(s1[i] == s2[s1.Length - 1 - i]))
                    return false;
            }

            return true;
        }
    }
}
