using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class BuyAndSellStocks
    {
        public void init()
        {
            int[] input = new int[] {7,1,5,3,6,4 };

            int min = input[0];
            int max = 0;

            for (int i = 0; i< input.Length; i++)
            {
                var profit = input[i] - min;

                min = Math.Min(min, input[i]);

                max = Math.Max(max, profit);
            }

            Console.WriteLine($"BuyAndSell stock profit {max}");

        }
    }
}
