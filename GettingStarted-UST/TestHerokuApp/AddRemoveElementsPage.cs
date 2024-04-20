using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using Xunit.Sdk;

namespace TestHerokuApp
{
    [TestClass]
    public class AddRemoveElementsPage
    {
        IAddRemoveElements IaddRem = null;
        /// <summary>
        /// this method is used to validate if the page elelement is displayed on the page   
        /// </summary> 
        ///<returns> boolean value (true/false) depending on the visiility of the flag </returns>

        [TestMethod]
        public bool validatePageElementisDisplayed()
        {
            bool FlagsAttribute = false;
            if(IaddRem.pageContent())
            {
                Console.WriteLine("Page Elements matches !");
                FlagsAttribute = true;
            }
            return FlagsAttribute;
        }

        [TestMethod]
        /// <summary>
        /// this method is used to validate if user can add elemetnts
        /// </summary> 
        
        public void ValidateAddingElements()
        {
            if(validatePageElementisDisplayed())
            {
                IaddRem.clickOnAddElements();
                Console.WriteLine("New Element Added !");
            }
        }

        /// <summary>
        /// this method is used to validate if user can delete elemetnts. 
        /// Validate if delete button is displayed and click on it 
        /// </summary> 
        
        [TestMethod]
        public void ValidateDeleteElements()
        {
            if (IaddRem.checkForPresenceofDeleteButton())
            {
                IaddRem.clickOnDelete();
            }
        }
    }
}
