using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ClassAndObject
{
    //ClassName:Organization
    public class Organization
    {
        //Properties 
        //following  PascalCase
        public string CourseName;
        public int BatchNumber;
        public string MentorName;

        //Methods
        //follow PascalCase
        public void Teach()
        {
            Console.WriteLine("Mentors Teaching will be in Easy manner ");
        }
        public void Lesson()
        {
            Console.WriteLine("Students should lesson properly");
        }


    }
}
