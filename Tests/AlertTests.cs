using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObject3.Pages;
using System.Linq;
using static PageObject3.Pages.CustomerPage;

namespace PageObject3.Tests
{
  [TestClass]
  public class AlertTests : BesTestsBase
  {
    [TestMethod]
    public void AlertAdded()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.GoToAlertPage().AddAlert("test alert");
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == DiaryLogType.AlertAdded));
      Assert.AreEqual<string>("test alert", lead.AllLogs.First<DiaryLog>(a => a.LogType == DiaryLogType.AlertAdded).ClickToSeeAlertSummary().AlertMessage);
    }

    [TestMethod]
    public void AlertEdit()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.GoToAlertPage().AddAlert("test alert");
      lead.EditAlert().EditAlert("Vadim's Edit");
      Assert.AreEqual<string>("Vadim's Edit", lead.AllLogs.First<DiaryLog>(a => a.LogType == DiaryLogType.AlertModified).ClickToSeeAlertSummary().AlertMessage);
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == DiaryLogType.AlertModified));
    }

    [TestMethod]
    public void AlertRemove()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.GoToAlertPage().AddAlert("test alert");
      lead.RemoveAlert().RemoveAlert();
      Assert.AreEqual<string>("test alert", lead.AllLogs.First<DiaryLog>(a => a.LogType == DiaryLogType.AlertRemoved).ClickToSeeAlertSummary().AlertMessage);
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == DiaryLogType.AlertRemoved));
    }
  }
}
