using System;

namespace Test_GettingStarted
{
    /// <summary>
    /// Sample Class to hold an integer value and perform operation around the same 
    /// </summary>
    internal class SampleClass
    {
        //Constructor with integer type
        public SampleClass(int v)
        {
            number = v;
        }

        //Constructor with Boolean type
        public SampleClass(bool v)
        {
            status = v;
        }

        public int number { get; }
        public bool status { get; }
       
        // Overloading for + operator
        public static SampleClass operator +(SampleClass a, SampleClass b)
        {
            return new SampleClass(a.number + b.number);
        }
        //Overloading for > Operator
        public static SampleClass operator >(SampleClass a, SampleClass b)
        {
            return new SampleClass(a.number > b.number);
        }

        //Overloading for < Operator
        public static SampleClass operator <(SampleClass a, SampleClass b)
        {
            return new SampleClass(a.number < b.number);
        }
    }
}