using HerokuAppOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHerokuApp
{
    [TestFixture]
    internal class Test_DragAndDrop
    {
        [Test]
        public void DragAndDropPageTitleisCorrect()
        {
            // Arrange
            IDragandDrop page = default;
            string expectedTitle = "Drag and Drop";
            // Act
            string actualTitle = page.GetTitle();
            // Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }
        [Test]
        public void IsElementDroppedAtoB()
        {

            // Arrange
            IDragandDrop page = default;
            string expectedBox1Title = "B";
            string expectedBox2Title = "A";

            //Act
            page.DragA_B();
            string actualBox1Title = page.GetBox1Title();
            string actualBox2Title = page.GetBox1Title();

            //Assert
            Assert.That(actualBox1Title, Is.EqualTo(expectedBox1Title));
            Assert.That(actualBox2Title, Is.EqualTo(expectedBox2Title));

        }
        [Test]
        public void IsElementDroppedBtoA()
        {

            // Arrange
            IDragandDrop page = default;
            string expectedBox1Title = "A";
            string expectedBox2Title = "B";

            //Act
            page.DragA_B();
            string actualBox1Title = page.GetBox1Title();
            string actualBox2Title = page.GetBox1Title();

            //Assert
            Assert.That(actualBox1Title, Is.EqualTo(expectedBox1Title));
            Assert.That(actualBox2Title, Is.EqualTo(expectedBox2Title));

        }
    }
}
