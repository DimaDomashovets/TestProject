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
    public static class BrowserFactory
    {
        public static IWebDriver InitBrowser()
        {
            LoggerConfiguration.Log.Info($"Brower: {TestContext.Parameters["webDriver"]}");
            switch (TestContext.Parameters["webDriver"])
            {
                case "chrome":
                        var options = new ChromeOptions();
                        options.AddArgument("no-sandbox");
                        options.AddArgument("disable-infobars");
                        if (Convert.ToBoolean(TestContext.Parameters["headlessMode"]))
                        {
                            options.AddArgument("--headless");
                            options.AddArgument("--disable-gpu");
                        }
                        return new ChromeDriver(options);
                case "firefox":
                        var firefoxOptions = new FirefoxOptions();
                        if (Convert.ToBoolean(TestContext.Parameters["headlessMode"]))
                        {
                            firefoxOptions.AddArgument("-headless");
                        }
                        return new FirefoxDriver(firefoxOptions);
                default:
                    throw new Exception("Unknown browser is defined in run settings");
            }
        }
    }
}
