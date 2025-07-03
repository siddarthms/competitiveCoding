using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class FrequencyOfEachLetterInAString
    {
        public void init()
        {
            string input = "hello my name is siddarth , i am a developer";

            Dictionary<char, int> Frequnecy = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (!string.IsNullOrWhiteSpace(c.ToString()))
                {
                    if (Frequnecy.ContainsKey(c))
                    {
                        Frequnecy[c]++;
                    }
                    else
                    {
                        Frequnecy[c] = 1;
                    }
                }
            }

            foreach (KeyValuePair<char, int> key in Frequnecy)
            {
                Console.WriteLine($"key - {key.Key} and its frequency is {key.Value}");
            }
        }
    }
}
