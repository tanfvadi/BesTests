// Decompiled with JetBrains decompiler
// Type: PageObject3.Pages.CancelSalePage
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using System.Threading;
using OpenQA.Selenium;

namespace BesTests.Pages.Sales
{
  public class CancelSalePage : BasePage
  {
    public CancelSalePage(IWebDriver driver)
      : base(driver, By.Id("btnSaveSaleCancel"), 10)
    {
      this.driver = driver;
    }

    public CancelSalePage CancelSale()
    {
            WaitForElement(By.Id("102"), 10).Click();
            WaitForElement(By.Id("txbSaleCancelComment"), 10).SendKeys("Give me back my money");
            WaitForElement(By.Id("btnSaveSaleCancel"), 10).Click();
            Thread.Sleep(1000);
            WaitForElement(By.XPath("//button[@class='confirm' and text()='Yes']"), 10).Click();
            WaitForElement(By.XPath("//span[@class='ellipsis' and contains(text(),'Sale Cancelled')]"), 10).Click();
      return new CancelSalePage(driver);
    }
  }
}
