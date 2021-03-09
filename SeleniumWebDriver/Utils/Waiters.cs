using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.Utils
{
    public class Waiters
    {
        Driver driver;
        WebDriverWait wait;

        public Waiters(Driver driver, TimeSpan time)
        {
            this.driver = driver;
            wait = driver.InitializeExplicitWait(time);
        }

        public IWebElement FindElement(By by)
        {
            return wait.Until(drv => drv.FindElement(by));
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return wait.Until(drv => (drv.FindElements(by).Count > 0) ? drv.FindElements(by) : null);
        }

        public IWebElement WaitForElementToBeClickable(By selector)
        {
            return wait.Until(ExpectedConditions.ElementToBeClickable(selector));
        }

    }
}
