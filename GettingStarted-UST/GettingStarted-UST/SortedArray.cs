using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_UST
{
    public class SortedArray : IComparable<SortedArray>
    {
<<<<<<< HEAD

        int value;
        int value1;

        public SortedArray(int val, int val1)
=======
        
        int value;
        int value1;
        
        public SortedArray (int val, int val1 )
>>>>>>> intermediate-branch
        {
            this.value = val;
            this.value1 = val1;
        }
        public int MyValue { get { return value; } }

        public override string ToString()
        {
            return this.value.ToString() + "-" + this.value1.ToString();
        }

        public override bool Equals(object? obj)
        {
            return this.value.Equals(((SortedArray)obj).MyValue);
        }

        public int CompareTo(SortedArray? other)
        {
<<<<<<< HEAD
            if (this.value.CompareTo(other.MyValue) == 0)
=======
            if(this.value.CompareTo(other.MyValue)==0)
>>>>>>> intermediate-branch
            {
                return this.value1.CompareTo(other.MyValue);
            }
            return this.value.CompareTo(other.MyValue);
        }
<<<<<<< HEAD
=======

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
>>>>>>> intermediate-branch
    }
}
