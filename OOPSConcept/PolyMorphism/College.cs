using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.PolyMorphism
{
    class College
    {
        public virtual void Study()
        {
            Console.WriteLine("students are coming to college for study Purpose");
        }
    }
    class Seniors : College 
    {
        public override void Study() 
        {
            Console.WriteLine("Senior students be like Rolemodel to the juniors in Studying ");
        }
    }
    class Juniors : College 
    {
        public  void Study()
        {
            Console.WriteLine("Juniors must be follow the college and Seniors Rules");
        }
    }
}
