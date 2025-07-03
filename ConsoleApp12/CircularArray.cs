using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class CircularArray
    {
        internal void init()
        {
            string input = "umabuhsdbfkjwdoptumgvdjghwbopt";
            string word = "optum";
            int wordLength = word.Length;

            // Create circular version of the input
            string circularInput = input + input.Substring(0, wordLength - 1);

            int count = 0;
            for (int i = 0; i <= circularInput.Length - wordLength; i++)
            {
                string sub = circularInput.Substring(i, wordLength);
                if (sub == word)
                {
                    count++;
                }
            }
            Console.WriteLine(count); 
        }
    }
}
