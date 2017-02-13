using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Task1
    { 
        
         public int ReadNumber1 ()
    {       Console.WriteLine("Enter the first number");
            int a = Int32.Parse(Console.ReadLine());
            return a;
        }
         public int ReadNumber2 ()
        {
            Console.WriteLine("Enter the second number");
            int b = Int32.Parse(Console.ReadLine());
            return b;
         }

        public void Average(int a, int b)
        {
            if (a < b)
            {
                a = a;
                b = b;
            }
            else if (a > b)
            {
                int d = a;
                a = b;
                b = d;
            }

            else { Console.WriteLine("You entered similar numbers"); }
            int res = 0;
            for (int i = a; i <= b; i++)
            {
                res += i;

            }
            Console.WriteLine("Average="+res/2);

        }
    }
}
