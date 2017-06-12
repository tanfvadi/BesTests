using BesTests.Pages;
using NUnit.Framework;

namespace BesTests.Tests
{
    [TestFixture]
  public class CustomerPageTests : BesTestsBase
  {
    [Test]
    public void GoToCustomerPage()
    {
      LoginPage.GoToLoginPage(driver).LoginAndGoToBES("roles.manager", "12345").GoToCustomerPage("455248674");
    }
  }
}
