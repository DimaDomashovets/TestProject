using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumWebDriver.Utils
{
    public static class DriverFactory
    {
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new NullReferenceException("The WebDriver instance was not initialize. You should call method GetDriver.");
                return driver;
            }
            private set
            {
                driver = value;
            }
        }


        public static IWebDriver GetDriver()
        {
            switch (TestContext.Parameters["webDriver"])
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "FireFox":
                    driver = new FirefoxDriver();
                    break;
                default:
                    throw new Exception("Unknown browser is defined in run settings");
            }
            return driver;

        }



    }
}
