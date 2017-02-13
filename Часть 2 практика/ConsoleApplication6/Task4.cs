using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Task4
    {
        public void ArrayRevers()
        {
        int[] arr1 = new int[] {1,2,3,4,5,6,7 };

        for (int i = 0; i<=arr1.Length/2; i++)
        {
           int c = arr1[i];
           arr1[i] = arr1[(arr1.Length-1) - i];
            arr1[(arr1.Length-1) - i] = c;
       }
       for (int i = 0; i < arr1.Length; i++)
        { Console.WriteLine("New massiv"+arr1[i]); }}
    }
}
