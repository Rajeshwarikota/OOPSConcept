using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ValueAndReferanceType
{
    internal class ReferanceTypeVariables
    {
        public static void TestType()
        {
            Institute inst = new Institute();
            inst.Name = "Bridgelab";
            inst.Batch = 987;
            Console.WriteLine("Before modify : " + inst.Name + " " + inst.Batch);
            Update(inst);
            Console.WriteLine("After modify : " + inst.Name + " " + inst.Batch);

        }
        public static void Update(Institute institute)
        {
            institute.Name = "NextWave";
            institute.Batch = 758;
            Console.WriteLine("With in the method: " + institute.Name + " " + institute.Batch);
        }
    }
}

