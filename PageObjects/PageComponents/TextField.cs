using OpenQA.Selenium;
using SeleniumWebDriver.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageComponents
{
    public class TextField
    {
        private readonly IWebElement textField;

        public TextField(string name)
        {
            textField = Driver.FindElement(By.XPath(textFieldXpath(name)));
        }

        #region XPathes
        private string textFieldXpath(string name) => $"//input[@id='{name}']";
        #endregion

        public void Clear()
            => textField.Clear();

        public void SendKeys(string text)
            => textField.SendKeys(text);
    }
}
