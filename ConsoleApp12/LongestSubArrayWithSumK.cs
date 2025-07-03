using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class LongestSubArrayWithSumK 
    {
        internal void init()
        {
            int[] input = [1, 2, 3, 1, 1, 1, 1];
            int k = 4;
            int sum = 0 , max = 0;
            int left = 0, right = 0;

            while (right < input.Length)
            {
                sum += input[right];
                
                if (sum == k)
                {
                    max = Math.Max(max, right - left + 1);
                }
                while (left < right && sum > k)
                {
                    sum -= input[left];
                    left++;
                }
                right++;
            }
            Console.WriteLine($"LongestSubArrayWithSumK : {max}");
        }
    }
}
