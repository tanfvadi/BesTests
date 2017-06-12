// Decompiled with JetBrains decompiler
// Type: PageObject3.Pages.AlertPage
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using System.Threading;
using OpenQA.Selenium;

namespace BesTests.Pages.Alerts
{
  public class AlertPage : BasePage
  {
    public AlertPage(IWebDriver driver)
      : base(driver, By.XPath("//div[@class='popup-header-title' and text()='Alert']"), 10)
    {
    }

    public CustomerPage AddAlert(string alertText)
    {
            WaitForElement(By.Id("lead-entity-alert-popup-message-alert-textarea"), 10).SendKeys(alertText);
            WaitForElement(By.Id("lead-entity-alert-popup-save"), 10).Click();
            WaitUntilPageDisappears(10);
      return new CustomerPage(driver);
    }

    public CustomerPage EditAlert(string alertText)
    {
            WaitForElement(By.Id("lead-entity-alert-edit"), 10).Click();
            WaitForElement(By.Id("lead-entity-alert-popup-message-alert-textarea"), 10).Clear();
            WaitForElement(By.Id("lead-entity-alert-popup-message-alert-textarea"), 10).SendKeys(alertText);
            WaitForElement(By.Id("lead-entity-alert-popup-save"), 10).Click();
            WaitUntilPageDisappears(10);
      return new CustomerPage(driver);
    }

    public CustomerPage RemoveAlert()
    {
            WaitForElement(By.Id("lead-entity-alert-edit"), 10).Click();
            WaitForElement(By.Id("lead-entity-alert-delete"), 10).Click();
            Thread.Sleep(1000);
            WaitForElement(By.XPath("//button[@class='confirm' and text()='Yes']"), 10).Click();
            WaitUntilPageDisappears(10);
      return new CustomerPage(driver);
    }
  }
}
