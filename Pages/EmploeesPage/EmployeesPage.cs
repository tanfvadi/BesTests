
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace PageObject3.Pages
{
  public class EmployeePage:BasePage
  {
        //private IWebElement rowWebElement;

        public EmployeePage(IWebDriver driver, By pageVerifierLocator, int pageLoadedTimeout = 10) : base(driver, pageVerifierLocator, pageLoadedTimeout)
        {
        }
        //protected new IWebDriver driver;
        // private By PageVerifierLocator;
        // public List<EmployeeRow> EmployeeRows;

        public void TeachersFilter()
        {
         WaitForElement(By.XPath("//select[@class='utilities-employees-filter-select utilities-employees-role-filter-select']"), 10).Click();
         new SelectElement(WaitForElement(By.XPath("//select[@class='utilities-employees-filter-select utilities-employees-role-filter-select']"), 10)).SelectByIndex(12);
        }

        public void ClickEdit()
        {
        }
  }
}
