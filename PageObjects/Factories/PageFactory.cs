using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
	public class PageFactory
	{
		public static T Create<T>() where T : ABase, new()
		{
			var page = new T();
			page.ElementFactory = new ElementFactory(page);
			return page;
		}
	}
}
