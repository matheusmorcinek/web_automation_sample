using OpenQA.Selenium;
using web_automation_sample.AutomationTestTools;
using web_automation_sample.Pages.Dell.PageObjects;

namespace web_automation_sample.Pages.Dell
{
    public class DellWorkflow : AutomationToolsWebWorkflow
    {

        private HomePage _dellHomePage;
        
        public DellWorkflow(IWebDriver webDriver) : base(webDriver)
        {
            _dellHomePage = new HomePage(webDriver);
        }
        
        public void LaptopSearchWorkflow()
        {
            
            _dellHomePage.OpenHomePage();

            _dellHomePage.menuProductsButton.Click();

            _dellHomePage.menuProductsLaptopsButton.Click();

            _dellHomePage.menuProductsLaptopsForHomeButton.Click();

        }


    }
}
