using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class StringCompression
    {
        internal void init()
        {
            string input = "aabcccccaaa";
            string compressed = CompressString(input);
            Console.WriteLine(compressed);
        }
        string CompressString(string input)
        {
            Index lastIndex = ^1;
            int counter = 1;
            char current;
            char previous;
            StringBuilder res = new StringBuilder();
            for (int i = 1; i < input.Length; i++)
            {
                previous = input[i - 1];
                current = input[i];

                if (current == previous)
                {
                    counter++;
                }
                else
                {
                    res.Append(previous);
                    res.Append(counter);
                    counter = 1;
                }
            }
            //Append last character group
            res.Append(input[lastIndex]);
            res.Append(counter);
            return res.ToString();
        }
    }
}
