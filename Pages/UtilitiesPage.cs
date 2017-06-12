using BesTests.Pages.Courses;
using BesTests.Pages.EmploeesPage;
using OpenQA.Selenium;

namespace BesTests.Pages
{
    public class UtilitiesPage : BasePage
    {
        public UtilitiesPage(IWebDriver driver) : base(driver, By.Id("utilities-content"))
        {
        }

        public EmployeesPage GotoEmployeesPage()
        {
            WaitForElement(By.Id("btnUtilitiesAddEmployee"), 10).Click();
            return new EmployeesPage(driver);
        }

        public CoursesPage GotoCoursesPage()
        {
            WaitForElement(By.Id("btnUtilitiesAddCourse"), 10).Click();
            return new CoursesPage(driver);
        }
    }
}