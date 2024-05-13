﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
//using NUnit.Framework;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class Checkbox : HerokuApp, ICheckboxes
    {
        private IWebDriver browser;
        private By checkBoxLink;
        private By checkBoxTitle;
        private By enablecheckBox1;
        private object Assert;

        public Checkbox()
        {
            this.checkBoxLink = By.XPath("//a[@href=\"/checkboxes\"]");
            this.checkBoxTitle = By.XPath("//h3[text()= 'Checkboxes']");
            this.enablecheckBox1 = By.XPath("//input[@type='checkbox']");

        }


        void ICheckboxes.titleOfCheckBoxPage()
        {
            string expectedTitle = "Checkboxes";
            string actualTitle = this.driver.FindElement(checkBoxTitle).Text;
            //Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }

        void ICheckboxes.clickCheckBoxLink()
        {
            this.driver.FindElement(checkBoxLink).Click();
        }

        void ICheckboxes.enableDisableCheckBox1()
        {
            IWebElement checkbox1 = this.driver.FindElement(enablecheckBox1);
            checkbox1.Click();
            Thread.Sleep(3000);
            checkbox1.Click();
        }

    }
}