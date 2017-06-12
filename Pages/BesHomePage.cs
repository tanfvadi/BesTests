using OpenQA.Selenium;
using PageObject3.Pages.EmploeesPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PageObject3.Pages
{
    public class BesHomePage : BasePage
    {
        private readonly IWebElement _myRow;
        private readonly IWebElement _myName;

        public BesHomePage(IWebDriver driver)
            : base(driver, By.Id("reminders-div"), 10)
        {
        }

        public NotificationPage GoToNotifications()
        {
            WaitForElement(By.Id("notifications-icon"), 10).Click();
            return new NotificationPage(driver);
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

        public AddLeadPage GoToAddLead()
        {
            WaitForElement(By.Id("btn-new-customer"), 10).Click();
            return new AddLeadPage(driver);
        }


        //public AddEditEmployeePage GoToClickOnEditEmployeeButton()
        //    {
        //        WaitForElement(By.Id("btnBSchoolsUtilities"), 10).Click();
        //        WaitForElement(By.Id("btnUtilitiesAddEmployee"), 10).Click();
        //        return new AddEditEmployeePage(driver);
        //    }

        //public UserMessagePage GoToUserMessagePage()
        //{
        //    WaitForElement(By.Id("btnBSchoolsUtilities"), 10).Click();
        //    WaitForElement(By.Id("btnUtilitiesAddEmployee"), 10).Click();
        //    return new UserMessagePage(driver);
        //}

        

        public List<UserBranchPage> UserBranch
        {
            get
            {
                return WaitForElements(By.XPath("//div[@class='utilities-employees-table-branches']"), 10)
                    .Select<IWebElement, UserBranchPage>(rowWebElement => new UserBranchPage(rowWebElement, driver))
                    .ToList<UserBranchPage>();
            }
        }

        public List<UserNamePage> UserName
        {
            get
            {
                return WaitForElements(By.XPath("//div[@class='utilities-employees-table-employee-name']"), 10)
                    .Select(rowWebElement => new UserNamePage(driver))
                    .ToList<UserNamePage>();
            }
        }

        //public List<UserNamePage> UserName
        //{
        //    get
        //    {
        //        return UserName.Where<UserNamePage>(a => a.Name == UserName.).ToList<DiaryLog>();
        //    }
        //}


     


        public EmployeeRowPage GetFirstRow()
        {
            Thread.Sleep(1000);
            IWebElement first = driver.FindElement(By.CssSelector("tr.utilities-employees-table-tr"));
            Console.WriteLine(first.Text);
            return new EmployeeRowPage(driver);
        }


        public EmployeesTablePage GoToEmployeesPage()
        {
            return
                GotoUtilities()
                    .GotoUtilitiesEmployeesPage();
        }

        public UtilitiesPage GotoUtilities()
        {
            WaitForElement(By.Id("btnBSchoolsUtilities"), 10).Click();
            WaitForElement(By.Id("reports"));
            return new UtilitiesPage(driver);
        }


        //public List<IWebElement> RowCells => _myName.FindElements(By.CssSelector("tr.gridRow")).ToList();

45        //public string Name => RowCells[4].Text;

        public void GetEmployeeData()
        {
            List<IWebElement> row = driver.FindElements(By.CssSelector("tr.gridRow")).ToList();
            //Console.WriteLine(row.);
            foreach (IWebElement element in row)
                //  if (element.Text.Contains("cena"))
                Console.WriteLine("{0}", element.Text + Environment.NewLine + "-------------------------------------------");
        }
    }
    
}




