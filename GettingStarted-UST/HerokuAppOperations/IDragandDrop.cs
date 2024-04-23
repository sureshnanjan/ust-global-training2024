using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    internal interface IDragandDrop
    {
        /// <summary>
        /// Retrieves the title of the current page.
        /// </summary>
        void GetTitle();

        /// <summary>
        /// Drags item A to item B.
        /// </summary>
        void DragA_B();

        /// <summary>
        /// Drags item B to item A.
        /// </summary>
        void DragB_A();

        /// <summary>
        /// Retrieves the title of box 1.
        /// </summary>
        /// <returns>The title of box 1 as a string.</returns>
        string GetBox1Title();

        /// <summary>
        /// Retrieves the title of box 2.
        /// </summary>
        /// <returns>The title of box 2 as a string.</returns>
        string GetBox2Title();


    }
}
