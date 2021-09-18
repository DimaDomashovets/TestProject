using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebDriver.Utils;
using System;

namespace PageObjects
{
    public abstract class ABase
    {
        protected IWebDriver driver;

        public ABase(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
