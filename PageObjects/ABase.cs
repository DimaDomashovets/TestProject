using OpenQA.Selenium.Interactions;
using SeleniumWebDriver.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public abstract class ABase
    {
        protected Driver driver;
        protected Waiters waiters;
        protected Pages pages;

        public static TimeSpan TimeForExplicitWait => TimeSpan.FromSeconds(20);

        public ABase(Pages page)
        {
            pages = page;
            waiters = page.waiters;
            driver = page.driver; 
        }


    }
}
