using PageObjects.PageOperations;
using SeleniumWebDriver.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class Pages
    {
        public DjinniStartPageOperations DjinniStartPageOperations => PageFactory.Create<DjinniStartPageOperations>();
        public DjinniLogInPageOperations DjinniLogInPageOperations => PageFactory.Create<DjinniLogInPageOperations>();
    }
}
