using System.Collections.Generic;
using NUnit.Framework;

namespace BesTests.Tests
{
    [TestFixture]
  public class GetEmployeeDataTest : BesTestsBase
  {
    public object myRow;

    [Test]
    public void EmployeeDataFromHomePage()
    {
      LoginAndGoToHome().GetEmployeeData();
    }

      [Test]
      public void GetNamesFromEmployeesPage()
      {
          List<string> names = new List<string>();
          var emoloyeeRows = LoginAndGoToHome().GoToEmployeesPage().Employees;
          foreach (var emoloyeeRow in emoloyeeRows)
          {
              names.Add(emoloyeeRow.Name);
          }
      }

      [Test]
    public void SelectAllMessages()
    {
      LoginAndGoToHome().GoToEmployeesPage().SelectAllMessages();
    }

    [Test]
    public void GetRolesFromEmployeesPage()
    {
       //LoginAndGoToHome().GoToUserRolePage().SelectRoles();
       //BesHomePage role = LoginAndGoToHome();
       //role.GoToUserRolePage().SelectRoles();
       //Assert.IsTrue(role.UserRole.Any<UserRolePage>(a => a.UserRole == EmployeeRole.Manager));
    }

  }
}
