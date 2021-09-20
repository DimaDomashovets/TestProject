using OpenQA.Selenium;
using PageObjects.PageComponents;
using SeleniumWebDriver.Utils;

namespace PageObjects.PageOperations
{
    public class DjinniLogInPageOperations : ABase
    {
        #region Locators
        private string textFieldXpath(string name) => $"//input[@id='{name}']";
        private string buttonXpath => $"//button[@class='btn btn-primary btn-lg']";
        #endregion

        #region Elements
        public TextField LoginField => ElementFactory.Create<TextField>(By.XPath(textFieldXpath("email")));
        public TextField PasswordField => ElementFactory.Create<TextField>(By.XPath(textFieldXpath("password")));
        public Button LoginButton => ElementFactory.Create<Button>(By.XPath(buttonXpath));
        #endregion

        public void TypeTextIntoLogInField(string text, bool shouldClear = false)
        {
            if (shouldClear)
                LoginField.Clear();
            LoginField.SendKeys(text);
        }

        public void TypeTextIntoPasswordField(string text, bool shouldClear = false)
        {
            if (shouldClear)
                PasswordField.Clear();
            PasswordField.SendKeys(text);
        }

        public void PressLogInBtn()
            => LoginButton.Click();

        public DjinniMainPageOperations LogInIntoSystem(string login, string password, bool shouldClear = false)
        {
            TypeTextIntoLogInField(login, shouldClear);
            TypeTextIntoPasswordField(password, shouldClear);
            PressLogInBtn();
            LoggerConfiguration.Log.Info($"User logged in and Main page should be opened");
            return new DjinniMainPageOperations();
        }
    }
}
