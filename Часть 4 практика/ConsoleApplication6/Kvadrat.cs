using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Kvadrat
    {
        public float  AddSquareSide()
         {
            Console.WriteLine("Enter size of side");
            float a = float.Parse(Console.ReadLine());
        return a;
         }

        public float PerimetrCalculation(float a)
        { 

        float p=a*4;
        return p;
        }

        public float AreaCalculation(float a)
        {
            float s = a * a;
            return s;
        }
    }
}
