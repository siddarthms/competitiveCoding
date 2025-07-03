using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class BalacedParenthesis
    {
        public void init()
        {
            string input = "{[()[)]]}";

            Stack<char> stack = new Stack<char>();

            bool isBalanced = true;

            foreach (char c in input)
            {
                if (c == '}' || c == ']' || c == ')')
                {
                    if (stack.Count() > 0)
                    {
                        var lastParenthesis = stack.Pop();
                        Console.WriteLine($"{lastParenthesis} {c}");
                        if (!(lastParenthesis == '{' && c == '}' || lastParenthesis == '[' && c == ']' || lastParenthesis == '(' && c == ')'))
                        {
                            isBalanced = false;    // hint used ! instead of one more else 
                            break;
                        }
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }
            Console.WriteLine(isBalanced);
        }
    }
}
