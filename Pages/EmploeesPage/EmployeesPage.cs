
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace PageObject3.Pages
{
  public class AddEmployeePage:BasePage
  {
        private IWebElement rowWebElement;

        //protected new IWebDriver driver;
        // private By PageVerifierLocator;
        // public List<EmployeeRow> EmployeeRows;

        public AddEmployeePage(IWebDriver driver) : base(driver, By.CssSelector(".utilities-employees-main"), 10)
        {
        }


        //public EmployeesPage(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}

        //public EmployeesPage(IWebElement rowWebElement, IWebDriver driver)
        //{
        //    this.rowWebElement = rowWebElement;
        //    this.driver = driver;
        //}

        //public EmployeesPage(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}

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
