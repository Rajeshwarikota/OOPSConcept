using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ValueAndReferanceType
{
    internal class ValueTypeVariables
    {
        public static void TestValue()
        {
            int x = 500;
            Console.WriteLine("Before changing value of x :" + x);
            ChangeValue(x);
            Console.WriteLine("After changing value of x :" + x);
        }
        public static void ChangeValue(int x)
        {
            x = x + 100;
            Console.WriteLine("With in the method x value is " + x);
        }
    }
}

