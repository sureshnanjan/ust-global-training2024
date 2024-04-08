using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_GettingStarted
{
    [TestClass]
    public class TestDataOperations
    {
        [TestMethod]
        public void findEvenNumbers() {
            Boolean Actual= DataOperations.CheckEven(10);
            Assert.AreEqual(true, Actual);
        } 

    }
}
