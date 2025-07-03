using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class PrimeNumbers
    {
        int input = 17;
        internal void init()
        {
            for (int i = 2; i <= 17; i++)
            {
                if (isPrime(i))
                    Console.WriteLine(i);
            }
        }
        bool isPrime(int num)
        {
            for (int i = 2; i * i <= num; i++) 
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
