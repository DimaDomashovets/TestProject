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
        public Driver driver;
        public Waiters waiters;

        private GoogleMainPage _googleMainPage;

        public Pages(Driver driver, Waiters waiters)
        {
            this.driver = driver;
            this.waiters = waiters;
        }

        public GoogleMainPage GoogleMainPage => _googleMainPage ?? new GoogleMainPage(this);





    }
}
