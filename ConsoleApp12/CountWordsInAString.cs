using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class CountWordsInAString
    {
        public void init()
        {
            string input = "this is a strig, @@@  it's has many words.".Trim();
            
            StringBuilder sb = new StringBuilder();
            
            int counter = 0;
            bool lastletter = false;


            for (int i = 0; i < input.Length; i++)
            {
                if (lastletter && string.IsNullOrWhiteSpace(input[i].ToString())) // when empty space comes, before that there is a word that is the idealogy
                {
                    counter++;
                }
                else if (char.IsLetter(input[i]) || (input[i] == '\'')) // for considering oppostopi also as an letter , if not it will result as it s two seperate words
                {
                    lastletter = true;
                }
                else if(input[i] == ' ')
                {
                    lastletter = false;
                }
            }

            Console.WriteLine(counter);   

        }
    }
}
