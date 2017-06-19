using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using BesTests.Pages.Courses;
using BesTests.Pages.EmploeesPage;
using OpenQA.Selenium;

namespace BesTests.Pages
{
    public class BesHomePage : BasePage
    {
        //private readonly IWebElement _myName;
        private readonly IWebElement _myRow;
        public BesHomePage(IWebDriver driver)
            : base(driver, By.Id("reminders-div"), 10)
        {
        }

        public List<UserBranchPage> UserBranch
        {
            get
            {
                return WaitForElements(By.XPath("//div[@class='utilities-employees-table-branches']"), 10)
                    .Select<IWebElement, UserBranchPage>(rowWebElement => new UserBranchPage(rowWebElement, driver))
                    .ToList<UserBranchPage>();
            }
        }

        //public UserMessagePage GoToUserMessagePage()
        //{
        //    WaitForElement(By.Id("btnBSchoolsUtilities"), 10).Click();
        //    WaitForElement(By.Id("btnUtilitiesAddEmployee"), 10).Click();
        //    return new UserMessagePage(driver);
        //}
        public List<UserNamePage> UserName
        {
            get
            {
                return WaitForElements(By.XPath("//div[@class='utilities-employees-table-employee-name']"), 10)
                    .Select(rowWebElement => new UserNamePage(driver))
                    .ToList<UserNamePage>();
            }
        }

        public void GetEmployeeData()
        {
            List<IWebElement> row = driver.FindElements(By.CssSelector("tr.gridRow")).ToList();
            //Console.WriteLine(row.);
            foreach (IWebElement element in row)
                //  if (element.Text.Contains("cena"))
                Console.WriteLine("{0}", element.Text + Environment.NewLine + "-------------------------------------------");
        }

        public EmployeeRowPage GetFirstRow()
        {
            Thread.Sleep(1000);
            IWebElement first = driver.FindElement(By.CssSelector("tr.utilities-employees-table-tr"));
            Console.WriteLine(first.Text);
            return new EmployeeRowPage(driver);
        }

        public AddLeadPage GoToAddLead()
        {
            WaitForElement(By.Id("btn-new-customer"), 10).Click();
            return new AddLeadPage(driver);
        }

        public CustomerPage GoToCustomerPage(string customerId = "455248674")
        {
            WaitForElement(By.Id("btnCustomers"), 10).Click();
            WaitForElement(By.Id("txbSearchEntity"), 10).SendKeys(customerId);
            WaitForElement(By.Id("btnSearchByIdentity"), 10).Click();
            WaitForElement(By.ClassName("ellipsis"), 10).Click();
            WaitForElement(By.ClassName("jump-to-reminder-button"), 10).Click();
            return new CustomerPage(driver);
        }

        //public AddEditEmployeePage GoToClickOnEditEmployeeButton()
        //    {
        //        WaitForElement(By.Id("btnBSchoolsUtilities"), 10).Click();
        //        WaitForElement(By.Id("btnUtilitiesAddEmployee"), 10).Click();
        //        return new AddEditEmployeePage(driver);
        //    }
        //public List<UserNamePage> UserName
        //{
        //    get
        //    {
        //        return UserName.Where<UserNamePage>(a => a.Name == UserName.).ToList<DiaryLog>();
        //    }
        //}
        public EmployeesPage GoToEmployeesPage()
        {
            return
                GotoUtilities()
                    .GotoEmployeesPage();
        }

        public NotificationPage GoToNotifications()
        {
            WaitForElement(By.Id("notifications-icon"), 10).Click();
            return new NotificationPage(driver);
        }
        public UtilitiesPage GotoUtilities()
        {
            WaitForElement(By.Id("btnBSchoolsUtilities"), 10).Click();
            WaitForElement(By.Id("reports"));
            return new UtilitiesPage(driver);
        }


        public CoursesPage GotoUtilitiesCourses()
        {
            return GotoUtilities().GotoCoursesPage();
        }
    }
    
}




