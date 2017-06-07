
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
     
        private readonly IWebElement _myRow;
        public IEnumerable<IWebElement> rows;

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

      public void GetRowsFromEmployeesPage()
      {
          IList<IWebElement> names = driver.FindElements(By.CssSelector("tr.utilities-employees-table-tr"));
          foreach (IWebElement element in names)
              if (element.Text.Contains("Diana"))
                  Console.WriteLine("{0}", element.Text + Environment.NewLine + "-------------------------------------------");
      }


    //  public void GetRowsFromEmployeesPage()
    //{
    //    foreach (var row in driver.FindElements(By.CssSelector("tr.utilities-employees-table-tr")).ToList())
    //    {
    //        var columns = row.FindElements(By.CssSelector("td")).ToList();           
    //        if (row.Text.Contains("Vadim"))
    //        Console.WriteLine(columns[0].Text + Environment.NewLine + "-------------------------------------------");
    //    }
    //} 

    public void TeacherFilterAndEdit()
    {
        WaitForElement(By.XPath("//select[@class='utilities-employees-filter-select utilities-employees-role-filter-select']"), 10).Click();
        new SelectElement(WaitForElement(By.XPath("//select[@class='utilities-employees-filter-select utilities-employees-role-filter-select']"), 10)).SelectByIndex(12);
        WaitForElement(By.CssSelector("[data-id='122169']"), 10).Click();
    }
  }
}
