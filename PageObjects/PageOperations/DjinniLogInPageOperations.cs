using OpenQA.Selenium;
using PageObjects.PageDeclarations;

namespace PageObjects.PageOperations
{
    public class DjinniLogInPageOperations : ABase
    {
        private readonly DjinniLogInPageDeclarations PageDeclarations;

        public DjinniLogInPageOperations(IWebDriver driver) : base(driver)
        {
            PageDeclarations = new DjinniLogInPageDeclarations(driver);
        }

        public void TypeTextIntoLogInField(string text, bool shouldClear = false)
        {
            if (shouldClear)
                PageDeclarations.LogInTxtField.Clear();
            PageDeclarations.LogInTxtField.SendKeys(text);
        }

        public void TypeTextIntoPasswordField(string text, bool shouldClear = false)
        {
            if (shouldClear)
                PageDeclarations.PasswordTxtField.Clear();
            PageDeclarations.PasswordTxtField.SendKeys(text);
        }

        public void PressLogInBtn()
            => PageDeclarations.LogInButton.Click();

        public DjinniMainPageOperations LogInIntoSystem(string login, string password, bool shouldClear = false)
        {
            TypeTextIntoLogInField(login, shouldClear);
            TypeTextIntoPasswordField(password, shouldClear);
            PressLogInBtn();
            return new DjinniMainPageOperations(driver);
        }
    }
}
