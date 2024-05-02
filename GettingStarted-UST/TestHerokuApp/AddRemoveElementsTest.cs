using HerokuAppOperations;
using HerokuWebdriverImplemention;
using NUnit.Framework;



namespace TestHerokuApp
{
    [TestFixture]
    public class AddRemoveElementsTest
    {
        IAddRemoveElements IaddRem = new AddRemovePage();
        /// <summary>
        /// this Test is used to validate if the page elelements are displayed on the page   
        ///<returns> boolean value (true/false) depending on the visiility of the flag </returns>
        /// </summary> 
        [Test]
        public void validatePageElementisDisplayed()
        {
            

            Console.WriteLine("Test started at : " + IaddRem.getTime());
            IaddRem.clickAddRemoveElementLink();
            IaddRem.pageContent();
            IaddRem.closeBrowser();
            Console.WriteLine("Test ended  at : " + IaddRem.getTime());

        }

         [Test]
        /// <summary>
        /// this method is used to validate if user can add elemetnts, the parameter accepts the value int; number of 
        /// buttons to be added
        /// </summary> 

           public void ValidateAddingElements()
           {
                      IaddRem.clickAddRemoveElementLink();
                      IaddRem.clickOnAddElements(3);

              
            }


        /// <summary>
        /// this test is used to validate if user can delete elemetnts. Validate if delete button is displayed and click on it 
        /// </summary> 

        [Test]
        public void ValidateDeleteElements()
        {
            if (IaddRem.checkForPresenceofDeleteButton())
            {
                IaddRem.clickOnDelete(2);
            }
        }
    }
}