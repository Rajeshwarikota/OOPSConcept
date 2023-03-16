using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.TypesOfMethods
{
    internal class StaticMethod
    {

        //Static Variable
        public static string Profession;
        public static int WorkinhHours;

        //static Method
        public static  void Employee()
        {
            Console.WriteLine("Workinh Hours of " + Profession + " is " + WorkinhHours);
        }
    }
}
