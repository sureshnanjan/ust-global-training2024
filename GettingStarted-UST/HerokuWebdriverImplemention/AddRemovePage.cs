﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using HerokuWebdriverImplemention;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
 


namespace HerokuWebdriverImplemention

{
    public class AddRemovePage : HerokuApp, IAddRemoveElements
    {

        private readonly IWebDriver browser;
        private By AddREmoveLink;
        private By PageTitle;
        private By AddElementButton;
        private By deleteButton;

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
        public AddRemovePage()
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

            throw new NotImplementedException();
        }

        /// <summary>
        ///  Add Element button click will add new delete button on the screen as many times as clicked. this method 
        ///  accepts the number of times the button to be clicked and clicks on the Add Element button.
        /// </summary>
        void IAddRemoveElements.clickOnAddElements(int i)
        {
            if (this.clickAddRemoveElementLink())
            {
                if (this.driver.FindElement(AddElementButton).Displayed)
                {
                    for (int j = 0; j < i; j++)

                        this.driver.FindElement(AddElementButton).Click();

                    Console.WriteLine(i + " New Elements Added !");
                }

                else Console.WriteLine("Addremove button not displayed");
            }

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
                Console.WriteLine(i + " delete buttons removed !");
            }

            throw new NotImplementedException();
        }

        /// <summary>
        ///  this method checks and validates the page contents as per requirement
        /// </summary>
        bool IAddRemoveElements.pageContent()
        {
            String expectedTitle = "Add/Remove Elements";
            bool flag = false;
            if (clickAddRemoveElementLink())
            {
                     Console.WriteLine("Page elements displayed properly!");
                    flag = true;
                    String strPageTitile = this.driver.FindElement(PageTitle).Text;
                  //  Assert.That(expectedTitle, strPageTitile);
                  Assert.That(expectedTitle, Is.EqualTo(strPageTitile));

            }
            return flag;

            throw new NotImplementedException();
        }

        /// <summary>
        ///  this method clicks on the Add Remove Elemetns link present on the homepage.
        /// </summary>
        public bool clickAddRemoveElementLink()
        {
            bool flag = false;
            if (this.driver.FindElement(AddREmoveLink).Displayed)
            {
                this.driver.FindElement(AddREmoveLink).Click();
                Console.WriteLine("Add Remove Elements link Clicked !");
                flag = true;
            }
            return flag;
        }

        void IAddRemoveElements.clickAddRemoveElementLink()
        {
            Console.WriteLine("not implemented yet");
        }
    }
}