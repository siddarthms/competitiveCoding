using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class RemoveDuplicateInArrayAndString
    {
        public void init()
        {

            string input = "string inputtttt";
            //char[] input1 = new char[] { 's', 'i', 'd', 'd', 'a' };
            //string[] input2 = new string[] { "hellow", "My", "World" };
            HashSet<char> chars = new HashSet<char>(input); // accepts the types collection if string string collection, if int int collection,if charit accepts char collection or string as string is a Ienumervale of Char

           

            Console.Write(string.Join(",", chars));

            // for order output

            //foreach (char c in input)
            //{
            //    if (seen.Add(c))  // Add returns false if c is already in the set
            //    {
            //        result.Append(c);
            //    }
            //}


        }
    }
}
