
using OOPSConcept.Abstraction;
using OOPSConcept.ClassAndObject;
using OOPSConcept.Encapsulation;
using OOPSConcept.Inheritance;
using OOPSConcept.PolyMorphism;
using OOPSConcept.TypesOfVariables;
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
            Console.WriteLine("\n1:ClassandObject\n2:Inheritance\n3:Polymorphism\n4:Abstraction\n5:Encapsulation\n6:TypesofVariables\n22:Default ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Organization org = new Organization();
                    Console.WriteLine("Enter the coursename");
                    org.CourseName = Console.ReadLine();
                    Console.WriteLine("Enter the BatchNumber");
                    int BatchNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Mentorname");
                    org.MentorName = Console.ReadLine();
                    org.Teach();
                    org.Lesson();
                    break;
                case 2:
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
                    break;
                case 3:
                    College college = new College();
                    college.Study();
                    Seniors seniors = new Seniors();
                    seniors.Study();
                    Juniors juniors = new Juniors();
                    juniors.Study();
                    break;
                case 4:
                    Student student = new Student();
                    student.mark();
                    student.explain();
                    break;
                case 5:
                    Bank bank = new Bank();
                    Console.WriteLine("Enter the name of the bank holder");
                    bank.Name = Console.ReadLine();
                    Console.WriteLine("Enter the Account number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the balance amount");
                    double balance = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Account number of " + bank.Name + " is " + num + " and balance is " + balance);
                    break;
                 case 6:
                    Console.WriteLine("\n1:LocalVariable\n2:InstanceVariable22:Default ");
                    int choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            LocalVariable local = new LocalVariable();
                            local.Addition();
                            break;
                        case 2:
                            InstanceVariable instance = new InstanceVariable();
                            instance.Name = "Raji";
                            instance.Salary = 500000;
                            instance.Display();
                            break;

                    }
                    break;


            }
            Console.ReadLine();
        }
    }
}
