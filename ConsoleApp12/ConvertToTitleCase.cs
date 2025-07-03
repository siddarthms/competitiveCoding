using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class ConvertToTitleCase
    {
        public void init()
        {
            string input = "hi my name is siddarth";

            bool LetterHasSpaceBefore = true;

            StringBuilder sb = new StringBuilder();

            for ( int i=0; i< input.Length; i++)
            {
                if (LetterHasSpaceBefore && char.IsLetter(input[i])) // idealogy is check if whether a space exist before a character then that the start character
                {
                    sb.Append(char.ToUpper(input[i]));
                    LetterHasSpaceBefore = false;
                }
                else if (input[i].ToString() == " ")
                {
                    sb.Append(" ");
                    LetterHasSpaceBefore = true;
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
