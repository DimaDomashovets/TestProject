using OpenQA.Selenium;
using SeleniumWebDriver.Utils;

namespace PageObjects.PageComponents
{
    public class NavigationBar : BaseElement
    {
        public string GetUserEmail()
           => WebElement.Text;
            

        //private IWebElement navigationBar;

        //public NavigationBar()
        //{
        //    navigationBar = Driver.FindElement(By.XPath(navigationBarXPath));
        //}

        //#region XPathes
        //private string navigationBarXPath => "//nav[@class='navbar navbar-default']/div";
        //private string userEmail => $"{navigationBarXPath}//ul[@class='nav navbar-nav navbar-profile']//div[@class='user-email']";
        //#endregion

        //public string GetUserEmail()
        //   => navigationBar.FindElement(By.XPath(userEmail)).Text;

    }
}
