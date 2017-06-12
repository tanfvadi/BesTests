using System.Linq;
using BesTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BesTests.Tests
{
  [TestClass]
  public class SaleTests : BesTestsBase
  {
    [TestMethod]
    public void NewSale_WhenSubmitSale_SaleLogWillAddedToDiary()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.GoToNewSale().SelectCourseAndGoToPaymentPage().SelectPaymentAndCompleteSale();
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == CustomerPage.DiaryLogType.Sale));
    }

    [TestMethod]
    public void CancelSale()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.GoToNewSale().SelectCourseAndGoToPaymentPage().SelectPaymentAndCompleteSale();
      lead.ClickOnCancelButtonAndGoToCancelSale().CancelSale();
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == CustomerPage.DiaryLogType.SaleCancelled));
    }

    [TestMethod]
    public void ChangeSale()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.GoToNewSale().SelectCourseAndGoToPaymentPage().SelectPaymentAndCompleteSale();
      lead.ChangelSaleAndGoToSalePage().ChangeOptionAndSubmitSale();
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == CustomerPage.DiaryLogType.ChangeaSale));
    }
  }
}
