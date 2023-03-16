using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.TypesOfMethods
{
    internal class InstanceMethod
    {
        //Instance Variable
        public string Name;
        public int Salary;

        public void Employee()
        {
            Console.WriteLine("Salary of" + Name + " is" + Salary);
        }
    }
}
