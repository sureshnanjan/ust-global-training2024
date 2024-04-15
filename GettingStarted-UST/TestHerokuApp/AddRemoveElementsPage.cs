using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;

namespace TestHerokuApp
{
    [TestClass]
    public class AddRemoveElementsPage
    {
      /// <summary>
     /// this method is used to validate if the page elelement is displayed on the page   
     /// </summary> 
        IAddRemoveElements IaddRem = null;

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

        /// <summary>
        /// this method is used to validate if user can add elemetnts
        /// </summary> 
        
        [TestMethod]
        public void AddElements()
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
        public void DeleteElements()
        {
            if (IaddRem.checkForPresenceofDeleteButton())
            {
                IaddRem.clickOnDelete();
            }
        }
    }
}
