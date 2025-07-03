using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Sortanarraycontaining0_s_1_sand2_s
    {
        internal void init()
        {
            int[] arr = arr = [2, 0, 1, 2, 1, 0];

            int low = 0, mid = 0, high = arr.Length - 1;

            SortArryOf012(low, mid, high, arr);

            Console.WriteLine($"Sorted array of 0's 1's 2's - {string.Join(',', arr)}");

        }

        void SortArryOf012(int low, int mid, int high, int[] arr)
        {
            while (mid <= high)
            {
                if (arr[mid] == 0)
                {
                    swap(mid, low, arr);
                    low++;
                    mid++;
                }
                else if (arr[mid] == 2)
                {
                    swap(mid, high, arr);
                    high--;
                }
                else
                {
                    mid++;
                }
            }
        }

        void swap(int start, int end, int[] arr)
        { 
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
        }
    }
}
