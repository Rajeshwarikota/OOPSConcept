using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.TypesOfInheritance
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }
    class Babydog : Dog
    {
        public void Run()
        {
            Console.WriteLine("Babydog is running.");
        }
    }

}

