using System.Linq;
using BesTests.Pages;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace BesTests.Tests
{
    [TestFixture]
  public class AlertTests : BesTestsBase
  {
    [Test]
    public void AlertAdded()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.GoToAlertPage().AddAlert("test alert");
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == CustomerPage.DiaryLogType.AlertAdded));
      Assert.AreEqual("test alert", lead.AllLogs.First<DiaryLog>(a => a.LogType == CustomerPage.DiaryLogType.AlertAdded).ClickToSeeAlertSummary().AlertMessage);
    }

    [Test]
    public void AlertEdit()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.GoToAlertPage().AddAlert("test alert");
      lead.EditAlert().EditAlert("Vadim's Edit");
      Assert.AreEqual("Vadim's Edit", lead.AllLogs.First<DiaryLog>(a => a.LogType == CustomerPage.DiaryLogType.AlertModified).ClickToSeeAlertSummary().AlertMessage);
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == CustomerPage.DiaryLogType.AlertModified));
    }

    [Test]
    public void AlertRemove()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.GoToAlertPage().AddAlert("test alert");
      lead.RemoveAlert().RemoveAlert();
      Assert.AreEqual("test alert", lead.AllLogs.First<DiaryLog>(a => a.LogType == CustomerPage.DiaryLogType.AlertRemoved).ClickToSeeAlertSummary().AlertMessage);
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == CustomerPage.DiaryLogType.AlertRemoved));
    }
  }
}
