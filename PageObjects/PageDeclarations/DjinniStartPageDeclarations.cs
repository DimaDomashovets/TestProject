using OpenQA.Selenium;

namespace PageObjects.PageDeclarations
{
    public class DjinniStartPageDeclarations : BasePageDeclarations
    {
        public DjinniStartPageDeclarations(IWebDriver driver) : base(driver) { }

        #region XPathes
        private string logInBtn = "//a[contains(text(), 'Log In')]";
        #endregion

        #region WebElements
        public IWebElement LogInBtn => GetElement(logInBtn);
        #endregion
    }
}
