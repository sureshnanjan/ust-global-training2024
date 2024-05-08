using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    internal class HorizontalSlider : HerokuApp, IHorizontalSlider
    {
        private By contentLocator;
        private By titleLocator;
        private By positionLocator;
        public HorizontalSlider() 
        {
            contentLocator = By.ClassName("subheader");
            titleLocator = By.XPath("//*[@id=\"content\"]/div/a");
            positionLocator = By.Id("range");
        }

        public string getScreenContent()
        {
            
            return driver.FindElement(contentLocator).Text;
           
        }

        public string getSlidePosition()
        {
            return driver.FindElement(positionLocator).Text;    
        }

        public string getTitle()
        {
            return driver.FindElement(titleLocator).Text;
        }

        public void SlidetheBar(int n)
        {
            throw new NotImplementedException();
        }
    }
}
