using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    internal class UsingTypesClass
    {
        int id;
        string name;
        public UsingTypesClass()
        {
            MyClassDemo inst = new MyClassDemo("Red", 40, 20);
            MyClassDemo inst1 = new MyClassDemo("Green", 40, 25);
            MyClassDemo inst2 = new MyClassDemo("Grey", 40, 25);
            inst.MyProperty = -1;
            Console.WriteLine(inst.Size);
            inst.Move(2);
            name = "Inside a Class";

        }
    }
    class MyClassDemo
    {
        private static int noofInstances = default;
        private string color;
        private int size;
        private int myVar;
        private int gearposition;
        private int fuel;

        public int Size
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public static int NoOfObjects { get { return noofInstances; } }

        public int MyProperty
        {
            get { return myVar; }
            set
            {
                if (value < 0) { throw new NotSupportedException(); }
                myVar = value;
            }
        }


        public MyClassDemo(string col, int size, int fuel)
        {
            this.color = col;
            this.size = size;
            this.myVar = size;
            this.gearposition = fuel;
            noofInstances++;
        }

        public int Move(int dist)
        {
            Console.WriteLine($" I am moving for {dist} kms");
            this.gearposition = 3;
            this.fuel = this.fuel - dist / 10;
            return dist;

        }

        public static void CommonMethod()
        {
            Console.WriteLine("I am Common Method");
        }

    }
}
