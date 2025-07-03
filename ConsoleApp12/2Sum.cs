using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class _2Sum
    {
        internal void init()
        {
            int[] input = new int[] { 2,6,5,8,11 };
            int target = 14;

            int dif = 0;

            var res = (0,0);

            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < input.Length; i++)
            {
                dif = target - input[i];

                if (map.ContainsKey(dif)) // cehck if diff exists if not directly add that elemt into the dictionary for later tracking
                {
                    res = (map[dif], i);
                }
                else
                {
                    map[input[i]] = i;  
                }
            }
            //intution is  14 - 2 is 12 , but 14 -12 is 2 so on adding the subtracting number with the exsisting reaminder in the map gives the sum of 2 numbers
            Console.WriteLine($"_2Sum index: {string.Join("-" ,res.Item1, res.Item2)}" );

        }
    }
}
