
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObject3.Pages;

namespace PageObject3.Tests
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
