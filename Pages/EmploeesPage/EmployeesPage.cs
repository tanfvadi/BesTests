
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PageObject3.Pages
{
  public class EmployeesPage:BasePage
  {
      private IWebElement rowWebElement;
    
     // private IWebElement row;
      private IWebDriver driver;

        //private IWebElement rowWebElement;

        public EmployeesPage(IWebDriver driver, By pageVerifierLocator, int pageLoadedTimeout = 10) : base(driver, pageVerifierLocator, pageLoadedTimeout)
        {
        }

      public void SelectAllMessages()
      {
          Thread.Sleep(1000);
          driver.FindElement(By.XPath("//input[@class='utilities-employees-msg-chk-all']")).Click();
      }

        //public EmployeePage(IWebElement rowWebElement, IWebDriver driver)
        //{
        //    this.rowWebElement = rowWebElement;
        //    this.driver = driver;
        //}

        //protected new IWebDriver driver;
        // private By PageVerifierLocator;
        // public List<EmployeeRow> EmployeeRows;


    }
}
