using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program

    {
   static   int DeleteFigureByNumber()
        {
            Console.WriteLine("Enter pliz figure number");
            int n = int.Parse(Console.ReadLine());
            return n;

        }
        static void Main(string[] args)
        {
            FigureParser figureparser = new FigureParser();
                ComandParser parser=new ComandParser();
               List<Figures> array = new List<Figures> { };
            
            


                while (true)
                {
                    Console.WriteLine("Enter comand for example : Add figure, Delete figure, Show all figures or Show figure by number");
                    string comand = Console.ReadLine();
                    int rezultcompaircomand=parser.ComparisonComand(comand);
                    switch (rezultcompaircomand)
                    {
                        case 1:
                             int f=   figureparser.ComparisonFigure();

                            array.Add(figureparser.FigureCreator(f));         
                                break;

                        case 2: 
                             Console.WriteLine("Array count ="+array.Count);
                              int n=  DeleteFigureByNumber();
                             
                              if (array[n] != null && n<=array.Count)
                              { array.RemoveAt(n-1);
                                  Console.WriteLine("element wath delete");}
                              else
                                  Console.WriteLine("element with this number does not exist");

                            break;
                        case 3:
                            for (int i = 0; i < array.Count; i++)
                                Console.WriteLine(array[i].Showfigure());
                                break;
                        case 4: 
                            
                            ;
                            break;
                        case 0:
                            break;
                    }


                }   

        }
    }
}
