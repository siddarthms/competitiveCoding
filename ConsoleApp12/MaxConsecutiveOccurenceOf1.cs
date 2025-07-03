using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class MaxConsecutiveOccurenceOf1
    {
        public void init()
        {
            int[] arr = [1,1,1,0,0,1,1,0,0,1,1,1,1,0,1];
            int maxOcc = 0;
            int counter = 0;
            for(int i = 0; i< arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    counter++;
                    maxOcc = Math.Max(maxOcc, counter);
                }
                else
                {  
                    counter = 0;
                }
            }
            Console.WriteLine(@"Max Consecutive 1's is " + maxOcc);

        }
    }
}
