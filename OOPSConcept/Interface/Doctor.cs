using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Interface
{
    interface IDoctor
    {
      // Interface
      void Surgery(); // interface method (does not have a body)
    }
       // Nurse "implements" the IDoctor interface
     class Nurse : IDoctor
     {
         public void Surgery()
         {
            // The body of Surgery() is provided here
            Console.WriteLine("Nurse Will Help to the doctor");
         }
     }
}

