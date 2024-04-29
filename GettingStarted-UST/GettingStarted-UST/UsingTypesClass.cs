using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal class UsingTypesClass
    {

        // Properties
        // fields
        // Methods
        // Events
        // Indexers
        // Operators 
        int id;
        string name;
        public UsingTypesClass()
        {
            MyClassDemo inst = new MyClassDemo("Red", 40, 25);
            MyClassDemo inst1 = new MyClassDemo("Blue", 40, 25);
            MyClassDemo inst2 = new MyClassDemo("Grey", 40, 25);
            inst.MyProperty = -1;

            inst1.MyProperty = 1;
            inst1.Move(10);
            inst.Move(20);
            Console.WriteLine( inst.Size);
            inst.Move(2);

            name = "Inside a Classs";
        }
    }


    public class MyClassDemo {
        private static int noofInstances = default;
        private string color;
        private  int size;
        private int myVar;
        private int gearposition;
        private int fuel;
        public int Size
        {
            get { return myVar; }
            
        }

        public static int NoOfObjects { get { return noofInstances; } }

        public int MyProperty
        {
            get { return myVar; }
            set {
                if (value < 0) { throw new NotSupportedException(); }
                myVar = value; }
        }

        public MyClassDemo(string col, int size, int fuel)
        {
            this.color = col;
            this.size = size;
            this.myVar = size;
            this.gearposition = fuel;
            noofInstances++;
          
            
                
        }

        public MyClassDemo()
        {
            this.size=100;
            this.gearposition=0;
            this.fuel=0;
            this.color="red";
        }


        // access - rettype - name - params
        public int Move(int dist) {
            Console.WriteLine($"I am moving for {dist} Kms {noofInstances}");
            this.gearposition = 3;
            this.fuel = this.fuel - dist / 10;
            return dist;
        }

        public int Move(int some, int another) {
            return 0;
        }

        public int Move(int some, int another, int yetanother) { return 0; }

        public static void CommonMethod() {
            Console.WriteLine("I ama a common method");
        } 

    }
}
