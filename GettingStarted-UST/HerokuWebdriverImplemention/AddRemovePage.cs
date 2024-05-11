﻿using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuWebdriverImplemention
{
    public class AddRemovePage : HerokuApp, IAddRemoveOperations
    {
        By hedingLocator;
        By addLocator;
        By addedElementsLocator;

        public AddRemovePage(IWebDriver argDriver) : base(argDriver)
        {
        }
    }
}