
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObject3.Pages;
using System.Collections.ObjectModel;
using System.Threading;

namespace PageObject3
{
  public class EditEmployeePage : BasePage
  {
    public EditEmployeePage(IWebDriver driver)
      : base(driver, By.XPath("//div[@class='left label' and text()='Utilities:']"), 10)
    {
    }

    public EditEmployeePage AddSubTeachers()
    {
        WaitForElement(By.XPath("//select[@class='utilities-employees-filter-select utilities-employees-role-filter-select']"), 10).Click();
        new SelectElement(WaitForElement(By.XPath("//select[@class='utilities-employees-filter-select utilities-employees-role-filter-select']"), 10)).SelectByIndex(12);
        WaitForElement(By.CssSelector("[data-id='122169']"), 10).Click();
        WaitForElement(By.CssSelector(".substitute-teacher-left-itm.substitute-teacher-input.ui-autocomplete-input"), 10).Click();
        WaitForElement(By.CssSelector(".substitute-teacher-left-itm.substitute-teacher-input.ui-autocomplete-input"), 10).SendKeys("va");
        WaitForElement(By.XPath("//a[contains(@id,'ui-id') and text()='Vadim Teacher']"), 10).Click();
        WaitForElement(By.XPath("//button[@class='btn button-59 utilities-employees-save-btn' and text()='Save']"), 10).Click();
        return new EditEmployeePage(driver);
    }

    public EditEmployeePage DeleteSubTeachers()
    {
        WaitForElement(By.XPath("//select[@class='utilities-employees-filter-select utilities-employees-role-filter-select']"), 10).Click();
        new SelectElement(WaitForElement(By.XPath("//select[@class='utilities-employees-filter-select utilities-employees-role-filter-select']"), 10)).SelectByIndex(12);
        WaitForElement(By.CssSelector("[data-id='122169']"), 10).Click();
        WaitForElement(By.CssSelector(".substitute-teacher-left-itm.substitute-teacher-input.ui-autocomplete-input"), 10).Click();
        WaitForElement(By.CssSelector(".substitute-teacher-left-itm.substitute-teacher-input.ui-autocomplete-input"), 10).Clear();
        WaitForElement(By.XPath("//button[@class='btn button-59 utilities-employees-save-btn']"), 10).Click();
        return new EditEmployeePage(driver);     
    }
  }
}
