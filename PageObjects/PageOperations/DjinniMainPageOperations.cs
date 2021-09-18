using NUnit.Framework;
using OpenQA.Selenium;
using PageObjects.PageDeclarations;

namespace PageObjects.PageOperations
{
    public class DjinniMainPageOperations : ABase
    {
        private readonly DjinniMainPageDeclarations PageDeclarations;

        public DjinniMainPageOperations(IWebDriver driver) : base(driver)
        {
            PageDeclarations = new DjinniMainPageDeclarations(driver);
        }

        public void VerifyUserEmailHeader(string email)
           => Assert.AreEqual(email, PageDeclarations.GetUserEmail());
    }
}
