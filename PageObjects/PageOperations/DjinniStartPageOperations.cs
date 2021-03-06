using OpenQA.Selenium;
using PageObjects.PageComponents;
using PageObjects.PageOperations;
using SeleniumWebDriver.Utils;

namespace PageObjects
{
    public class DjinniStartPageOperations: ABase
    {
        #region Locators
        private string logInBtn = "//a[@class='jobs-push-login-link rounded-link']";
        #endregion

        #region Elements
        public Button LoginButton => ElementFactory.Create<Button>(By.XPath(logInBtn));
        #endregion

        public DjinniLogInPageOperations ClickLoginButton()
        {
            LoginButton.Click();
            LoggerConfiguration.Log.Info($"Log In button clicked!");
            return new DjinniLogInPageOperations();
        }

    }
}
