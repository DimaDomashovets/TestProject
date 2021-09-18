using OpenQA.Selenium;
using PageObjects.PageComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageDeclarations
{
    public class DjinniMainPageDeclarations :BasePageDeclarations
    {
        public DjinniMainPageDeclarations(IWebDriver driver) : base(driver) { }

        #region XPathes
        #endregion

        #region WebElements
        private NavigationBar UserEmail => new NavigationBar();
        #endregion

        #region Methods
        public string GetUserEmail()
            => UserEmail.GetUserEmail();
        #endregion
    }
}