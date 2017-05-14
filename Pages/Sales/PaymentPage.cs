// Decompiled with JetBrains decompiler
// Type: PageObject3.Pages.PaymentPage
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using OpenQA.Selenium;
using System;
using System.Linq;

namespace PageObject3.Pages
{
  public class PaymentPage : BasePage
  {
    public PaymentPage(IWebDriver driver)
      : base(driver, By.XPath("//div[@class='left sale-title' and text()='Payment']"), 10)
    {
    }

    public CustomerPage SelectPaymentAndCompleteSale()
    {
      WaitForElement(By.Id("button-save-future-payments"), 10).Click();
      WaitForElement(By.Id("button-save-delivery-data"), 10).Click();
      new CustomerPage(driver).SaleLogs.First<DiaryLog>().ClickOnLog();
      Console.WriteLine(WaitForElement(By.CssSelector(".left.right-box-header-title"), 10).Text.Replace("Conclusion -", ""));
      return new CustomerPage(driver);
    }
  }
}
