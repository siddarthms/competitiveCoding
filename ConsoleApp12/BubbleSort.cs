using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class BubbleSort // 1,4,5,3,2
    {
        /*  1,4,5,3,2
         *  1,4,5,3,2
         *  1,4,3,5,2
         *  1,4,3,2,5
         *  
         *  1,4,3,2,5
         *  1,3,4,2,5
         *  1,3,2,4,5
         *  
         *  
         *  
         * 
         */
        public void init()
        {
            int[] arr = { 1, 2, 8, 7, 6, 6, 9, 8, 8 };

            for (int i = 0; i < arr.Length ; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)  // used -1 here because the below line uses j+1 which may cause index out of range
                {
                    if (arr[j] > arr[j + 1]) // for reverse use < symbol
                    {
                        swap(arr, j, j + 1);
                    }
                }
            }

            void swap(int[] arr, int startindex, int endindex)
            {
                int temp = arr[startindex];
                arr[startindex] = arr[endindex];
                arr[endindex] = temp;
            }

            Console.WriteLine(string.Join(",", arr));
        }
    }
}


/*
1,2,8,7,6 

1,2,8,7,6
1,2,8,7,6
1,2,7,8,6
1,2,7,6,8

i++ - > 1

2,1,8,7,6
2,8,1,7,6
2,8,7,1,6
2,8,7,6,1


*/
