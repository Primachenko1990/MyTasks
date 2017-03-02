using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class ComandParser
    {
        string comand1 = "Add figure";
        string comand2 = "Delete figure";
        string comand3 = "Show all figures";
        string comand4 = "Show figure by number";

        public int ComparisonComand(string com)
        {
            if (String.Compare(com, comand1) == 0)

                return 1;
            else if (String.Compare(com, comand2) == 0)


                return 2;
            else if (String.Compare(com, comand3) == 0)

                return 3;
            else if (String.Compare(com, comand4) == 0)

                return 4;
            else
                Console.WriteLine("You enter uncorect comand");
            return 0;

        }
    }
}
