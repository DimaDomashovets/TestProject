using NUnit.Framework;
using NUnit.Framework.Interfaces;
using PageObjects;
using SeleniumWebDriver.Utils;
using System;


namespace Tests
{
    public class BaseTest
    {
        Pages pages;

        protected Pages Pages => pages ?? new Pages();

        [SetUp]
        protected void SetUp()
        {
            LoggerConfiguration.SetLogger();
            Driver.GoToUrl();
        }

        [OneTimeSetUp]
        public virtual void BeforeAll()
        {
            LoggerConfiguration.CreateTestResultsDirectory();
        }

        [TearDown]
        protected void OneTimeTearDown()
        {
            if (Driver._Driver != null)
            {
                var outcome = TestContext.CurrentContext.Result.Outcome.Status;;

                if (outcome == TestStatus.Passed)
                {
                    LoggerConfiguration.Log.Info("Outcome: Passed");
                }
                else if (outcome == TestStatus.Failed)
                {
                    Driver.TakeScreenshot("test_failed");
                    LoggerConfiguration.Log.Info($"Outcome: Failed");
                    LoggerConfiguration.Log.Info($"Message: {TestContext.CurrentContext.Result.Message}");
                    LoggerConfiguration.Log.Info($"StackTrace: {TestContext.CurrentContext.Result.StackTrace}");
                }

                Driver._Driver.Close();
                Driver._Driver.Quit();
            }
        }

    }
}
