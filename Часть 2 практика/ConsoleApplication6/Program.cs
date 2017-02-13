using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the positiv number");
            int c=Int32.Parse(Console.ReadLine());
            for (int i = 0; i <= c;  i+=2)
            {
                
                int r = i;
                sum = sum + i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            
        }
    }
}
