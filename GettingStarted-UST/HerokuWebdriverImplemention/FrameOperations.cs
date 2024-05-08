using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class FrameOperationsPage : HerokuApp, IFrameOperations
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public FrameOperationsPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public string GetTitle()
        {
            return driver.Title;
        }

        public List<string> VerifyItems(string itemName)
        {
            // Implement verification of items like nested frames
            throw new NotImplementedException();
        }

        public void ClickOnItem(string itemName)
        {
            // Implement clicking on the item on the page
            throw new NotImplementedException();
        }

        public List<string> VerifyNestedFramesText()
        {
            List<string> frameTexts = new List<string>();
            IReadOnlyCollection<IWebElement> frames = driver.FindElements(By.TagName("frame"));
            IReadOnlyCollection<IWebElement> iframes = driver.FindElements(By.TagName("iframe"));

            foreach (IWebElement frame in frames)
            {
                driver.SwitchTo().Frame(frame);
                frameTexts.Add(driver.FindElement(By.TagName("body")).Text);
                driver.SwitchTo().ParentFrame();
            }

            foreach (IWebElement iframe in iframes)
            {
                driver.SwitchTo().Frame(iframe);
                frameTexts.Add(driver.FindElement(By.TagName("body")).Text);
                driver.SwitchTo().ParentFrame();
            }

            return frameTexts;
        }

        public string GetIframesTitle()
        {
            IWebElement iframe = driver.FindElement(By.LinkText("iFrame"));
            return iframe.GetAttribute("title");
        }

        public bool IsTextEditorDisplayed()
        {
            try
            {
                return driver.FindElement(By.Id("tinymce")).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public List<string> GetTextEditorTools()
        {
            // Implement listing the text editor tools displayed
            throw new NotImplementedException();
        }

        public void GetEditorContent()
        {
            // Implement verifying if text can be entered
            throw new NotImplementedException();
        }
    }
}