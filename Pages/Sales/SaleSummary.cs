// Decompiled with JetBrains decompiler
// Type: PageObject3.Pages.SaleSummary
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using OpenQA.Selenium;

namespace PageObject3.Pages
{
  public class SaleSummary : BasePage
  {
    public string SaleMessage
    {
      get
      {
        return WaitForElement(By.ClassName("left course"), 10).GetAttribute("text");
      }
    }

    public SaleSummary(IWebDriver driver)
      : base(driver, By.XPath("//div[@class='sale-title-total-to-pay' and text()='Total to Pay']"), 10)
    {
    }
  }
}
