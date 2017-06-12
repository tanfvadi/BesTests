// Decompiled with JetBrains decompiler
// Type: PageObject3.Tests.SetupMeettingTests
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using System.Linq;
using BesTests.Pages;
using NUnit.Framework;

namespace BesTests.Tests
{
    [TestFixture]
  public class SetupMeettingTests : BesTestsBase
  {
        [Test]
        public new void SetupMeeting()
        {
            CustomerPage lead = LoginAndCreateLead();
            lead.SetupMeetingAndGoToCalendar().SetupMeeting();
            Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == CustomerPage.DiaryLogType.SetupMeeting));
            Assert.IsTrue(lead.ActionLogs.Any<DiaryLog>(a => a.ActionLogType == CustomerPage.LeadLogActionType.PhoneSchedule));
        }
    }
}
