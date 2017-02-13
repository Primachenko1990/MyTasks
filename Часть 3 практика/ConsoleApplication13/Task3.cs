using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Task3
    {
        public int[] Proizvedenie(int n, int t, int lengs)
        {

            int[] array = new int[lengs];
            array[0] = n;
            Console.WriteLine(array[0]);
            for (int i = 1; i < array.Length; i++)
            {

                array[i] = array[i - 1] + t;

                Console.WriteLine(array[i]);
            }

            return array;
        }
    }
}
