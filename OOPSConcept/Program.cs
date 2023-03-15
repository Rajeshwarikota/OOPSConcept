
using OOPSConcept.ClassAndObject;
using OOPSConcept.Inheritance;
using OOPSConcept.PolyMorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OOPS Concept");

            College college = new College();
            college.Study();
            Seniors seniors = new Seniors();
            seniors.Study();
            Juniors juniors = new Juniors();
            juniors.Study();
            Console.ReadLine();
        }
    }
}
