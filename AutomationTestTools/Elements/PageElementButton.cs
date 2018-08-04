using OpenQA.Selenium;

namespace web_automation_sample.AutomationTestTools.Elements
{
    public class PageElementButton : BaseElement
    {

        public PageElementButton(IWebDriver webDriver, By by) : base(FindElement(webDriver, by))
        {
            
        }
        
        private static IWebElement FindElement(IWebDriver webDriver, By by)
        {
            return webDriver.FindElement(by);
        }
  
    }
}
