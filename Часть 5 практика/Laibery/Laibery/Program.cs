using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laibery
{
    class Program
    {
        static void Main(string[] args)
        {Students st=new Students();
        Laibery lb = new Laibery(1 ,7);
        for (int i = 0; i < st.students.Length; i++)
        {
            lb[i] = new Students(st.students[i]);
        }
        for (int i = 0; i < lb.Lengs; i++)
            Console.WriteLine(lb[i].SName);
        Console.ReadKey();
        } 
       
    }
}
