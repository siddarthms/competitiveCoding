using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class LeadersInArray
    {
        public void init()
        {
            int[] input = [1,22,12,3,2,1,6];
            int max = 0;
            List<int> ints = new List<int>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] > max)
                {
                    ints.Add(input[i]);
                    max = input[i];
                }
            }
            ints.Reverse();

            Console.WriteLine($"Leaders in a Array : {string.Join(',', ints)}");
        }
    }
}
