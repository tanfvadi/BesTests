using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObject3.Pages;
using System;
using System.Linq;
using static PageObject3.Pages.BasePage;
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
           LoginAndGoToHome().GoToUserRolePage().SelectRoles();

            //UserRolePage role = LoginAndGoToHome().GoToUserRolePage().SelectRoles();
            //Assert.AreEqual(role.UserRole.Equals<UserRolePage>(a => a.UserRole == EmployeeUserRole.Manager));

            //CustomerPage lead = LoginAndCreateLead();
            //lead.GoToNewSale().SelectCourseAndGoToPaymentPage().SelectPaymentAndCompleteSale();
            //Assert.IsTrue(lead.AllLogs.Any<DiaryLog>(a => a.LogType == DiaryLogType.Sale));
    }

    [TestMethod]
    public void GetBranchesFromEmployeesPage()
    {
           LoginAndGoToHome().GoToUserBranchPage().GetBranchesFromEmployeesPage();
    }

    [TestMethod]
    public void GetRowsFromEmployeesPage()
    {
           LoginAndGoToHome().GoToEmployeeRowPage().GetRowsFromEmployeesPage();
    }

    [TestMethod]
    public void TeachersFilter()
    {
        LoginAndGoToHome().GoToEmployeeRowPage().GetRowsFromEmployeesPage();
    }

    //[TestMethod]
    //public void EditEmployee()
    //{
    //        LoginAndGoToHome().GoToClickOnEditEmployeeButton().ClickOnEditEmployeeButton();
    //}
    }
}
