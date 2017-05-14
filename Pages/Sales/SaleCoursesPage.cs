// Decompiled with JetBrains decompiler
// Type: PageObject3.Pages.SaleCoursesPage
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObject3.Pages
{
  public class SaleCoursesPage : BasePage
  {
    public SaleCoursesPage(IWebDriver driver)
      : base(driver, By.XPath("//div[@class='left sale-title' and text()='Courses']"), 10)
    {
    }

    public PaymentPage SelectCourseAndGoToPaymentPage()
    {
            WaitForElement(By.XPath("//div[@class='left course-name' and @title='DNT']"), 10).Click();
            WaitForElement(By.Name("courseOptionID"), 10).Click();
            new SelectElement(WaitForElement(By.ClassName("cmbCourseOption"), 10)).SelectByIndex(1);
            new SelectElement(WaitForElement(By.ClassName("cmbCourseDate"), 10)).SelectByIndex(1);
            WaitForElement(By.Id("continue-to-extensions"), 10).Click();
            WaitForElement(By.Id("continue-to-payment"), 10).Click();
            WaitForElement(By.Id("submit-sale"), 10).Click();
            WaitForElement(By.Id("futureOption4"), 10).Click();
      return new PaymentPage(driver);
    }

    public CustomerPage ChangeOptionAndSubmitSale()
    {
            WaitForElement(By.Name("courseOptionID"), 10).Click();
            new SelectElement(WaitForElement(By.ClassName("cmbCourseOption"), 10)).SelectByIndex(2);
            WaitForElement(By.Id("continue-to-extensions"), 10).Click();
            WaitForElement(By.Id("continue-to-payment"), 10).Click();
            WaitForElement(By.Id("submit-sale"), 10).Click();
            WaitForElement(By.Id("futureOption3"), 10).Click();
            WaitForElement(By.Id("button-save-future-payments"), 10).Click();
            WaitForElement(By.Id("button-save-delivery-data"), 10).Click();
            WaitForElement(By.XPath("//span[@class='ellipsis' and @title='Change a Sale']"), 10).Click();
      return new CustomerPage(driver);
    }
  }
}
