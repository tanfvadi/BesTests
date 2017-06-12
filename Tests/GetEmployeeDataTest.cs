using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BesTests.Tests
{
  [TestClass]
  public class GetEmployeeDataTest : BesTestsBase
  {
    public object myRow;

    [TestMethod]
    public void EmployeeDataFromHomePage()
    {
      LoginAndGoToHome().GetEmployeeData();
    }

      [TestMethod]
      public void GetNamesFromEmployeesPage()
      {
          List<string> names = new List<string>();
          var emoloyeeRows = LoginAndGoToHome().GoToEmployeesPage().Employees;
          foreach (var emoloyeeRow in emoloyeeRows)
          {
              names.Add(emoloyeeRow.Name);
          }
      }

      [TestMethod]
    public void SelectAllMessages()
    {
      LoginAndGoToHome().GoToEmployeesPage().SelectAllMessages();
    }

    [TestMethod]
    public void GetRolesFromEmployeesPage()
    {
       //LoginAndGoToHome().GoToUserRolePage().SelectRoles();
       //BesHomePage role = LoginAndGoToHome();
       //role.GoToUserRolePage().SelectRoles();
       //Assert.IsTrue(role.UserRole.Any<UserRolePage>(a => a.UserRole == EmployeeRole.Manager));
    }

  }
}
