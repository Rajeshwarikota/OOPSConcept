
using OOPSConcept.Abstraction;
using OOPSConcept.ClassAndObject;
using OOPSConcept.Encapsulation;
using OOPSConcept.Inheritance;
using OOPSConcept.PolyMorphism;
using OOPSConcept.TypesOfMethods;
using OOPSConcept.TypesOfVariablesConcept;
using OOPSConcept.ValueAndReferanceType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OOPS Concept");
            Console.WriteLine("\n1:ClassandObject\n2:Inheritance\n3:Polymorphism\n4:Abstraction\n5:Encapsulation\n6:TypesofVariables\n7:TypesOfMethods\n8:ValueAndReferanceType\n22:Default ");
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
                    Console.WriteLine("\n1:LocalVariable\n2:InstanceVariable\n3:StaticVariable\n4:ConstantVariable\n5:ReadOnlyVariable\n22:Default ");
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
                            Console.WriteLine("Salary of " + instance.Name + "  is " + instance.Salary);
                            break;
                        case 3:
                            StaicVariable.CourseName = "C Sharp";
                            StaicVariable.Members = 400;
                            Console.WriteLine(StaicVariable.CourseName + "'s Total Members are " + StaicVariable.Members);
                            break;
                        case 4:
                            ConstantVariables con = new ConstantVariables();
                            Console.WriteLine("Name of the Item is = " + ConstantVariables.ItemName);
                            Console.WriteLine("Cost of the item is = " + con.Cost);
                            Console.WriteLine("RAM of the Mobile in GB is = " + ConstantVariables.RAM);
                            break;
                        case 5:
                            ReadOnlyVariable var = new ReadOnlyVariable();
                            Console.WriteLine("Name of the Item is = " + ReadOnlyVariable.ItemName);
                            Console.WriteLine("Cost of the item is = " + var.Cost);
                            Console.WriteLine("RAM of the Mobile in GB is = " + ReadOnlyVariable.RAM);
                            Console.WriteLine("Battery of the Mobile in mAh is = " + var.Battery);
                            break;
                        default:
                            Console.WriteLine("Enter the correct option");
                            break;
                    }
                    break;
                case 7:
                    Console.WriteLine("\n1:InstanceMethod\n2:StaticMethod\n22:Default ");
                    int select = Convert.ToInt32(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            InstanceMethod method = new InstanceMethod();
                            method.Name = "Asifa";
                            method.Salary = 40000;
                            method.Employee();
                            break;
                        case 2:
                            StaticMethod.Profession = "Developer";
                            StaticMethod.WorkinhHours = 8;
                            StaticMethod.Employee();
                            break;
                        default:
                            Console.WriteLine("Enter the correct option");
                            break;
                    }
                    break;
                case 8:
                    Console.WriteLine("\n1:ValueType\n22:Default ");
                    int Take = Convert.ToInt32(Console.ReadLine());
                    switch (Take)
                    {
                        case 1:
                            ValueTypeVariables.TestValue();
                            break;
                        default:
                            Console.WriteLine("Enter the correct option");
                            break;
                    }
                    break;
            }
                    Console.ReadLine();
        }
    }
}
