using BesTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BesTests.Tests
{
  [TestClass]
  public class CustomerPageTests : BesTestsBase
  {
    [TestMethod]
    public void GoToCustomerPage()
    {
      LoginPage.GoToLoginPage(driver).LoginAndGoToBES("roles.manager", "12345").GoToCustomerPage("455248674");
    }
  }
}
