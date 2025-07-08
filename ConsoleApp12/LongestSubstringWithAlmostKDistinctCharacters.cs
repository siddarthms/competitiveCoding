using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class LongestSubstringWithAlmostKDistinctCharacters
    {
        internal void init()
        {
            string input = "araadddaaadci";
            int k = 2;
            int res = GetTheLongestSubstringWithAlmostKDistinctCharacters(input, k);
            Console.WriteLine($"GetTheLongestSubstringWithAlmostKDistinctCharacters - {res}");
        }
        private int GetTheLongestSubstringWithAlmostKDistinctCharacters(string input, int k)
        {
            int Left = 0, Right = 0, Max = 0;

            Dictionary<char, int> _map = new Dictionary<char, int>();
            
            var (l, r) = (0, 0);

            while (Right < input.Length)
            {
                if (_map.ContainsKey(input[Right]))
                {
                    _map[input[Right]]++;
                }
                else
                {
                    _map[input[Right]] = 1;
                }

                while (Left < Right && _map.Count() > k)
                {
                    _map[input[Left]]--;

                    if (_map[input[Left]] == 0)
                    {
                        _map.Remove(input[Left]);
                    }
                    Left++;
                }

                Right++;


                if (Right - Left > Max)
                {
                     (l, r) = (Left,Right);
                }

                Max = Math.Max(Max, Right - Left);
                
            }
            Console.Write($"The substring is - {input.Substring(l,r-l)}");
            return Max;
        }
    }
}
