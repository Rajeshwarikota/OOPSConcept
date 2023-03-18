using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPSConcept.AccessModifiers
{
    class ProtectedSpecifier
    {
        protected string Name ;
        protected int Age;
        protected void GetDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
        }
    }
    class DerivedClass : ProtectedSpecifier
    {
        
    }
}
