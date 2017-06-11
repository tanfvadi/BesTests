using OpenQA.Selenium;
using PageObject3.Pages.EmploeesPage;

namespace PageObject3.Pages
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