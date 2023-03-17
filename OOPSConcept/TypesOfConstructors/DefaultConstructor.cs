using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.TypesOfConstructors
{
    internal class DefaultConstructor
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public DefaultConstructor()
        {
            Console.WriteLine("Enter the Employee name: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter the Department name: ");
            this.Department = Console.ReadLine();
        }
    }
}
    
