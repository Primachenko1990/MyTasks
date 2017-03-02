using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle:Figures
    {
        int radius;
        int x;
        int y;



        public override string Showfigure()
        {
           return    "Circle: radius="+radius+ " "+"x="+x + " "+"y="+ y;
           
        }


        public Circle()
        {
    
        }
        public Circle(int radius,int x, int y)
        {
            this.radius = radius;
            this.x=x;
            this.y=y;
        }
   
        public int Radius
        {get{return radius;}
        set{radius=value;}
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }



    }
 
}
