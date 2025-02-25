using ConceptsExample.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsExample
{
    public  class ClassForDelegates
    {
        public delegate int MyDelegate(int a, int b); //this can be specified inside the class

        public static int callMyDelegates()
        {
            DelegateController obj = new DelegateController();
            MyDelegate myDelegate = new MyDelegate(obj.AddValues);
             myDelegate += new MyDelegate(obj.SubValues);

            return myDelegate(10,20);
        }
    }
}
