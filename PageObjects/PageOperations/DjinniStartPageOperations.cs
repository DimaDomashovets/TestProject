using OpenQA.Selenium;
using PageObjects.PageDeclarations;
using PageObjects.PageOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class DjinniStartPageOperations: ABase
    {
        private readonly DjinniStartPageDeclarations PageDeclarations;
             
        public DjinniStartPageOperations(IWebDriver driver) : base(driver)
        {
            PageDeclarations = new DjinniStartPageDeclarations(driver);
        }

        public DjinniLogInPageOperations ClickLoginButton()
        {
            PageDeclarations.LogInBtn.Click();
            return new DjinniLogInPageOperations(driver);
        }

    }
}
