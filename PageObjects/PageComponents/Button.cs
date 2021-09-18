using OpenQA.Selenium;
using SeleniumWebDriver.Utils;

namespace PageObjects.PageComponents
{
    public class Button
    {
        private readonly IWebElement button;

        public Button(string name)
        {
            button = Driver.FindElement(By.XPath(buttonXpath(name)));
        }

        #region XPathes
        private string buttonXpath(string name) => $"//button[contains(text(), '{name}')]";
        #endregion

        public void Click()
            => button.Click();
    }
}
