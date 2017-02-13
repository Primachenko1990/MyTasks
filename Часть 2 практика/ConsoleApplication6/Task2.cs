using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Task2
    {
        public int ReadNumber1()
        {
        Console.WriteLine("Enter the positiv number");
            int c=Int32.Parse(Console.ReadLine());
        return c;
        
        }

      public  void Summary(int c)
        {
            int sum = 0;
            for (int i = 0; i <= c; i += 2)
            {

                int r = i;
                sum = sum + i;
            }
            Console.WriteLine(sum);
           
        
        }
         
            
        
    }
}
