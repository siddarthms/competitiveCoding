using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class CapitalizeTheFirstLetterOfSentance
    {
        public void init()
        {
            string input = "What is your 39name name? My Name is . . @3 Siddarth.";

            int Len = input.Length;
            char[] chars = new char[Len];
            bool capitalize = true;
            for (int i = 0; i < Len; i++)
            {
                if (capitalize && char.IsLetterOrDigit(input[i]))  // for capitalizing
                {
                    chars[i] = char.ToUpper(input[i]);
                    capitalize = false;
                }
                else if (char.IsLetterOrDigit(input[i]))  // for appening other char in the string
                {
                    chars[i] = char.ToLower(input[i]);
                }
                else
                {
                    chars[i] = input[i];   // for appending string other than char like . empty spaces and special character 
                    capitalize = true;
                }
            }
            Console.WriteLine(new string(chars));
        }
    }
}
