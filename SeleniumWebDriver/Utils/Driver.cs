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
        private static Waiters wait;

        static Driver()
        {
            _driver = BrowserFactory.InitBrowser();
            wait = new Waiters(_Driver, TimeForExplicitWait);
        }

        public static TimeSpan TimeForExplicitWait => TimeSpan.FromSeconds(Convert.ToDouble(TestContext.Parameters["explicitWaitTimeout"]));
        public static IWebDriver _Driver => _driver ?? throw new NullReferenceException("Driver is null!");

        public static void GoToUrl()
        {
            _Driver.Manage().Window.Maximize();
            _Driver.Navigate().GoToUrl(TestContext.Parameters["url"].ToString());
        }

        public static IWebElement FindElement(By by)
            => wait.Wait.Until(drv => drv.FindElement(by));

        public static ReadOnlyCollection<IWebElement> FindElements(By by)
            => wait.Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
            
        public static IWebElement WaitForElementToBeClickable(By by)
            => wait.Wait.Until(ExpectedConditions.ElementToBeClickable(by));

        public static void TakeScreenshot(string imageName)
        {
            var ss = ((ITakesScreenshot)_Driver).GetScreenshot();
            var ssFileName = Path.Combine(LoggerConfiguration.CurrentTestDirectory.FullName, imageName);
            ss.SaveAsFile($"{ssFileName}.png", ScreenshotImageFormat.Png);
        }
    }
}
