namespace Test_GettingStarted
{
    /// <summary>
    /// Class to sort the elements in ascending order
    /// </summary>
    public class SortingClass : IComparable<SortingClass>
    { 

        int value; 
        int value2;

    /// <summary>
    /// Constructor to load the values
    /// </summary>
    /// <param name="v1"></param>
    /// <param name="v2"></param>
    public SortingClass(int v1, int v2)
    {
        this.value = v1;
        this.value2 = v2;
    }

    /// <summary>
    /// Method to provide sent value
    /// </summary>
    public int Value { get { return this.value; } }

    /// <summary>
    /// Method to return value in "1-2" format
    /// </summary>
    /// <returns>String of v1-v2</returns>
    public override string? ToString()
    {
        return this.value.ToString() + "-" + this.value2.ToString(); // SimpleClass(1,2) prints as  "value-value2"
    }
    
    /// <summary>
    /// Method to validate given values and sorting class value are equal
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>Bool true or False</returns>
    public override bool Equals(object? obj)
    {
        return this.value.Equals(((SortingClass)obj).Value);
    }

    /// <summary>
    /// Method to return and Compare 
    /// </summary>
    /// <param name="other"></param>
    /// <returns>int value</returns>
    public int CompareTo(SortingClass? other)
    {
        return this.value.CompareTo(other.Value);
    }
}
}