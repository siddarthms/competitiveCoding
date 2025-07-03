using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class CheckifStringisRotationofAnother
    {
        internal void init()
        {
            //string s1 = "waterbottle";
            //string s2 = "erbottlewat";

            string s1 = "aaabc" , s2 = "abcaa";

            var res = CheckifStringisRotationofAnothe(s1, s2);
            var res1 = CheckifStringisRotationofAnotherAlternate(s1, s2);

            Console.WriteLine(res);
        }

        private bool CheckifStringisRotationofAnothe(string s1, string s2)
        {
            if(s1.Length != s2.Length)
                return false;

            return (s1 + s1).Contains(s2);
        }

        private bool CheckifStringisRotationofAnotherAlternate(string s1, string s2)
        {
            if(s1.Length != s2.Length) return false;

            string doubledStr = s1 + s2;

            int index = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                index = 0;

                while (index < s1.Length && doubledStr[index + i] == s2[index] )
                {
                    index++;
                }

                if(index == s2.Length)
                    return true;
            }

            return default;
        }
    }
}
