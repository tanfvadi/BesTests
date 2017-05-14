
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PageObject3.Pages
{
  public class EmployeeRowPage : BasePage
  {
    public List<PageObject3.Pages.UserRolePage> UserRole
    {
      get
      {
        return WaitForElements(By.XPath("//div[@class='utilities-employees-table-roles']"), 10).Select<IWebElement, PageObject3.Pages.UserRolePage>(rowWebElement => new PageObject3.Pages.UserRolePage(rowWebElement, driver)).ToList<PageObject3.Pages.UserRolePage>();
      }
    }

    public List<PageObject3.Pages.UserMessagePage> UserMessage
    {
      get
      {
        return WaitForElements(By.CssSelector("input[type=checkbox][class='utilities-employees-msg-chk-all']"), 10).Select<IWebElement, PageObject3.Pages.UserMessagePage>(rowWebElement => new PageObject3.Pages.UserMessagePage(rowWebElement, driver)).ToList<PageObject3.Pages.UserMessagePage>();
      }
    }

    public List<PageObject3.Pages.UserBranchPage> UserBranch
    {
        get
        {
         return WaitForElements(By.XPath("//div[@class='utilities-employees-table-branches' and text()='Branch Manager,Teacher']"), 10).Select(rowWebElement =>new PageObject3.Pages.UserBranchPage(driver)).ToList<PageObject3.Pages.UserBranchPage>();
        }
    }

    public List<PageObject3.Pages.UserNamePage> UserName
    {
        get
        {
         return WaitForElements(By.XPath("//div[@class='utilities-employees-table-employee-name']"), 10).Select(rowWebElement => new PageObject3.Pages.UserNamePage(driver)).ToList<PageObject3.Pages.UserNamePage>();
        }
    }

    //public List<PageObject3.Pages.EmployeesPage> UserEdit
    //{
    //    get
    //    {
    //        return WaitForElements(By.XPath("//div[@class='utilities-employees-edit-btn image-icon-btn' and title()='Edit Employee']"), 10).Select(rowWebElement => new EmployeesPage(rowWebElement, driver)).ToList<PageObject3.Pages.EmployeesPage>();
    //    }
    //}


        public EmployeeRowPage(IWebDriver driver)
      : base(driver, By.XPath("//div[@class='utilities-employees-edit-btn image-icon-btn' and title()='Edit Employee']"))
    {
    }

    public void GetRowsFromEmployeesPage()
    {
        Thread.Sleep(1000);
        foreach (IWebElement element in driver.FindElements(By.CssSelector("tr.utilities-employees-table-tr")))
            if (element.Text.Contains("Diana"))
            Console.WriteLine(element.Text + Environment.NewLine + "-------------------------------------------");
    }
   }
}
