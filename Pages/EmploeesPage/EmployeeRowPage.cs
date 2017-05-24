
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PageObject3.Pages
{
  public class EmployeeRowPage : EmployeesPage
  {
    public EmployeeRowPage(IWebDriver driver)
    : base(driver, By.XPath("//div[@class='utilities-employees-header']"))
    {
    }


    public List<UserMessagePage> UserMessage
    {
        get
        {
          return WaitForElements(By.CssSelector("input[type=checkbox][class='utilities-employees-msg-chk-all']"), 10).Select<IWebElement, PageObject3.Pages.UserMessagePage>(rowWebElement => new PageObject3.Pages.UserMessagePage(rowWebElement, driver)).ToList<PageObject3.Pages.UserMessagePage>();
        }
    }


        //public List<PageObject3.Pages.EmployeePage> UserEdit
        //{
        //    get
        //    {
        //        return WaitForElements(By.XPath("//div[@class='utilities-employees-edit-btn image-icon-btn' and title()='Edit Employee']"), 10).Select(rowWebElement => new EmployeePage(rowWebElement, driver)).ToList<PageObject3.Pages.EmployeePage>();
        //    }
        //}

    public void GetRowsFromEmployeesPage()
    {
        Thread.Sleep(1000);
        foreach (IWebElement element in driver.FindElements(By.CssSelector("tr.utilities-employees-table-tr")))
        if (element.Text.Contains("Diana"))
        Console.WriteLine(element.Text + Environment.NewLine + "-------------------------------------------");
    } 

    public void TeacherFilterAndEdit()
    {
        WaitForElement(By.XPath("//select[@class='utilities-employees-filter-select utilities-employees-role-filter-select']"), 10).Click();
        new SelectElement(WaitForElement(By.XPath("//select[@class='utilities-employees-filter-select utilities-employees-role-filter-select']"), 10)).SelectByIndex(12);
        WaitForElement(By.CssSelector("[data-id='122169']"), 10).Click();
    }
  }
}
