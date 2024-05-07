using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuWebdriverImplemention;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.DevTools.V121.CacheStorage;



namespace HerokuWebdriverImplemention

{
    public class AddRemoveElementsPage : HomePage, IAddRemoveElements
    {

        private By AddREmoveLink;
        private By PageTitle;
        private By AddElementButton;
        private By deleteButton;
       // IHomePage page = new HomePage();

        /// <summary>
        ///  this method captures and prints the time it was called.
        /// </summary>
        public string getTime()
        {

            SystemClock clock = new SystemClock();
            return clock.Now.ToString();

        }

        /// <summary>
        ///  this is the constructor of this class
        /// </summary>
        public AddRemoveElementsPage()
        {

            this.AddREmoveLink = By.XPath("//a[@href=\"/add_remove_elements/\"]");
            this.PageTitle = By.XPath("//h3[text()='Add/Remove Elements']");
            this.AddElementButton = By.XPath("//button[@onclick=\"addElement()\"]");
            this.deleteButton = By.XPath("//button[@class='added-manually']");

        }

        /// <summary>
        ///  this method check if delete button is present on the screen 
        /// </summary>

        bool IAddRemoveElements.checkForPresenceofDeleteButton()
        {
            bool flag = false;
            if(this.driver.FindElement(deleteButton).Displayed)
            {
                Console.WriteLine("Delete button exists");
                flag= true;
            }
            else Console.WriteLine("Delete button not present");

            return flag;
        }

        /// <summary>
        ///  Add Element button click will add new delete button on the screen as many times as clicked. this method 
        ///  accepts the number of times the button to be clicked and clicks on the Add Element button.
        /// </summary>
        void IAddRemoveElements.clickOnAddElements(int i)
        {
           
                    for (int j = 0; j < i; j++)

                        this.driver.FindElement(AddElementButton).Click();

                    Console.WriteLine(i + " New Elements Added !");
     

        }

        /// <summary>
        ///  There can be multiple delete buttons available on the screen; this button accepts the number of buttons to 
        ///  be removed and delete those many buttons.
        /// </summary>
        void IAddRemoveElements.clickOnDelete(int i)
        {
              for (int j = 0; j < i; j++)
                {
                    this.driver.FindElement(deleteButton).Click();
                }
                Console.WriteLine(i + " delete buttons removed !");
          }

        /// <summary>
        ///  this method checks and validates the page contents as per requirement
        /// </summary>
        bool IAddRemoveElements.verifyPageContent()
        {
            String expectedTitle = "Add/Remove Elements";
            bool flag = false;
            Console.WriteLine("Page elements displayed properly!");
            flag = true;
            String strPageTitile = this.driver.FindElement(PageTitle).Text;
            Assert.That(expectedTitle, Is.EqualTo(strPageTitile));
            return flag;
        }

        /// <summary>
        ///  this method clicks on the Add Remove Elemetns link present on the homepage.
        /// </summary>
        

        void IAddRemoveElements.clickAddRemoveElementLink()
        {
            //Launch Heroku-app and click on AddRemoveElements link
           // page.goToExample("AddRemoveElements");
            if (this.driver.FindElement(AddREmoveLink).Displayed)
            {
                this.driver.FindElement(AddREmoveLink).Click();
                Console.WriteLine("Add Remove Elements link Clicked !");
                 
            }
             
        }

        void IAddRemoveElements.closeBrowser()
        {
            this.driver.Close();
        }
    }
}