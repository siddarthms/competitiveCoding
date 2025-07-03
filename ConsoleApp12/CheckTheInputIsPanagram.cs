using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class CheckTheInputIsPanagram
    {
        internal void init()
        {
            string input = "The quick brown fox jumps over a lazy dog";

            var res = CheckIsPanagram(input);

            Console.WriteLine("It's a Panagram - {0}",res);
        }

        bool CheckIsPanagram(string input)
        {
            bool[] arr  = new bool[26];

            int count = 0;

            char lower = '\0';

            foreach (char c in input)
            {

                if (c >= 'A' && c <= 'Z')
                {
                    lower = (char)(c + 32);
                }
                else if (c >= 'a' && c <= 'z')
                {
                    lower = c;
                }
                else
                {
                    continue;
                }

                if (!arr[lower - 'a'])
                {
                    arr[lower - 'a'] = true;
                    count++;
                }
            }

            return count == 26 ? true : false;
        }
    }
}
