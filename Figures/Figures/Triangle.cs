﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Triangle:Figures
    {

           int x1;
        int y1;
        int x2;
         int y2;
         int x3;
         int y3;


        public Triangle()
        {}
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        { this.x1 = x1;
            this.y1=y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3= y3;
            
        }

        public int X1
        {
            get { return x1; }
            set { x1= value; }
        }

        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public int Y2
        {
            get { return y2; }
            set { y2 = value; }
        }
        public int X3
        {
            get { return x3; }
            set { x3 = value; }
        }

        public int Y3
        {
            get { return y3; }
            set { y3 = value; }
        }

        public override string Showfigure()
        {
            return "Triangle: x1=" + x1 + " " + "y1=" + y1 + " " + "x2=" + x2 + " " + "y2=" + y2 + " " + "x3=" + x3 + " " + "y3=" + y3;
        }

    }
}
