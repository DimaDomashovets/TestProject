using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.Utils
{
    public class Driver
    {
        public IWebDriver driver;

        public Driver()
        {
            driver = DriverFactory.GetDriver();
        }

        public void GoToUrl()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(TestContext.Parameters["url"].ToString());
        }

        public WebDriverWait InitializeExplicitWait(TimeSpan time)
        {
            return new WebDriverWait(driver, time);
        }

        public void PressEnterOnElement(By selector)
        {
            driver.FindElement(selector).SendKeys(Keys.Enter);
        }

        public void CloseApplication()
        {
            driver?.Quit();
        }


    }
}
