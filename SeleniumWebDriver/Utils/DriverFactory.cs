using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace SeleniumWebDriver.Utils
{
    public static class DriverFactory
    {
        private static IWebDriver driver { get; set; }

        public static IWebDriver GetDriver()
        {
            switch (TestContext.Parameters["webDriver"])
            {
                case "Chrome":
                    if (driver == null)
                        driver = new ChromeDriver();
                    break;
                case "FireFox":
                    if (driver == null)
                        driver = new FirefoxDriver();
                    break;
                default:
                    throw new Exception("Unknown browser is defined in run settings");
            }
            return driver;

        }

    }
}
