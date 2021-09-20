using OpenQA.Selenium;
using SeleniumWebDriver.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageComponents
{
    public class TextField: BaseElement
    {
        public void Clear()
            => WebElement.Clear();

        public void SendKeys(string text)
            => WebElement.SendKeys(text);
    }
}
