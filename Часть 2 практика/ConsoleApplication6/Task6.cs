using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Task6
    {public void ArrayRevers2 ()
        {
            {
                int[,] arr = new int[4, 4] { { 4, 4, 4, 4 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 }, { 5, 5, 5, 5 } };
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (i < j) arr[i, j] = 1;
                        else if (i > j) arr[i, j] = 0;

                        Console.Write(arr[i, j]);
                    }
                    Console.WriteLine();

                }
            }
        }
    }
}
