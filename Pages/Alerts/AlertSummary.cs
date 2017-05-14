// Decompiled with JetBrains decompiler
// Type: PageObject3.Pages.AlertSummary
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using OpenQA.Selenium;

namespace PageObject3.Pages
{
  public class AlertSummary : BasePage
  {
    public string AlertMessage
    {
      get
      {
        return WaitForElement(By.ClassName("lead-entity-alert-message-alert"), 10).GetAttribute("value");
      }
    }

    public AlertSummary(IWebDriver driver)
      : base(driver, By.XPath("//div[@class='label' and text()='Message:']"), 10)
    {
    }
  }
}
