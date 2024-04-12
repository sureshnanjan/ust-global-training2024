using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments
{
    /// <summary>
    /// Represents a collection of SimpleClass objects.
    /// </summary>
    internal class SimpleCollection
    {
        private List<SimpleClass>? list;

        /// <summary>
        /// Initializes a new instance of the SimpleCollection class with a list of SimpleClass objects.
        /// </summary>
        public SimpleCollection()
        {
            List<SimpleClass> list =
            [
                new SimpleClass(1),
                new SimpleClass(2),
                new SimpleClass(3),
                new SimpleClass(4),
                new SimpleClass(5),
            ];
        }

        // Indexer to access elements by index

        /// <summary>
        /// Indexer to access elements by index.
        /// </summary>
        /// <param name="index">The index of the element to get or set.</param>
        /// <returns>The SimpleClass object at the specified index.</returns>
        public SimpleClass this[int index]
        {
            get
            {
                if (index < 0 || index >= list.Count)
                    throw new IndexOutOfRangeException();

                return list[index];
            }
            set
            {
                if (index < 0 || index >= list.Count)
                    throw new IndexOutOfRangeException();

                list[index] = value;
            }
        }
    }
}
