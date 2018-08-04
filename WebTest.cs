using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using web_automation_sample.AutomationTestTools;
using web_automation_sample.Pages.Dell;
using Xunit;

namespace web_automation_sample
{
    public class WebTest : TestWebBase
    {

        private DellWorkflow dellWorkflow;

        public WebTest() : base(InitializeWebDriver())
        {
            dellWorkflow = new DellWorkflow(webDriver);
        }

        private static IWebDriver InitializeWebDriver()
        {
            return new ChromeDriver(Environment.CurrentDirectory);
        }

        [Fact]
        public void Test1_LaptopSimpleSearch()
        {

            dellWorkflow.LaptopSearchWorkflow();

        }

        

    }
}
