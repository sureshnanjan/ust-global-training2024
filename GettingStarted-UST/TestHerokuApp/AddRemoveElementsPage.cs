using HerokuAppOperations;
using NUnit.Framework;



namespace TestHerokuApp
{
    [TestFixture]
    public class AddRemoveElementsPage
    {
        IAddRemoveElements IaddRem = null;
        /// <summary>
        /// this method is used to validate if the page elelement is displayed on the page   
        /// </summary> 
        ///<returns> boolean value (true/false) depending on the visiility of the flag </returns>


        public bool validatePageElementisDisplayed()
        {
            bool FlagsAttribute = false;
            if (IaddRem.pageContent())
            {
                Console.WriteLine("Page Elements matches !");
                FlagsAttribute = true;
            }
            return FlagsAttribute;
        }

        [Test]
        /// <summary>
        /// this method is used to validate if user can add elemetnts
        /// </summary> 

        public void ValidateAddingElements()
        {
            if (validatePageElementisDisplayed())
            {
                IaddRem.clickOnAddElements();
                Console.WriteLine("New Element Added !");
            }
        }

        /// <summary>
        /// this method is used to validate if user can delete elemetnts. 
        /// Validate if delete button is displayed and click on it 
        /// </summary> 

        [Test]
        public void ValidateDeleteElements()
        {
            if (IaddRem.checkForPresenceofDeleteButton())
            {
                IaddRem.clickOnDelete();
            }
        }
    }
}