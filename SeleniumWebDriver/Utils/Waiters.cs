using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumWebDriver.Utils
{
    public class Waiters
    {
        WebDriverWait wait;

        public Waiters(IWebDriver driver, TimeSpan time)
        {
            wait = new WebDriverWait(driver, time);
        }

        public WebDriverWait Wait => wait ?? throw new NullReferenceException("Waiter is null!");
    }
}
