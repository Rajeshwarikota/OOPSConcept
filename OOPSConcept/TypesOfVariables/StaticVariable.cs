using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPSConcept.TypesOfVariables
{
    class StaticVariable
    {
        public static string CourseName;
        public static int Marks;

        public static void Display()
        {
            Console.WriteLine("Members of " + CourseName + "  is " + Marks);
        }
    }
}


