using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Task2
    {
       public void SortControl(SortingControl order, int[] array)
        {
            int[] array2 = (int[])array.Clone();
            Array.Sort(array);
            int[] arrayup = (int[])array.Clone();
            Array.Reverse(array);
            int[] arraydown = (int[])array.Clone();

            if (order == SortingControl.SortUp && array2.SequenceEqual(arrayup))
            { Console.WriteLine("Correct up sorting "); }
            else
                if (order == SortingControl.SortDown && array2.SequenceEqual(arraydown))
                { Console.WriteLine("Ccorrect down sorting"); }
                else
                    Console.WriteLine("Uncorrect sorting");
        }
    }
}
