using OpenQA.Selenium;
using System;

namespace PageObjects
{
    public class GoogleMainPage: ABase
    {
        public GoogleMainPage(Pages pages): base(pages)
        {
        }

        public void ClickOnSearchInputField()
        {
            waiters.WaitForElementToBeClickable(By.XPath(GoogleMainPageSelectors.InputField));
        }

        public IWebElement EnterTextInTheSearchFieldandPressEnter(string text, bool clear = false)
        {
            var element = waiters.WaitForElementToBeClickable(By.XPath(GoogleMainPageSelectors.InputField));
            if (clear)
            {
                element.Clear();
            }
            element.SendKeys(text);
            return element;
        }

        public GoogleSearchResultPage PerformSearch(string text)
        {
            if(text == null)
            {
                throw new Exception("Search text is empty");
            }

            ClickOnSearchInputField();
            EnterTextInTheSearchFieldandPressEnter(text).Submit();
            return new GoogleSearchResultPage(pages);
        }

    }

    public static class GoogleMainPageSelectors
    {
        public static string InputField => "//input[@title='Search']";
    }
}
