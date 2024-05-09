using HerokuAppOperations;
using HerokuWebdriverImplemention;
using NUnit.Framework;



namespace TestHerokuApp
{
    [TestFixture]
    public class AddRemoveElementsTest
    {
        
        /// <summary>
        /// this Test is used to validate if the page elelements are displayed on the page   
        ///<returns> boolean value (true/false) depending on the visiility of the flag </returns>
        /// </summary> 
        /// 
        [SetUp]


        [Test]
        public void validatePageElementsareDisplayed()
        {
            IHomePage home = new HomePage();
            IAddRemoveElements IaddRem = (AddRemoveElementsPage)home.goToExample("Add/Remove Elements");
            Console.WriteLine("Test started at : " + IaddRem.getTime());
            IaddRem.clickAddRemoveElementLink();
            IaddRem.verifyPageContent();
            Console.WriteLine("Test ended  at : " + IaddRem.getTime());
            ((IHerokuAppOperations)IaddRem).closeBrowser();
        }

        [Test]
        /// <summary>
        /// this method is used to validate if user can add elemetnts, the parameter accepts the value int; number of 
        /// buttons to be added
        /// </summary> 

        public void ValidateAddingElementsFunctionality()
        {
            IHomePage home = new HomePage();
            IAddRemoveElements IaddRem = (AddRemoveElementsPage)home.goToExample("Add/Remove Elements");
            Console.WriteLine("Test started at : " + IaddRem.getTime());
            IaddRem.clickAddRemoveElementLink();
            IaddRem.clickOnAddElements(7);
            Console.WriteLine("Test ended  at : " + IaddRem.getTime());
            ((IHerokuAppOperations)IaddRem).closeBrowser();
        }


        /// <summary>
        /// this test is used to validate if user can delete elemetnts. Validate if delete button is displayed and click on it 
        /// </summary> 

        [Test]
        public void ValidateDeleteElementsFunctionality()
        {
            IHomePage home = new HomePage();
            IAddRemoveElements IaddRem = (AddRemoveElementsPage)home.goToExample("Add/Remove Elements");
            Console.WriteLine("Test started at : " + IaddRem.getTime());
            IaddRem.clickAddRemoveElementLink();

            IaddRem.clickOnAddElements(5);
            if (IaddRem.checkForPresenceofDeleteButton())
            {
                IaddRem.clickOnDelete(4);
            }
            Console.WriteLine("Test ended  at : " + IaddRem.getTime());
            ((IHerokuAppOperations)IaddRem).closeBrowser();
        }

    }
}