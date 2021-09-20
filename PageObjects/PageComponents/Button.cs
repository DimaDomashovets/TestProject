using OpenQA.Selenium;
using SeleniumWebDriver.Utils;

namespace PageObjects.PageComponents
{
    public class Button: BaseElement
    {
        public void Click()
            => WebElement.Click();

    }
}
