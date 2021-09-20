using NUnit.Framework;
using OpenQA.Selenium;
using PageObjects.PageComponents;
using SeleniumWebDriver.Utils;

namespace PageObjects.PageOperations
{
    public class DjinniMainPageOperations : ABase
    {

        #region Locators
        private string navigationBarXPath => "//nav[@class='navbar navbar-default']/div";
        private string userEmail => $"{navigationBarXPath}//ul[@class='nav navbar-nav navbar-profile']//div[@class='user-email']";
        #endregion

        #region Elements
        public NavigationBar UserEmail => ElementFactory.Create<NavigationBar>(By.XPath(userEmail));
        
        #endregion

        public void VerifyUserEmailHeader(string email)
        {
            Assert.AreEqual(email, UserEmail.GetUserEmail());
            LoggerConfiguration.Log.Info($"Expected email name - {email} meets actual - {UserEmail.GetUserEmail()}");
        }
    }
}
