using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebDriver.Utils;
using System;

namespace PageObjects
{
    public abstract class ABase
    {
        protected internal ElementFactory ElementFactory { get; set; }
    }
}
