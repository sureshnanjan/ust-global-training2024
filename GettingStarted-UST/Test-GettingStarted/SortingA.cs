namespace Test_GettingStarted
{
    /// <summary>
    /// Class to sort the elements in ascending order
    /// </summary>
    public class SortingA : IComparable<SortingA>
    {

        int value;
        int value2;

        //Constructor to load the values
        public SortingA(int v1, int v2)
        {
            this.value = v1;
            this.value2 = v2;
        }

        // Method to provide sent value
        public int Value { get { return this.value2; } }

        // Method to return value in "1-2" format
        public override string? ToString()
        {
            return this.value.ToString() + "-" + this.value2.ToString(); // SimpleClass(1,2) prints as  "value-value2"
        }

        // Method to validate given values and sorting class value are equal
        public override bool Equals(object? obj)
        {
            return this.value.Equals(((SortingA)obj).Value);
        }

        // Method to return and Compare 
        public int CompareTo(SortingA? other)
        {
            return this.value.CompareTo(other.Value);
        }
    }
}