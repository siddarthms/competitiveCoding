using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class FindTheMissingElementInAnArray
    {
        public void init()
        {
            int N = 5;
            int[] arr = new int[4] {1,2,4,5};

            int res = N*(N + 1) / 2; // sum of all numbers till N
            int sum = 0;

            for (int i=0; i< arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine($"Missing Elemet in the array is : {res - sum}");

        }
    }
}
