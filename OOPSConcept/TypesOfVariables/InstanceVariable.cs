using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.TypesOfVariables
{
     class InstanceVariable
    {
         public string Name;
         public int Salary;
        public void Display()
        {
            Console.WriteLine("Salary of " + Name + "  is " + Salary );
        }

    }
}
