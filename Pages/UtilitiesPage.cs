using BesTests.Pages.EmploeesPage;
using OpenQA.Selenium;

namespace BesTests.Pages
{
    public class UtilitiesPage : BasePage
    {
        public UtilitiesPage(IWebDriver driver) : base(driver, By.Id("utilities-content"))
        {
        }

        public EmployeesTablePage GotoUtilitiesEmployeesPage()
        {
            WaitForElement(By.Id("btnUtilitiesAddEmployee"), 10).Click();
            return new EmployeesTablePage(driver);
        }
    }
}