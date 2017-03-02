using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Laibery
{
    class Laibery
    {
        
        int fIndex;
        int lIndex;
        int lengs;

        public Laibery(int fIndex, int lIndex)
        {
            this.fIndex = fIndex;
            this.lIndex = lIndex;
        }

        public int Lengs
        {

            get { return lengs; }
            set { lengs=arraylist.Count;}
        }

        public int FIndex
        {
            get { return fIndex; }
            set {fIndex=value; }
        }
        public int LIndex
        {
            get { return lIndex; }
            set { lIndex=value; }
        }


        ArrayList arraylist = new ArrayList();
        public Students this[int index]
        {
            get { return (Students)arraylist[index]; }
            set
            {
                if (index > -1 && (value is Students))
                    arraylist.Add(value);
        }
        }


    }
}
