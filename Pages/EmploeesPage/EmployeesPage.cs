
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PageObject3.Pages
{
  public class EmployeesPage:BasePage
  {
        //public new IWebDriver driver;
        public IWebElement rowWebElement;

        public EmployeesPage(IWebDriver driver)
        {
            this.driver = driver;
        }
 

        //public EmployeesPage(IWebDriver driver, By pageVerifierLocator, int pageLoadedTimeout = 10) : base(driver, pageVerifierLocator, pageLoadedTimeout)
        //{
        //}



        public void GetFirstRow()
        {
            Thread.Sleep(1000);
            IWebElement first = driver.FindElement(By.CssSelector("tr.utilities-employees-table-tr"));
            Console.WriteLine(first.Text);
        }
      
    }
}
