
using OpenQA.Selenium;
using PageObject3.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PageObject3.Pages
{
  public class BesHomePage : BasePage
  {
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

    public UserNamePage GoToUserNamePage()
    {
        WaitForElement(By.Id("btnBSchoolsUtilities"), 10).Click();
        WaitForElement(By.Id("btnUtilitiesAddEmployee"), 10).Click();
        return new UserNamePage(driver);
    }

    //public AddEmployeePage GoToClickOnEditEmployeeButton()
    //    {
    //        WaitForElement(By.Id("btnBSchoolsUtilities"), 10).Click();
    //        WaitForElement(By.Id("btnUtilitiesAddEmployee"), 10).Click();
    //        return new AddEmployeePage(driver);
    //    }

    public UserMessagePage GoToUserMessagePage()
    {
        WaitForElement(By.Id("btnBSchoolsUtilities"), 10).Click();
        WaitForElement(By.Id("btnUtilitiesAddEmployee"), 10).Click();
        return new UserMessagePage(driver);
    }

        public List<UserRolePage> UserRole
        {
            get
            {
                return WaitForElements(By.XPath("//div[@class='utilities-employees-table-roles']"), 10).Select<IWebElement, UserRolePage>(rowWebElement => new UserRolePage(rowWebElement, driver)).ToList<UserRolePage>();
            }
        }

        public List<UserBranchPage> UserBranch
    {
        get
        {
           return WaitForElements(By.XPath("//div[@class='utilities-employees-table-branches']"), 10).Select<IWebElement, UserBranchPage>(rowWebElement => new UserBranchPage(rowWebElement, driver)).ToList<UserBranchPage>();
        }
    }

    public List<UserNamePage> UserName
    {
       get
       {
          return WaitForElements(By.XPath("//div[@class='utilities-employees-table-employee-name']"), 10).Select(rowWebElement => new PageObject3.Pages.UserNamePage(driver)).ToList<PageObject3.Pages.UserNamePage>();
       }
    }

        //public List<UserNamePage> UserName
        //{
        //    get
        //    {
        //        return UserName.Where<UserNamePage>(a => a.Name == UserName.).ToList<DiaryLog>();
        //    }
        //}


    public UserRolePage GoToUserRolePage()
    {
    WaitForElement(By.Id("btnBSchoolsUtilities"), 10).Click();
    WaitForElement(By.Id("btnUtilitiesAddEmployee"), 10).Click();
    return new UserRolePage(driver);
    }

    public UserBranchPage GoToUserBranchPage()
    {
    WaitForElement(By.Id("btnBSchoolsUtilities"), 10).Click();
    WaitForElement(By.Id("btnUtilitiesAddEmployee"), 10).Click();
    return new UserBranchPage(driver);
    }

    public EmployeeRowPage GoToEmployeeRowPage()
    {
    WaitForElement(By.Id("btnBSchoolsUtilities"), 10).Click();
    WaitForElement(By.Id("btnUtilitiesAddEmployee"), 10).Click();
    return new EmployeeRowPage(driver);
    }

    public EmployeeRowPage GetFirstRow()
    {
        Thread.Sleep(1000);
        IWebElement first = driver.FindElement(By.CssSelector("tr.utilities-employees-table-tr"));
        Console.WriteLine(first.Text);
        return new EmployeeRowPage(driver);
    }

        public EditEmployeePage GoToEditEmployeePage()
    {
    WaitForElement(By.Id("btnBSchoolsUtilities"), 10).Click();
    WaitForElement(By.Id("btnUtilitiesAddEmployee"), 10).Click();
    return new EditEmployeePage(driver);
    }

    public AddEmployeePage GoToEmployeePage()
    {
    WaitForElement(By.Id("btnBSchoolsUtilities"), 10).Click();
    WaitForElement(By.Id("btnUtilitiesAddEmployee"), 10).Click();
    return new AddEmployeePage(driver);
    }

    public void GetEmployeeData()
    {
    foreach (IWebElement element in driver.FindElements(By.CssSelector("td.tdName")))
    Console.WriteLine("{0}", element.Text);
    }
  }
}
