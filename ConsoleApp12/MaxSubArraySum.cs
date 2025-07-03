using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    // using Kadane's algorithm
    internal class MaxSubArraySum 
    {
        internal void init()
        {
            int[] input = new int[] { 2,3,-8,7,-1,2,3 };

            int max = 0;
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];

                max = Math.Max(max, sum);

                if (sum < 0)
                {
                    sum  = 0;
                }
            }

            Console.WriteLine($"MaxSubArraySum is : {max}");
            
        }

    }
}
