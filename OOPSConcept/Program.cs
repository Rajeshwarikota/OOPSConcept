
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

            MethodOverLoading method = new MethodOverLoading();
            Console.WriteLine("Add with two int parameter :" + method.Add(3, 2));
            Console.WriteLine("Add with three int parameter :" + method.Add(3, 2, 8));
            Console.WriteLine("Add with two float parameter :" + method.Add(3f, 22f));
            Console.WriteLine("Add with two string parameter :" + method.Add("Raji", "kota"));
            Console.ReadLine();
        }
    }
}
