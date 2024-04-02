using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    /// <summary>
    /// Represents a tag.
    /// </summary>
    internal class Tag
    {
		private int id;
		private int name;

		/// <summary>
		/// Gets or Sets Id of the tag.
		/// </summary>
		public int Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or Sets name of the tag.
		/// </summary>
		public int Id
		{
			get { return id; }
			set { id = value; }
		}


	}
}
