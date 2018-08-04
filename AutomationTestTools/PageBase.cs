using OpenQA.Selenium;
using System;

namespace web_automation_sample.AutomationTestTools
{
    public class PageBase : IDisposable
    {

        public IWebDriver webDriver;

        public PageBase(IWebDriver TestWebDriver)
        {
            webDriver = TestWebDriver;
            webDriver.Manage().Window.Maximize();
        }

        public void Dispose()
        {
            webDriver.Dispose();
        }
    }
}
