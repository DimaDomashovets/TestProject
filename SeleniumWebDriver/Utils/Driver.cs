using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace SeleniumWebDriver.Utils
{
    public static class Driver
    {
        [ThreadStatic]
        private static IWebDriver _driver;
        private static Waiters _wait;

        static Driver()
        {
            _driver = BrowserFactory.InitBrowser();
            _wait = new Waiters(_Driver, TimeForExplicitWait);
        }

        public static TimeSpan TimeForExplicitWait => TimeSpan.FromSeconds(Convert.ToDouble(TestContext.Parameters["explicitWaitTimeout"]));
        public static IWebDriver _Driver => _driver ?? throw new NullReferenceException("Driver is null!");
        public static Waiters _Wait => _wait ?? throw new NullReferenceException("Driver is null!");

        public static void GoToUrl()
        {
            _Driver.Manage().Window.Maximize();
            _Driver.Navigate().GoToUrl(TestContext.Parameters["url"].ToString());
            LoggerConfiguration.Log.Info($"Url: {TestContext.Parameters["url"]} opened");
        }

        public static void TakeScreenshot(string imageName)
        {
            var ss = ((ITakesScreenshot)_Driver).GetScreenshot();
            var ssFileName = Path.Combine(LoggerConfiguration.CurrentTestDirectory.FullName, imageName);
            ss.SaveAsFile($"{ssFileName}.png", ScreenshotImageFormat.Png);
        }
    }
}
