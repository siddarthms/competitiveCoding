using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class FindNumberAppereancingOnceInATwiceArray
    {
        public void init()
        {
            int[] arr = [1,4,9,6,1,7,4,7,6];

            int ans = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                ans ^= arr[i];
            }

            Console.WriteLine("Number apperacing once in a Twice array is - " + ans);
        }
    }
}
