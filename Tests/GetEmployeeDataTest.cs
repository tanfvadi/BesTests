using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObject3.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using static PageObject3.Pages.BasePage;
using static PageObject3.Pages.CustomerPage;
using static PageObject3.Pages.UserBranchPage;
using static PageObject3.Pages.UserRolePage;

namespace PageObject3.Tests
{
  [TestClass]
  public class GetEmployeeDataTest : BesTestsBase
  {
    [TestMethod]
    public void EmployeeDataFromHomePage()
    {
      LoginAndGoToHome().GetEmployeeData();
    }
    [TestMethod]
    public void GetNamesFromEmployeesPage()
    {
      LoginAndGoToHome().GoToUserNamePage().GetNamesFromEmployeesPage();

    }

    [TestMethod]
    public void SelectAllMessages()
    {
      LoginAndGoToHome().GoToUserMessagePage().SelectAllMessages();
    }

    [TestMethod]
    public void GetRolesFromEmployeesPage()
    {
       //LoginAndGoToHome().GoToUserRolePage().SelectRoles();
       BesHomePage role = LoginAndGoToHome();
       role.GoToUserRolePage().SelectRoles();
       Assert.IsTrue(role.UserRole.Any<UserRolePage>(a => a.UserRole == EmployeeUserRole.Manager));
    }

    [TestMethod]
    public void GetBranchesFromEmployeesPage()
    {
      //LoginAndGoToHome().GoToUserBranchPage().GetBranchesFromEmployeesPage();
      BesHomePage branch = LoginAndGoToHome();
      branch.GoToUserBranchPage().GetBranchesFromEmployeesPage();
      Assert.IsTrue(branch.UserBranch.Any<UserBranchPage>(a => a.UserBranch == EmployeeUserBranch.PetahTikva));
    }

    [TestMethod]
    public void GetRowsFromEmployeesPage()
    {
      LoginAndGoToHome().GoToEmployeeRowPage().GetRowsFromEmployeesPage();

      //BesHomePage row = LoginAndGoToHome();
      //     row.GoToEmployeeRowPage().GetRowsFromEmployeesPage();
      //Assert.IsTrue(row.UserRole.Any<UserRolePage>(a => a.UserRole==EmployeeUserRole.Teacher));
    }

    [TestMethod]
    public void FirstTeacherRowAndEdit()
    {
      LoginAndGoToHome().GoToEmployeeRowPage().TeacherFilterAndEdit();
    }
  }
}
