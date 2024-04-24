using HerokuAppOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class BrokenImagePage : HerokuApp, IBrokenImageOperations
    {
        private readonly By headingLocator;
        private readonly By image1Locator;
        private readonly By image2Locator;
        private readonly By image3Locator;

        public string getHeading()
        {
            return this.driver.FindElement(headingLocator).Text;
        }

        public string getImage1Details()
        {
            return this.driver.FindElement(image1Locator).GetAttribute("src");
        }

        public string getImage2Details()
        {
            return this.driver.FindElement(image1Locator).GetAttribute("src");
        }

        public string getImage3Details()
        {
            return this.driver.FindElement(image1Locator).GetAttribute("src");
        }
    }
}
