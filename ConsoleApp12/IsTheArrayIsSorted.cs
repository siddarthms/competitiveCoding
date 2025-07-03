using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class IsTheArrayIsSorted
    {
        public void init()
        {
            int[] input = new int[] { 1, 2, 3, 4, 7, 6 };

            string Sorted = "Sorted Array";

            for (int i = 0; i < input.Length - 1; i++)  // hint if j + 1 is used means its going one index ahead so on the loop condtion check use -1 
            { 
                if (!(input[i+1] > input[i]))
                {
                    Sorted = "Not Sorted Array";
                    break;
                }
            }
            Console.WriteLine(Sorted);
        }
    }
}
