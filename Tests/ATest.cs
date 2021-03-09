using NUnit.Framework;
using PageObjects;
using SeleniumWebDriver.Utils;
using System;


namespace Tests
{
    public class ATest
    {
        Driver driver = new Driver();
        Waiters waiters;
        Pages pages;

        Waiters Waiters => (waiters = new Waiters(driver, TimeSpan.FromSeconds(20)));

        public Pages Pages => pages ?? new Pages(driver, Waiters);


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver?.CloseApplication();
        }

    }
}
