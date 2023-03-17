using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.TypesOfConstructors
{
    internal class ParametrizedConstructor
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        //parametrized Constructor
        public ParametrizedConstructor(string name, int age)
        { 
          this.Name = name;
          this.Age = age;
        }
    }
}

