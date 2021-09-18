using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.Utils
{
    public static class LoggerConfiguration
    {
        public static string MAIN_DIRECTORY = Path.GetFullPath(@"../");

        public static DirectoryInfo CurrentTestDirectory;

        private static Logger _logger;

        public static Logger Log => _logger ?? throw new NullReferenceException("_logger is null. SetLogger() first!");

        public static DirectoryInfo CreateTestResultsDirectory()
        {
            var testDirectory = MAIN_DIRECTORY + "TestResults";

            if (Directory.Exists(testDirectory))
            {
                Directory.Delete(testDirectory, recursive: true);
            }

            return Directory.CreateDirectory(testDirectory);
        }

        public static void SetLogger()
        {
            var testResultsDir = MAIN_DIRECTORY + "TestResults";
            var testName = TestContext.CurrentContext.Test.Name;
            var fullPath = $"{testResultsDir}/{testName}";

            if (Directory.Exists(fullPath))
            {
                CurrentTestDirectory = Directory.CreateDirectory(fullPath + TestContext.CurrentContext.Test.ID);
            }
            else
            {
                CurrentTestDirectory = Directory.CreateDirectory(fullPath);
            }

            _logger = new Logger(testName, CurrentTestDirectory.FullName + "/log.txt");
        }
    }
}
