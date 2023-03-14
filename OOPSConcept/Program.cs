
using OOPSConcept.ClassAndObject;
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

            Organization org = new Organization();
            Console.WriteLine("Enter the coursename");
            org.CourseName = Console.ReadLine();
            Console.WriteLine("Enter the BatchNumber");
            int BatchNumber = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter the Mentorname");
            org.MentorName = Console.ReadLine();
            org.Teach();
            org.Lesson();
            
            Console.ReadLine();
        }
    }
}
