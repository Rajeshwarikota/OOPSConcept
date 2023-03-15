using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Abstraction
{
    abstract class Mentor
    {
        public abstract void mark();
        public void explain()
        {
            Console.WriteLine("Mentor will explain the topics");
        }
    }
    class Student : Mentor
    {
        public override void mark() 
        {
            Console.WriteLine("when mentor told the only student know ");
        }
    }

}
