using OpenQA.Selenium;

namespace BesTests.Pages.EmploeesPage
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
