
using OOPSConcept.ClassAndObject;
using OOPSConcept.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OOPS Concept");

            Batch batch = new Batch();  
            Console.WriteLine("Enter the Batchname");
            batch.BatchName = Console.ReadLine();
            Console.WriteLine("Name of the Batch is " + batch.BatchName);
            Console.WriteLine("Enter the Mentorname");
            batch.Mentor = Console.ReadLine();
            Console.WriteLine("Name of the Mentor is " + batch.Mentor);
            Console.WriteLine("Enter the BatchNumber");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Batch number  is " + Number);
            batch.Assignment();
            batch.Practise();
            batch.Explain();
            Console.ReadLine();
        }
    }
}
