using OpenQA.Selenium;
using PageObjects.PageComponents;

namespace PageObjects.PageDeclarations
{
    public class DjinniLogInPageDeclarations: BasePageDeclarations
    {
        public DjinniLogInPageDeclarations(IWebDriver driver) : base(driver) { }

        #region XPathes
        private string logInTxtFieldName = "email";
        private string passwordTxtFieldName = "password";
        private string logInBtnName = "Log In";
        #endregion

        #region WebElements
        public TextField LogInTxtField => new TextField(logInTxtFieldName);
        public TextField PasswordTxtField => new TextField(passwordTxtFieldName);
        public Button LogInButton => new Button(logInBtnName);
        #endregion

    }
}
