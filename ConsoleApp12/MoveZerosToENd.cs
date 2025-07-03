using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class MoveZerosToENd
    {
        LinkedList<int> yam = new();


        public void init()
        {
            int[] input = new int[] { 1, 0, 0, 3, 4, 0, 5 };

            //int firstOccuranceOfZero = 0;

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == 0)
            //    {
            //        firstOccuranceOfZero = i;
            //        break;  
            //    }
            //}
            //int NonZero = firstOccuranceOfZero + 1;
            //for (int j = firstOccuranceOfZero; j < input.Length -1 ; j++)
            //{

            //    if (NonZero != 0)
            //    {
            //        swap(input, j, NonZero);
            //        j++;
            //    }
            //    NonZero++;
            //}

            //void swap(int[] arr, int start, int end)
            //{
            //    int temp = arr[start];
            //    arr[start] = arr[end];
            //    arr[end] = temp;
            //}

            // alternatne for below solution is above , find the first zero occurance and assign that to the lastzeroposition and do the below same by starting loop from the next index of first zero occurance found
            int lastzeroposition = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 0)
                    swap(input, lastzeroposition, i);
                
            }

            void swap(int[] inn, int start, int end)
            {
                int temp = inn[start];
                inn[start] = inn[end];
                inn[end] = temp;
                lastzeroposition++;
            }


            Console.WriteLine(string.Join(",", input));
        }
    }
}
