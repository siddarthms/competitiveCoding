using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class FindTheFirstAndSecondLargestElementInAnArray
    {
        public void init()
        {
            int[] input = new int[] { 1, 2, 3, 4, 9, 5, 6, 9 };

            int Greatest = input[0];
            int SecondGreatest = -1;
            int smallest = input[0];
            int Secondsmallest = int.MaxValue;
            for (int i = 1; i < input.Length ; i++)
            {
                if (input[i] < smallest)
                {
                    smallest = input[i];
                }
                else if (input[i] != smallest && input[i] < Secondsmallest)
                {
                    Secondsmallest = input[i];
                }

                if (input[i] > Greatest)
                {
                    SecondGreatest = Greatest;
                    Greatest = input[i];
                }
                else if (input[i] != Greatest &&  input[i] > SecondGreatest)
                {
                    SecondGreatest = input[i];
                }
            }
            Console.WriteLine($"Largest - {Greatest}, SecondLargest - {SecondGreatest}, Smallest - {smallest}, SecondSmallest - {Secondsmallest}");
        }
    }
}
