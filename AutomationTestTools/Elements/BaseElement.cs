using OpenQA.Selenium;

namespace web_automation_sample.AutomationTestTools.Elements
{
    public class BaseElement
    {

        private IWebElement pageElementButton { get; set; }

        public BaseElement(IWebElement webElement)
        {
            pageElementButton = webElement;
        }

        public void Click()
        {
            pageElementButton.Click();
        }


    }
}
