using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class ElementFactory
    {
		private static ABase Page { get; set; }
 
        public ElementFactory(ABase page)
        {
            Page = page;
        }

        public static T Create<T>(By locator, IWebElement parentWebElement = null) where T : BaseElement, new()
		{
			var element = new T { Locator = locator, ParentPage = Page, ParentWebElement = parentWebElement };
			element.Init();
			return element;
		}
	}
}
