using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumWebDriver.Utils;

namespace PageObjects.PageDeclarations
{
    public class BasePageDeclarations
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePageDeclarations(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, Driver.TimeForExplicitWait);
        }

        public IWebElement GetElement(string elementXPath)
            => wait.Until(ExpectedConditions.ElementExists(By.XPath(elementXPath)));
    }
}
