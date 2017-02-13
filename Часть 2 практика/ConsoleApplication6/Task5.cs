using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Task5
    {
        public void MinMaxNumbersInArray()
        {
            int[] arr = { 1, 2, 4, 56, 74, 0, 3, 93213 };
            int max1 = 0;
            int max2 = 0;
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max1) max1 = arr[i];

                index1 = Array.IndexOf(arr, max1);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] > max2) && (arr[i] != max1)) max2 = arr[i];

                index2 = Array.IndexOf(arr, max2);
            }

            Console.WriteLine("The first max element"+' '+index1);
            Console.WriteLine("The second max  elment"+' '+index2);
            Console.WriteLine("The distance between the numbers"+" "+Math.Abs(index1 - index2));
        }

    }
}
