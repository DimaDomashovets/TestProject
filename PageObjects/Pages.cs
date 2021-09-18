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
        private DjinniStartPageOperations _djinniStartPage;
        private DjinniLogInPageOperations _djinniLogInPage;

        public DjinniStartPageOperations DjinniStartPageOperations => _djinniStartPage ?? new DjinniStartPageOperations(Driver._Driver);
        public DjinniLogInPageOperations DjinniLogInOperations => _djinniLogInPage ?? new DjinniLogInPageOperations(Driver._Driver);

    }
}
