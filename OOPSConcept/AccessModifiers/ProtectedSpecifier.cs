using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.AccessModifiers
{
    class ProtectedSpecifier
    {
        protected string Profession;
        protected int Salary;
        protected void Work()
        {
           
        }
    }

    class MyDerivedClass : ProtectedSpecifier
    {
        public void work()
        {
            Console.WriteLine("Employee should work");
        }
    }
}
