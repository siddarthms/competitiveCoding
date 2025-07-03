using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class RotateArrayBy_N_Places
    {
        public void init()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int Rotate = 18;
            int NoOfRotation = Rotate % arr.Length;
            int[] resultArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                resultArr[i] = arr[ (NoOfRotation + i) % arr.Length ]; // for right rotation resultArr[(NoOfRotation + i) % arr.Length] = arr[i];
            }

            Console.WriteLine(string.Join(',', resultArr));
           
        }
    }
}
