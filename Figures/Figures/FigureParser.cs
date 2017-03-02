using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class FigureParser
    {
        string squere = "Squere";
        string circle = "Circle";
        string rectangel = "Rectangel";
        string triangle = "Triangle";


        public int ComparisonFigure()
        {
            Console.WriteLine("Pliz enter name of figure for example: Squere , Circle, Triangle  or Rectangel");
            string  figure = Console.ReadLine();
            if (String.Compare(figure, squere) == 0)
                return 1;
            else
                if (String.Compare(figure, circle) == 0)
                    return 2;
                else
                    if (String.Compare(figure, rectangel) == 0)
                        return 3;
                    else
                        if (String.Compare(figure, triangle) == 0)
                            return 4;
                        else
                        Console.WriteLine("You enter uncorect name of figure");
            return 0;

        }


        public Figures FigureCreator(int comparisonfigure)
        {
            if (comparisonfigure == 0)
            {
                ComparisonFigure();

            }
            string c;
            string[] figureArray =new string[16] ;
            int[] paramsoffigures= new int[16] ;
            link:
            Console.WriteLine("Enter pliz params of figure separated by commas:");
            Console.WriteLine("For circle radius,x,y for example: 3,5,2 ");
                Console.WriteLine("For squere  x1,y1,x2,y2 for example: 3,5,2,6");
                Console.WriteLine("For rectangel x1,y1,x2,y2,x3,y3,x4,y4 for example: 3,5,2,6,2,5,4,5 ");
                Console.WriteLine("For triangle x1,y1,x2,y2,x3,y3 for example: 3,5,2,6,2,5 ");
                c = Console.ReadLine();

                if (c.Length < 16 && IsNumberContains(c)==true)
                { figureArray = c.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries); }
                else  goto link;
                    if (comparisonfigure == 1)
                    {
                        for (int i = 0; i < 4; i++)
                        { paramsoffigures[i] = Int32.Parse(figureArray[i]); }
                        paramsoffigures = SquereBuilder(paramsoffigures);
                        return new Squere(paramsoffigures[0], paramsoffigures[1], paramsoffigures[2], paramsoffigures[3], paramsoffigures[4], paramsoffigures[5], paramsoffigures[6], paramsoffigures[7]);
                    }
                    else
                        if (comparisonfigure == 2)
                        {
                            for (int i = 0; i < 3; i++)
                            { paramsoffigures[i] = Int32.Parse(figureArray[i]); }
                            return new Circle(paramsoffigures[0], paramsoffigures[1], paramsoffigures[2]);
                        }//vopros

                    if (comparisonfigure == 3)
                    {
                        for (int i = 0; i < 8; i++)
                        { paramsoffigures[i] = Int32.Parse(figureArray[i]); }
                        return new Rectangel(paramsoffigures[0], paramsoffigures[1], paramsoffigures[2], paramsoffigures[3], paramsoffigures[4], paramsoffigures[5], paramsoffigures[6], paramsoffigures[7]);
                    }
                    else
                        if (comparisonfigure == 4)
                        {
                            for (int i = 0; i < 6; i++)
                            { paramsoffigures[i] = Int32.Parse(figureArray[i]); }
                            return new Triangle(paramsoffigures[0], paramsoffigures[1], paramsoffigures[2], paramsoffigures[3], paramsoffigures[4], paramsoffigures[5]);
                        }
         else
                           
                            
                                return null;//ворос по поводу исключения 
               
        }

      int[] SquereBuilder(int[] twopoints)
    {
        int x1 = twopoints[0];
          int y1 = twopoints[1];
        int x2 = twopoints[2];
        int y2 = twopoints[3];
        int x3 = 0;
        int y3 = 0;
        int x4 = 0;
        int y4 = 0;
        if (x1 == x2 && y1 == y2)
        {
            x3 = (x1 + (y2 - y1));
            y3 = (y1 + (x2 - x1));
            x4 = (x2 + (y2 - y1));
            y4 = y2 + (x2 - x1);
        }
        else
            x3 = (x1 + x2) / 2 + (y1 - y2) / 2;
        y3 = (y1 + y2) / 2 + (x2 - x1) / 2;
        x4 = (x1 + x2) / 2 + (y2 - y1) / 2;
        y4 = (y1 + y2) / 2 + (x1 - x2) / 2;
        int[] squereArray = new int[] { x1,y1,x2,y2,x3,y3,x4,y4 };
        return squereArray;
    }


      static bool IsNumberContains(string input)
      {
          foreach (char c in input)
              if (Char.IsNumber(c))
                  return true;
          return false;
      }
      
    }
}
