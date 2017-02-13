using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Task3
 
        { 
        public int ReadNumber1()
        {
            Console.WriteLine("Enter the first nuber");
          int a=Int32.Parse(Console.ReadLine());
        return a;
        }
        public int ReadNumber2()
        {
          Console.WriteLine("Enter the second nuber");
          int b = Int32.Parse(Console.ReadLine());
        return b;
        }
        public void SumEvenNumbers(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0) { sum = sum + i; }


            }
            Console.WriteLine("Sum event nubers"+' '+sum);
        }
    }
}
