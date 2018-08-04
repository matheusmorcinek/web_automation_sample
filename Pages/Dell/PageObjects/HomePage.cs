using OpenQA.Selenium;
using web_automation_sample.AutomationTestTools;
using web_automation_sample.AutomationTestTools.Elements;

namespace web_automation_sample.Pages.Dell.PageObjects
{
    public class HomePage : AutomationToolsPageBase
    {

        private readonly string _dellHomePageUrl = "https://www.dell.com/en-us";

        public HomePage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public PageElementButton menuProductsButton { get { return new PageElementButton(webDriver, By.XPath("//li[contains(@data-testid,'Products')]/a")); } }

        public PageElementButton menuProductsLaptopsButton { get { return new PageElementButton(webDriver, By.XPath("//li[contains(@data-testid,'Laptops')]/a")); } }

        public PageElementButton menuProductsLaptopsForHomeButton { get { return new PageElementButton(webDriver, By.XPath("//li[contains(@data-testid,'For Home')]/a")); } }
        

        public void OpenHomePage()
        {
            webDriver.Url = _dellHomePageUrl;
        }

    }

    //public enum MenuProductsItem
    //{
    //    Laptops,
    //    Gaming,
    //    Workstation,
    //    Software
    //}

}
