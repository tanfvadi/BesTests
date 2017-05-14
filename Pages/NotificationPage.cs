// Decompiled with JetBrains decompiler
// Type: PageObject3.Pages.NotificationPage
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;

namespace PageObject3.Pages
{
  public class NotificationPage : BasePage
  {
    public NotificationPage(IWebDriver driver)
      : base(driver, By.Id("notifications-popup-content"), 10)
    {
    }

    public NotificationPage AddNotification()
    {
            WaitForElement(By.Id("right-icon"), 10).Click();
            WaitForElement(By.Id("notification-title"), 10).Click();
            WaitForElement(By.Id("notification-title"), 10).SendKeys("VadimTest");
            WaitForElement(By.Id("notifocation-desc-field"), 10).SendKeys("VadimTest");
            driver.ExecuteJavaScript("$('#notification-date').datepicker('setDate', new Date()).trigger('change');");
            driver.ExecuteJavaScript("var fiveMinutesLater = new Date();fiveMinutesLater.setMinutes(fiveMinutesLater.getMinutes() + 5);$('#notification-time').timepicker('setTime', fiveMinutesLater).trigger('change');");
            WaitForElement(By.Id("create-edit-container"), 10).Click();
            WaitForElement(By.Id("save-notification"), 10).Click();
      Console.WriteLine("Notification added");
      return new NotificationPage(driver);
    }
  }
}
