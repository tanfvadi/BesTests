// Decompiled with JetBrains decompiler
// Type: PageObject3.Pages.SetupMeetingPage
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace BesTests.Pages.Meetings
{
  public class SetupMeetingPage : BasePage
  {
    public SetupMeetingPage(IWebDriver driver)
      : base(driver, By.XPath("//div[contains(@class,'scheduler-title')][contains(text(),'Setting Meeting For')]"), 10)
    {
    }

    public SetupMeetingPage SetupMeeting()
    {
      Console.WriteLine(WaitForElement(By.XPath("//div[contains(@class,'scheduler-title')][contains(text(),'Setting Meeting For')]"), 10).Text);
      new Actions(driver).DoubleClick(WaitForElement(By.CssSelector("tr[role='row']:last-of-type td:last-of-type"), 10)).Build().Perform();
            WaitForElement(By.Id("assignee"), 10).Click();
      new SelectElement(WaitForElement(By.Id("assignee"), 10)).SelectByIndex(6);
            WaitForElement(By.Id("room"), 10).Click();
      new SelectElement(WaitForElement(By.Id("room"), 10)).SelectByIndex(8);
            WaitForElement(By.Id("description"), 10).SendKeys("Vadim's Meeting");
            WaitForElement(By.Id("save-schedule-btn"), 10).Click();
      Thread.Sleep(3000);
            CheckAvailibility();
            WaitForElement(By.Id("save-schedule-btn"), 10).Click();
      Thread.Sleep(3000);
            WaitForElement(By.XPath("//div[@class='close-btn' and text()='X']"), 10).Click();
      return new SetupMeetingPage(driver);
    }
  }
}
