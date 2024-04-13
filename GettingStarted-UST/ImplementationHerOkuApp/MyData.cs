using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ImplementationHerOkuApp
{
    public class MyData
    {
        public static IEnumerable HerOkuAppTestCases
        {
            get
            {
                yield return new TestCaseData("A/B Testing", "A/B Testing");
                yield return new TestCaseData("Add/Remove Elements", "Add/Remove Elements");
                yield return new TestCaseData("Basic Auth", "Basic Auth");
                yield return new TestCaseData("Broken Images", "Broken Images");
            }     
        }
    }
}
