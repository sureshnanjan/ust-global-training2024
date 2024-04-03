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

    class Human {
        int age;
        string skincolor;
        string nationality;
        string gender;
        string name;
    }

    class Employee {
        int age;
        //string skincolor;
        string nationality;
        string gender;
        string name;
        string emp_code;
        string skills;
        DateTime doj;
    }

    class DateingPartner {
    
    }

    enum FavColor {
        Black,
        Blue
    }

    


}
