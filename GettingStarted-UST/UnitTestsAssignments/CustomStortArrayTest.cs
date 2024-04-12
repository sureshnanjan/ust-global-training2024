using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Assignments;

namespace UnitTestsAssignments
{
    public class CustomStortArrayTest
    {
        /// <summary>
        /// Tests sorting of an array of CustomSortArray instances in ascending order based on their properties.
        /// </summary>
        [TestMethod]
        public void TestForSortArrayCorrectly()
        {
            // Arrange
            CustomSortArray instanceOne = new CustomSortArray(1, 2);
            CustomSortArray instanceTwo = new CustomSortArray(2, 3);
            CustomSortArray[] simpleClasses = [instanceTwo, instanceOne];
            CustomSortArray[] expected = [instanceOne, instanceTwo];

            // Act
            Array.Sort(simpleClasses);

            // Assert
            CollectionAssert.AreEqual(simpleClasses, expected);
        }

        /// <summary>
        /// Tests sorting of an array where multiple elements have the same first value.
        /// </summary>
        [TestMethod]
        public void TestForArrayWhenFirstValuesAreSame()
        {
            // Arrange
            CustomSortArray[] simpleClasses = [new CustomSortArray(1, 2), new CustomSortArray(2, 3), new CustomSortArray(1, 1), new CustomSortArray(1, 3)];
            CustomSortArray[] expected = [new CustomSortArray(1, 1), new CustomSortArray(1, 2), new CustomSortArray(1, 3), new CustomSortArray(2, 3)];

            // Act
            Array.Sort(simpleClasses);

            // Assert
            CollectionAssert.AreEqual(simpleClasses, expected);
        }

        /// <summary>
        /// Tests sorting of an array where multiple elements have the same second value.
        /// </summary>
        [TestMethod]
        public void TestForArrayWhenSecondValuesAreSame()
        {
            // Arrange
            CustomSortArray[] simpleClasses = [new CustomSortArray(1, 2), new CustomSortArray(2, 2), new CustomSortArray(3, 2), new CustomSortArray(4, 5)];
            CustomSortArray[] expected = [new CustomSortArray(1, 2), new CustomSortArray(2, 2), new CustomSortArray(3, 2), new CustomSortArray(4, 5)];

            // Act
            Array.Sort(simpleClasses);

            // Assert
            CollectionAssert.AreEqual(simpleClasses, expected);
        }

        /// <summary>
        /// Tests the ToString method of CustomSortArray to ensure it returns the correct format.
        /// </summary>
        [TestMethod]
        public void TestForCorrectFormat()
        {
            // Arrange
            CustomSortArray simpleClass = new CustomSortArray(1, 2);
            string expectedString = "1-2";

            // Act
            string result = simpleClass.ToString();

            // Assert
            Assert.AreEqual(expectedString, result);
        }
    }
}
