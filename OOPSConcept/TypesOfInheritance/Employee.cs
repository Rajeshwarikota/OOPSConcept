using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.TypesOfInheritance
{
    // Interface
    interface IEmployee
    {
        void Work(); // interface method (does not have a body)
    }
    // Manager "implements" the IEmployee interface
    class Manager : IEmployee
    {
        public void Work()
        {
            // The body of Work() is provided here
            Console.WriteLine("Manager have 5 years Experience in his work");
        }
    }
}