using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Inheritance
{
    //Base class
    public class Courses
    {
        public string BatchName;
        public int BatchNumber;
        public void Assignment()
        {
            Console.WriteLine("complete the assignment with in the time");
        }
        public void Practise()
        {
            Console.WriteLine("Students practise more and more");
        }
    }

    //Derived class
    class Batch : Courses
    {
        public string Mentor;

        public void Explain()
        {
            Console.WriteLine("Mentor clarifies the doubt");
        }
        
    }
}

