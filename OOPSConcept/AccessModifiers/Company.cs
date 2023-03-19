using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.AccessModifiers
{
    class Company
    {
        protected string Profession;
        protected int Teams;

        protected void GetDetails()
        {
            Console.WriteLine("Profession is: {0}", Profession);
            Console.WriteLine("Teams are: {0}", Teams);
        }
    }
    class Department : Company
    {
        public Department()
        {
            Profession = "IT";
            Teams = 5;
        }

        public void PrintDetails()
        {
            GetDetails();
        }
    }
}
