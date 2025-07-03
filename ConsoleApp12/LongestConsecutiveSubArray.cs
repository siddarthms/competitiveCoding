using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class LongestConsecutiveSubArray
    {
        public void init()
        {
            int[] input = [100, 4, 9, 10, 11, 200, 1, 3, 2, 7, 8];

            HashSet<int> hash = new HashSet<int>(input);
            int longestSequence = 0;
            int seq = 0;
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                counter = 0;
                seq = 0;
                if (!hash.Contains(input[i] - 1))
                {
                    counter++;
                    seq = input[i];

                    while (hash.Contains(seq + 1))
                    {
                        seq++;
                        counter++;
                    }
                    longestSequence = Math.Max(longestSequence, counter);
                }
            }
            Console.WriteLine($"Longest Subsequence is : {longestSequence}");
        }
    }
}
