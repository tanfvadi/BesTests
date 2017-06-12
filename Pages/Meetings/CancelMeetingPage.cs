// Decompiled with JetBrains decompiler
// Type: PageObject3.Pages.CancelMeetingPage
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using OpenQA.Selenium;

namespace BesTests.Pages.Meetings
{
  public class CancelMeetingPage : BasePage
  {
    public CancelMeetingPage(IWebDriver driver)
      : base(driver, By.Id("btnCancelSetMeeting"), 10)
    {
    }

    public CancelMeetingPage CancelMeeting()
    {
            WaitForElement(By.Id("btnSaveMeetingCanceled"), 10).Click();
      return new CancelMeetingPage(driver);
    }
  }
}
