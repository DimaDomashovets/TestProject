using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class GoogleSearchResultPage : ABase
    {
        public GoogleSearchResultPage(Pages pages) : base(pages)
        {
        }

        public GoogleSearchResultPage VerifySearchResultInputField(string text)
        {
            var elementText = waiters.FindElement(By.XPath(GoogleSearchResultPageSelectors.SearchResultTextField)).GetAttribute("value");
            if (elementText.Equals(text))
            {
                return this;
            }
            else
            {
                throw new Exception("Search result text not equal to text that you entered at the main page");
            }
        }

        /// <summary>
        /// Verify wherher specific search result link contain specific phrase
        /// </summary>
        /// <param name="expectedPhrase"></param>
        /// <param name="linkRow"> First link starts from 0 </param>
        /// <returns></returns>
        public GoogleSearchResultPage VerifySearchResultLink(string expectedPhrase, int linkRow)
        {
            var elements = waiters.FindElements(By.XPath(GoogleSearchResultPageSelectors.SearchResultLinks));
            var result = elements[linkRow].Text.Contains(expectedPhrase);
            if (!result)
            {
                throw new Exception($"Link with serial number = {linkRow} doesn`t contain specific phrase");
            }
            return this;
        }
    }

    public static class GoogleSearchResultPageSelectors
    {
        public static string SearchResultTextField => "//div[@class='a4bIc']//input";
        public static string SearchResultLinks => "//h3[@class='LC20lb DKV0Md']//span";
    }
}
