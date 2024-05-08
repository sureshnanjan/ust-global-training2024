using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using HerokuAppOperations;
using HerokuWebdriverImplemention;

namespace HerokuWebdriverImplementation
{
    internal class GeoLocationPage : HerokuApp, IGeoLocation
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        // Constructor to initialize the driver and wait
        public GeoLocationPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        // Method to get the title of the page
        public string GetTitle()
        {
            return driver.Title;
        }

        // Method to get the header shown for the button
        public string GetTheHeaderShownForTheButton()
        {
            // Wait for the header element to be visible
            IWebElement headerElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("demo")));
            return headerElement.Text;
        }

        // Method to click the button
        public void ClickTheButton()
        {
            // Wait for the button element to be clickable
            IWebElement buttonElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"content\"]/div/button")));
            buttonElement.Click();
        }

        // Method to verify the geolocation
        public List<string> VerifyGeoLocation()
        {
            // Find the latitude and longitude elements
            IWebElement latitudeElement = driver.FindElement(By.Id("lat-value"));
            IWebElement longitudeElement = driver.FindElement(By.Id("long-value"));

            // Get the text from latitude and longitude elements
            string latitude = latitudeElement.Text;
            string longitude = longitudeElement.Text;

            // Construct the geolocation information
            List<string> geoLocationInfo = new List<string>();
            geoLocationInfo.Add("Latitude: " + latitude);
            geoLocationInfo.Add("Longitude: " + longitude);

            return geoLocationInfo;
        }

        // Method to click on the 'See it on Google' link
        public void ClickOnVerifyInGoogleLink()
        {
            // Wait for the link element to be clickable
            IWebElement googleLinkElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("See it on Google")));
            googleLinkElement.Click();
        }

        // Method to verify if the current page is a Google Maps page
        public bool VerifyIfGoogleMapPage()
        {
            // Get the URL of the current page
            string currentUrl = driver.Url;

            // Check if the URL contains the expected substring indicating Google Maps page
            return currentUrl.Contains("google.com/maps");
        }
    }
}
