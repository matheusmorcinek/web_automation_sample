using OpenQA.Selenium;

namespace web_automation_sample.AutomationTestTools
{
    public class TestWebBase : PageBase
    {
        public TestWebBase(IWebDriver webDriver) : base(webDriver)
        {
        }
    }
}
