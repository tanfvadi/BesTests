using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObject3.Pages;

namespace PageObject3.Tests
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
      LoginAndGoToHome().GoToEmployeesPage().;
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
