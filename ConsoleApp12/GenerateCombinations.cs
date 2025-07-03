using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class GenerateCombinations
    {
        internal void init()
        {
            string input = "abc";
            int k = 2;

            List<string> result = new List<string>();
            GenerateCombination(input, "", k, result);

            Console.WriteLine($"Total: {result.Count}");
            //foreach (var combo in result)
            //{
            //    Console.WriteLine(combo);
            //}

            Action<string> printAction = (str) => Console.WriteLine(str);

            Parallel.ForEach(result, printAction);
        }

//        generate("")
//├── generate("a")
//│   ├── generate("aa") → ✅ Add → return 🔙
//│   ├── generate("ab") → ✅ Add → return 🔙
//│   └── generate("ac") → ✅ Add → return 🔙
//├── generate("b")
//│   ├── generate("ba") → ✅ Add → return 🔙
//│   ├── generate("bb") → ✅ Add → return 🔙
//│   └── generate("bc") → ✅ Add → return 🔙
//└── generate("c")
//    ├── generate("ca") → ✅ Add → return 🔙
//    ├── generate("cb") → ✅ Add → return 🔙
//    └── generate("cc") → ✅ Add → return 🔙


        void GenerateCombination(string input, string current, int Len,List<string> res)
        {

            if (current.Length == Len)
            {
                res.Add(current);
                return;
            }

            foreach(char c in input)
            {
                GenerateCombination(input, current + c, Len, res);
            }
        }


    }
}

