using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class LongestSubarrayWithoutRepeatingCharacters
    {
        internal void init()
        {
            string input = "acdfgaabcadef";

            int leftptr = 0, rightPtr = 0;

            int maxConsecutive = 0;

            Dictionary<char, int> mapper = new Dictionary<char, int>();

            while (rightPtr < input.Length)
            {
                if (mapper.ContainsKey(input[rightPtr]) && mapper[input[rightPtr]] >= leftptr)
                {
                    leftptr = mapper[input[rightPtr]] + 1;
                    mapper[input[rightPtr]] = rightPtr;
                }
                else
                {
                    mapper[input[rightPtr]] = rightPtr;
                }

                maxConsecutive = Math.Max(maxConsecutive, rightPtr - leftptr + 1);
                rightPtr++;

                
                
            }

            Console.WriteLine($"Maxconsecutive : {maxConsecutive}");

            
        }

    }
}
