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
        public void validatePageElementisDisplayed()
        {
            IAddRemoveElements IaddRem = null;
            Console.WriteLine("Test started at : " + IaddRem.getTime());
            IaddRem.goToExample("AddRemoveElements");
            IaddRem.verifyPageContent();
            page.closeBrowser();
            Console.WriteLine("Test ended  at : " + IaddRem.getTime());
        }

       
    }
}