using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class FrequencyOfEachWordInAString
    {
        public void init()
        {
            string input = "Hello world to this World";

            string[] arr = input.Split(" ");

            Dictionary<string, int> Frequnecy = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase); // for case insensitivity worl == World

            foreach (string c in arr)
            {
                if (Frequnecy.ContainsKey(c))
                {
                    Frequnecy[c]++;
                }
                else
                {
                    Frequnecy.Add(c, 1);
                }
            }

            foreach (KeyValuePair<string, int> key in Frequnecy)
            {
                Console.WriteLine($"key - {key.Key} and its frequency is {key.Value}");
            }
        }
    }
}
