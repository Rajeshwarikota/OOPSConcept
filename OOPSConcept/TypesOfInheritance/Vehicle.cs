using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.TypesOfInheritance
{
    internal class Vehicle
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }

    class Car : Vehicle
    {
        public int MaxSpeed { get; set; }
    }
}

