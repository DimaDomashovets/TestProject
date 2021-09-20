using OpenQA.Selenium;
using SeleniumWebDriver.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class BaseElement
    {
		public ABase ParentPage { get; set; }
		public IWebElement ParentWebElement { get; set; }
		protected IWebElement WebElement { get; set; }
		internal By Locator { get; set; }

		internal virtual void Init()
		{
			if (ParentWebElement != null)
			{
				WebElement = ParentWebElement.FindElement(Locator);
			}
			else
			{
				WebElement = Driver._Wait.Wait.Until(x => x.FindElement(Locator));
			}
		}

		public virtual void Init(IWebElement webElement)
		{
			try
			{
				if (webElement != null)
				{
					if (webElement.Displayed)
					{
						WebElement = webElement;
					}
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
