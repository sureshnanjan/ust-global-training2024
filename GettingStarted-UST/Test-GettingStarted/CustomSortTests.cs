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
            MySimpleClass instanceOne = new(1, 2);
            MySimpleClass instanceTwo = new(2, 3);
            //SimpleClass[] simpleClasses = { new SimpleClass(1, 2), new SimpleClass(0, 1), new SimpleClass(2, 3), new SimpleClass(3, 4) };
            //SimpleClass[] expected = { new SimpleClass(0, 1), new SimpleClass(1, 2), new SimpleClass(2, 3), new SimpleClass(3, 4) };

            MySimpleClass[] simpleClasses = { instanceTwo,instanceOne };
            MySimpleClass[] expected = { instanceOne,instanceTwo };

            Array.Sort(simpleClasses);

            CollectionAssert.AreEqual(simpleClasses, expected);
        }
        
        [TestMethod]
        public void TestForArrayWhenFirstValuesAreSame()
        {
            MySimpleClass[] simpleClasses = { new(1, 2), new MySimpleClass(2, 3), new MySimpleClass(1, 1), new MySimpleClass(1, 3) };
            MySimpleClass[] expected = { new MySimpleClass(1, 1), new MySimpleClass(1, 2), new MySimpleClass(1, 3), new MySimpleClass(2, 3) };

            Array.Sort(simpleClasses);

            CollectionAssert.AreEqual(simpleClasses,expected);
        }
        [TestMethod]
        public void TestForArrayWhenSecondValuesAreSame()
        {
            MySimpleClass[] simpleClasses = { new MySimpleClass(1, 2), new MySimpleClass(2, 2), new MySimpleClass(3, 2), new MySimpleClass(4, 5) };
            MySimpleClass[] expected = { new MySimpleClass(1, 2), new MySimpleClass(2, 2), new MySimpleClass(3, 2), new MySimpleClass(4, 5) };

            Array.Sort(simpleClasses);

            Assert.AreEqual(simpleClasses, expected);
        }
        [TestMethod]
        public void TestForCorrectFormat()
        {
            MySimpleClass simpleClass = new(1,2);

            string expectedString = "1-2";

            string result = simpleClass.ToString();


            Assert.AreEqual(expectedString, result);
        }
    }
}
