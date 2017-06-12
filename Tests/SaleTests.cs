using System.Linq;
using BesTests.Pages;
using NUnit.Framework;

namespace BesTests.Tests
{
    [TestFixture]
  public class SaleTests : BesTestsBase
  {
    [Test]
    public void NewSale_WhenSubmitSale_SaleLogWillAddedToDiary()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.GoToNewSale().SelectCourseAndGoToPaymentPage().SelectPaymentAndCompleteSale();
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == CustomerPage.DiaryLogType.Sale));
    }

    [Test]
    public void CancelSale()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.GoToNewSale().SelectCourseAndGoToPaymentPage().SelectPaymentAndCompleteSale();
      lead.ClickOnCancelButtonAndGoToCancelSale().CancelSale();
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == CustomerPage.DiaryLogType.SaleCancelled));
    }

    [Test]
    public void ChangeSale()
    {
      CustomerPage lead = LoginAndCreateLead();
      lead.GoToNewSale().SelectCourseAndGoToPaymentPage().SelectPaymentAndCompleteSale();
      lead.ChangelSaleAndGoToSalePage().ChangeOptionAndSubmitSale();
      Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == CustomerPage.DiaryLogType.ChangeaSale));
    }
  }
}
