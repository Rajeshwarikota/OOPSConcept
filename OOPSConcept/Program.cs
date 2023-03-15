
using OOPSConcept.Abstraction;
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

            Student student = new Student();
            student.mark();
            student.explain();

            Console.ReadLine();
        }
    }
}
