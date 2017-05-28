
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;

namespace PageObject3.Pages
{
  public class EmployeesPage:BasePage
  {
      private IWebElement rowWebElement;
  
      private readonly IWebElement _myRow;
     // private IWebElement row;
      private IWebDriver driver;

        //private IWebElement rowWebElement;

      public EmployeesPage(IWebDriver driver, By pageVerifierLocator, int pageLoadedTimeout = 10) : base(driver, pageVerifierLocator, pageLoadedTimeout)
        {
        }

      private List<IWebElement> RowCells => _myRow.FindElements(By.CssSelector("tr")).ToList();

      public string Name => RowCells[1].Text;
      public string Branch => RowCells[2].Text;
      public string Role => RowCells[3].Text;

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
