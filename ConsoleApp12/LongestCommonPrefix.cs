using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class LongestCommonPrefix
    {
        internal void init()
        {
            string[] input = { "flower", "flight", "fly", "flow" };
            string result = AlternativeGetLongestCommonPrefix(input);
            Console.WriteLine("Longest Common Prefix is - " + result); // Output: "fl"
        }

        string GetLongestCommonPrefix(string[] input)
        {
            Array.Sort(input);

            string firstElement = input[0];
            string lastElement = input[input.Length - 1];

            int MinElement = Math.Min(firstElement.Length, lastElement.Length);

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < MinElement; i++)
            {
                if (firstElement[i] == lastElement[i])
                {
                    result.Append(firstElement[i]);
                }
                else
                {
                    break;
                }
            }

            return result.ToString();   
        }

        string AlternativeGetLongestCommonPrefix(string[] input)
        {
            string prefix = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                while (input[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }

            return prefix;
        }
    }
}
