using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HerokuAppOperations;
using NUnit.Framework;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class Dynamicloadingpage : HerokuApp, IDynamicLoadingPage
    {
       

        private readonly By dynamicLoadingpageLink;
        private readonly By pageContentLocator;
        private readonly By pageTitleLocator;
        private readonly By example1Locator;
        private readonly By example2Locator;
        private readonly By example1SubTitle;
        private readonly By example2SubTitle;
        private readonly By exapmle1StartBtn;
        private readonly By exapmle2StartBtn;
        private readonly By startMessageLocator;

        public Dynamicloadingpage(IWebDriver driver) :base(driver)
        {
            this.pageContentLocator = By.XPath("//p[1]");
            this.pageTitleLocator = By.XPath("//h3[contains(text(),'Dynamically')]");
            this.example1Locator = By.XPath("//a[contains(text(),'Example 1')]");
            this.example2Locator = By.XPath("//a[contains(text(),'Example 2')]");
            this.example1SubTitle = By.XPath("//*[@id=\"content\"]/div/h4");
            this.example2SubTitle = By.XPath("//*[@id=\"content\"]/div/h4");
            this.exapmle1StartBtn = By.XPath("//button[text()='Start']");
            this.exapmle2StartBtn = By.XPath("//button[text()='Start']");
            this.startMessageLocator = By.XPath("//div[@id=\"finish\"]/h4");
            this.dynamicLoadingpageLink = By.XPath("//a[contains(text(),'Dynamic Loading')]");
            //openDynamicLoadingPage();
        }

        void IDynamicLoadingPage.enableStart()
        {
           this.driver.FindElement(exapmle1StartBtn).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9);
            
        }

        string IDynamicLoadingPage.getDescription()
        {
            Console.WriteLine("desc text : " + this.driver.FindElement(pageContentLocator).Text);
            return this.driver.FindElement(pageContentLocator).Text;
        }

        int IDynamicLoadingPage.getExamplesCount() // change return type to int
        {
           if(this.driver.FindElement(example1Locator).Displayed && this.driver.FindElement(example2Locator).Displayed)
                return 2;
           else return 0;
        }

        string IDynamicLoadingPage.getStartMessage()
        {
            Console.WriteLine(" actual : " + this.driver.FindElement(startMessageLocator).GetAttribute("innerHTML"));
            return this.driver.FindElement(startMessageLocator).GetAttribute("innerHTML");
        }

        string IDynamicLoadingPage.getSubTitleExample1()
        {
            return this.driver.FindElement(example1SubTitle).Text;
        }

        string IDynamicLoadingPage.getSubTitleExample2()
        {
            return this.driver.FindElement(example2SubTitle).Text;
        }

        string IDynamicLoadingPage.getTitle()
        {
            return this.driver.FindElement(pageTitleLocator).Text;
        }

        void IDynamicLoadingPage.goToExampleLinks(string exampleName)
        {

            if(exampleName.Contains("Example 2"))
            {
                this.driver.FindElement(example2Locator).Click();
            }else if (exampleName.Contains("Example 1"))
            {
                this.driver.FindElement(example1Locator).Click();
            }
         }

       public void openDynamicLoadingPage()
        {
            this.driver.FindElement(dynamicLoadingpageLink).Click();
        }


        //public void closeBrowser()
       // {
        //    this.driver.Quit();
       // }
    }
}
