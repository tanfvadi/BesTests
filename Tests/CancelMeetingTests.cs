﻿// Decompiled with JetBrains decompiler
// Type: PageObject3.Tests.CancelMeetingTests
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObject3.Pages;
using System.Linq;
using System.Threading;
using static PageObject3.Pages.CustomerPage;

namespace PageObject3.Tests
{
  [TestClass]
  public class CancelMeetingTests : BesTestsBase
  {
    [TestMethod]
    public void CancelMeeting()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.SetupMeetingAndGoToCalendar().SetupMeeting();
      lead.CancelMeetingClickAndGoToCancelMeetingPage();
      Thread.Sleep(3000);
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == DiaryLogType.MeetingCanceled));
    }
  }
}
