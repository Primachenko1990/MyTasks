using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Task1
    {
        public void Sort(Sorting order, int[] array)
        {
            if (order == Sorting.SortUp)
            {
                Array.Sort(array);
                for (int i = 0; i < array.Length; i++)
                { Console.WriteLine(array[i]); }
            }
            else
                if (order == Sorting.SortDown)
                {
                    Array.Sort(array);
                    Array.Reverse(array);
                    for (int i = 0; i < array.Length; i++)
                    { Console.WriteLine("Array after sorting"+" "+array[i]); }
                }
        }
    }
}
