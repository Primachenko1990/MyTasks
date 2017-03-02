using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laibery
{
 
    class Students
    {
        string sName;

  public   Students(string sName)
        {
            this.sName = sName;
  }


  public string SName
  {

      get { return sName; }
      set { sName=value; }
  }
  public Students()
  {
    
  }

      public  string[] students = {"Ivanov","Petrov", "Sidorov","Kgyglakov","Kokorin","Dyrakov","ff"};
    }


}
