
using OOPSConcept.Abstraction;
using OOPSConcept.ClassAndObject;
using OOPSConcept.Encapsulation;
using OOPSConcept.Inheritance;
using OOPSConcept.PolyMorphism;
using OOPSConcept.TypesOfConstructors;
using OOPSConcept.TypesOfInheritance;
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
            Console.WriteLine("\n1:ClassandObject\n2:Inheritance\n3:Polymorphism\n4:Abstraction\n5:Encapsulation\n6:TypesofVariables\n7:TypesOfMethods\n8:ValueAndReferanceType\n9:TypesofInheritance\n10:TypesOfConstructors\n22:Default ");
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
                    Console.WriteLine("\n1:ValueType\n2:ReferanceType\n22:Default ");
                    int Take = Convert.ToInt32(Console.ReadLine());
                    switch (Take)
                    {
                        case 1:
                            ValueTypeVariables.TestValue();
                            break;
                        case 2:
                            break;
                        default:
                            Console.WriteLine("Enter the correct option");
                            break;
                    }
                    break;
                case 9:
                    Console.WriteLine("\n1:SingleInheritance\n2:multilevel\n3:Hierachical\n4:Multiple\n22:Default ");
                    int pick = Convert.ToInt32(Console.ReadLine());
                    switch (pick)
                    {
                        case 1:
                            Car car = new Car();
                            car.Name = "Audi";
                            car.Year = 2023;
                            car.MaxSpeed = 200;
                            Console.WriteLine(car.Name);
                            Console.WriteLine(car.Year);
                            Console.WriteLine(car.MaxSpeed);
                            break;
                        case 2:
                            Babydog babydog = new Babydog();
                            babydog.Name = "Snoopy";
                            babydog.Age = 5;
                            Console.WriteLine("Age of the " + babydog.Name + " is " + babydog.Age);
                            babydog.Bark();
                            babydog.Run();
                            break;
                        case 3:
                            Circle circle = new Circle();
                            circle.Draw();
                            circle.Fill();

                            Rectangle rectangle = new Rectangle();
                            rectangle.Draw();
                            rectangle.Color();

                            Shape shape = new Shape();
                            shape.Draw();
                            break;
                        case 4:
                            Manager manager = new Manager();
                            manager.Work();
                            break;
                        default:
                            Console.WriteLine("Enter the correct option");
                            break;
                    }
                    break;
                 case 10:
                     Console.WriteLine("\n1:DefaultConstructror\n2:ParametrisedConstructor\n22:Default ");
                     int pickout = Convert.ToInt32(Console.ReadLine());
                     switch (pickout)
                     {
                         case 1:
                            DefaultConstructor dc = new DefaultConstructor();
                            Console.WriteLine("Name of the Employee is: " + dc.Name);
                            Console.WriteLine("Department of the Employee: " + dc.Department);
                            break;
                         case 2:
                            Console.WriteLine("Enter the Name");
                            string Name = Console.ReadLine();
                            Console.WriteLine("Enter the Age");
                            int Age = Convert.ToInt32(Console.ReadLine());
                            ParametrizedConstructor pc = new ParametrizedConstructor(Name,Age);
                            Console.WriteLine("Name of the Employee is: " + pc.Name);
                            Console.WriteLine("Department of the Employee: " + pc.Age);
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
