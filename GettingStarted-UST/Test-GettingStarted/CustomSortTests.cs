using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted_UST;

namespace Test_GettingStarted
{
    [TestClass]
    public class CustomSortTests
    {
        [TestMethod]
        public void TestForSortArrayCorrectly()
        {
            SimpleClass instanceOne = new(1, 2);
            SimpleClass instanceTwo = new(2, 3);
            //SimpleClass[] simpleClasses = { new SimpleClass(1, 2), new SimpleClass(0, 1), new SimpleClass(2, 3), new SimpleClass(3, 4) };
            //SimpleClass[] expected = { new SimpleClass(0, 1), new SimpleClass(1, 2), new SimpleClass(2, 3), new SimpleClass(3, 4) };

            SimpleClass[] simpleClasses = { instanceTwo,instanceOne };
            SimpleClass[] expected = { instanceOne,instanceTwo };

            Array.Sort(simpleClasses);

            CollectionAssert.AreEqual(simpleClasses, expected);
        }
        
        [TestMethod]
        public void TestForArrayWhenFirstValuesAreSame()
        {
            SimpleClass[] simpleClasses = { new SimpleClass(1, 2), new SimpleClass(2, 3), new SimpleClass(1, 1), new SimpleClass(1, 3) };
            SimpleClass[] expected = { new SimpleClass(1, 1), new SimpleClass(1, 2), new SimpleClass(1, 3), new SimpleClass(2, 3) };

            Array.Sort(simpleClasses);

            CollectionAssert.AreEqual(simpleClasses,expected);
        }
        [TestMethod]
        public void TestForArrayWhenSecondValuesAreSame()
        {
            SimpleClass[] simpleClasses = { new SimpleClass(1, 2), new SimpleClass(2, 2), new SimpleClass(3, 2), new SimpleClass(4, 5) };
            SimpleClass[] expected = { new SimpleClass(1, 2), new SimpleClass(2, 2), new SimpleClass(3, 2), new SimpleClass(4, 5) };

            Array.Sort(simpleClasses);

            Assert.AreEqual(simpleClasses, expected);
        }
        [TestMethod]
        public void TestForCorrectFormat()
        {
            SimpleClass simpleClass = new(1,2);

            string expectedString = "1-2";

            string result = simpleClass.ToString();


            Assert.AreEqual(expectedString, result);
        }
    }
}
