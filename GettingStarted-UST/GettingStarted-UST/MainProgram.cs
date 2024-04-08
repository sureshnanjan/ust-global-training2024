using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLIbrary;

namespace GettingStarted_UST
{
    public class MainProgram
    {

        public static void Main(string[] args)

        {
            SimpleClass cl1 = new SimpleClass(8,"zA");
            SimpleClass cl2 = new SimpleClass(2,"xB");
            SimpleClass cl3 = new SimpleClass(9,"oZ");
            SimpleClass cl4 = new SimpleClass(1,"AD");
            SimpleClass cl5 = new SimpleClass(3,"bB");
            SimpleClass[] mycoll = { cl1, cl1, cl3, cl4, cl5 };
            Console.WriteLine("Sorting Default");
            Array.Sort(mycoll);
            foreach (var item in mycoll)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sorting By Name ");
            Array.Sort(mycoll, new NameSorter());   
            foreach (var item in mycoll)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sorting By Last Char ");
            Array.Sort(mycoll, new LastCharSorter()); // AAA-HR-1234
            foreach (var item in mycoll)
            {
                Console.WriteLine(item);
            }


        }

        public static void comparableDemo()
        {
            int[] mynumbers = { 8, 3, 19, 21, 1, 2, 3, 4 };
            SimpleClass[] myInstances = { new SimpleClass(8), new SimpleClass(3) , new SimpleClass(19) , new SimpleClass(21),
            new SimpleClass(1), new SimpleClass(2) , new SimpleClass(3) , new SimpleClass(4)};

            string[] strings = { "\nA-One", "B-Two", "C-Three" };

            Array.Sort(strings);
            //strings.
            
            Console.WriteLine("Original Values in My Instances");
            foreach (var item in myInstances)
            {
                Console.Write($"{item} , ");

            }
            
            Console.WriteLine("\n Original Values in My Integer array mynumbers");
            foreach (var item in mynumbers)
            {
                Console.Write($"{item} , ");

            }

            Array.Sort(mynumbers);
            Console.WriteLine("\n AFTER SORTING  Values in My Integer array mynumbers");
            foreach (var item in mynumbers)
            {
                Console.Write($"{item} , ");

            }

            Array.Sort(myInstances);
            Console.WriteLine("\n AFTER SORTING  Values in My Integer MYINSTANCES ");
            foreach (var item in myInstances)
            {
                Console.Write($"{item} , ");

            }

        }
        /*
        private static void oeverridesDemo()
        {
            int test = 10;
            int another = 10;          
            SimpleClass scInstance = new SimpleClass(0,2);
            SimpleClass scInstance2 = new SimpleClass(10, 5);
            SimpleClass scInsstance3 = new SimpleClass(10,5);
            SimpleClass refer = scInsstance3;
            Console.WriteLine(test);
            Console.WriteLine(scInstance.ToString());
            Console.WriteLine(scInstance2.Equals(scInstance)); // False
            Console.WriteLine(scInsstance3.Equals(scInstance2));
            Console.WriteLine(refer.Equals(scInsstance3));
            Console.WriteLine(another.Equals(test));
        }

        */

            /* private static void demo03April()
             {
                 //showDemoforTypes();
                 // Launch a Browser
                 // Navigate to a url
                 // Find the link for logo OOPs
                 // Abstraction
                 // Encapsulation
                 // Hiding all the implementation deatils and exposing only the needed ineterface
                 // Inheritance
                 // Polymorphism - static 
                 //  dynamic / runtime 
                 // demoClassCreation();

                 //Pet mypet = new Pet();
                 Fish fish = new Fish();

                 List<Fish> mypets = new List<Fish>();
                 mypets.Add(fish);
                 mypets.Add(new Fish());



                 foreach (var item in mypets)
                 {
                     item.Feed();

                 }

                 // myBrosweer = chrome
                 // conside rall ingredenents and prepare for cookijg
                 // Salt, Rice, Fish, Oil  class Salt : Coo
                 List<IMoveable> allmymovingthings = new List<IMoveable>();
                 List<ICookable> ingredenients = new List<ICookable>();
                 ingredenients.Add(fish);
                 ingredenients.Add(new Rice());
                 //ingredenients.Add(new Salt())
                 foreach (var item in ingredenients)
                 {
                     item.GetCooked();
                 }
             }

             private static void Move(string direction)
             {

                 switch (direction)
                 {
                     case "left":
                     default:
                         break;
                 }

             }

             private static void Move(Directions dir)
             {
                 switch (dir)
                 {
                     case Directions.left:
                         break;
                     case Directions.right:
                         break;
                     case Directions.forward:
                         break;
                     case Directions.backward:
                         break;
                     default:
                         break;
                 }
             }



             private static void demoClassCreation()
             {
                 MyClassDemo inst = new MyClassDemo("Red", 40, 25);
                 inst.Move(10);
                 MyClassDemo inst1 = new MyClassDemo("Blue", 40, 25);
                 inst1.Move(10);
                 Console.WriteLine($"{MyClassDemo.NoOfObjects} are cteated");
                 MyClassDemo inst2 = new MyClassDemo("Grey", 40, 25);

                 MyClassDemo defparamInstance = new MyClassDemo();

                 inst2.Move(10);
                 MyClassDemo.CommonMethod();
             }

         private static void showDemoforTypes()
             {
                 UsingTypesClass myclass = new UsingTypesClass();
                 UsingTypesStruct mystruct = new UsingTypesStruct();
                 UsingTypesEnum mynumber = UsingTypesEnum.third;

                 int result = Int32.MaxValue;
                 int result1 = Int32.MinValue;
                 Console.WriteLine($"When I add 1,2 the resut is {result} when i subtract 2, 1 the result is {result1}");
                 Console.WriteLine(mynumber);


                 Months month = Months.february;

                 switch (month)
                 {
                     case Months.february: Console.WriteLine(); ; break;
                     case Months.january: Console.WriteLine(); ; break;
                 }
             }
         }

         class Human
         {
             int age;
             string skincolor;
             string nationality;
             string gender;
             string name;
         }

         class Employee
         {
             int age;
             //string skincolor;
             string nationality;
             string gender;
             string name;
             string emp_code;
             string skills;
             DateTime doj;
         }*/


        }
    }
