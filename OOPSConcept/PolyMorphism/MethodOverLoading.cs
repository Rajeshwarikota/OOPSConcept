using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.PolyMorphism
{
     class MethodOverLoading
     {
            public int Add(int num1, int num2)
            {
                return (num1 + num2);
            }
            //changing number of parameters
            public int Add(int num1, int num2, int num3)
            {
                return (num1 + num2 + num3);
            }
            //changing datatype in the parameter
            public float Add(float num1, float num2)
            {
                return (num1 + num2);
            }
            //changing order of the parameter
            public string Add(string value2, string value1)
            {
                return (value1 + " " + value2);
            }
     }
}


