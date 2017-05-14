
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObject3.Pages;
using System;
using System.Linq;
using static PageObject3.Pages.CustomerPage;

namespace PageObject3.Tests
{
  [TestClass]
  public class SaleTests : BesTestsBase
  {
    [TestMethod]
    public void NewSale_WhenSubmitSale_SaleLogWillAddedToDiary()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.GoToNewSale().SelectCourseAndGoToPaymentPage().SelectPaymentAndCompleteSale();
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == DiaryLogType.Sale));
    }

    [TestMethod]
    public void CancelSale()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.GoToNewSale().SelectCourseAndGoToPaymentPage().SelectPaymentAndCompleteSale();
      lead.ClickOnCancelButtonAndGoToCancelSale().CancelSale();
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == DiaryLogType.SaleCancelled));
    }

    [TestMethod]
    public void ChangeSale()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.GoToNewSale().SelectCourseAndGoToPaymentPage().SelectPaymentAndCompleteSale();
      lead.ChangelSaleAndGoToSalePage().ChangeOptionAndSubmitSale();
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == DiaryLogType.ChangeaSale));
    }
  }
}
