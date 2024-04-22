namespace GettingStarted_UST
{
    public class NameSorter : IComparer<SimpleClass>
    {
        public int Compare(SimpleClass? x, SimpleClass? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
