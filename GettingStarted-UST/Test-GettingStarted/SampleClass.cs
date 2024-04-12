using System;

namespace Test_GettingStarted
{
    /// <summary>
    /// Sample Class to hold an integer value and perform operation around the same 
    /// </summary>
    internal class SampleClass
    {
        /// <summary>
        /// Constructor with integer type
        /// </summary>
        /// <param name="v"></param>
        public SampleClass(int v)
        {
            number = v;
        }

        /// <summary>
        /// Constructor with Boolean type
        /// </summary>
        /// <param name="v"></param>
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