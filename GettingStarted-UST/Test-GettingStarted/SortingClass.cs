namespace Test_GettingStarted
{
    public class SortingClass : IComparable<SortingClass>
    { 

        int value; 
        int value2;

    public SortingClass(int v1, int v2)
    {
        this.value = v1;
        this.value2 = v2;
    }

    public int Value { get { return this.value; } }

    public override string? ToString()
    {
        return this.value.ToString() + "-" + this.value2.ToString(); // SimpleClass(1,2) prints as  "value-value2"
    }

    public override bool Equals(object? obj)
    {
        return this.value.Equals(((SortingClass)obj).Value);
    }

    public int CompareTo(SortingClass? other)
    {
        return this.value.CompareTo(other.Value);
    }
}
}