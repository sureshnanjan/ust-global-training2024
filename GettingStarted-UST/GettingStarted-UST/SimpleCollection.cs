using System.Collections;

namespace GettingStarted_UST
{
    /// <summary>
    /// This class holds a collection of simple classes
    /// </summary>
    public class SimpleCollection : IEnumerable<SimpleClass>
    {
        List<SimpleClass> list;

        public SimpleCollection()
        {
            list = new List<SimpleClass>();
            list.Add(new SimpleClass(1));
            list.Add(new SimpleClass(2));
            list.Add(new SimpleClass(3));
            list.Add(new SimpleClass(4));
            list.Add(new SimpleClass(5));
        }
        public void publishReport() { }

        public int calculateAverage() {
            return 0;
        }

        IEnumerator<SimpleClass> IEnumerable<SimpleClass>.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
