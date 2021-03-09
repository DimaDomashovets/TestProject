using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class GoogleSearchTest: ATest
    {
        private string SearchText = "Selenium IDE export to C#";
        private string ExpectedText = "Selenium IDE";

        [SetUp]
        public void SetUp()
        {
            Pages.driver.GoToUrl();
        }

        [Test]
        public void GoogleSearch()
        {
            Pages.GoogleMainPage.PerformSearch(SearchText).
                VerifySearchResultInputField(SearchText).
                VerifySearchResultLink(ExpectedText, 3);
        }


    }
}
