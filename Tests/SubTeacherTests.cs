
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BesTests.Tests
{
  [TestClass]
  public class SubTeacherTests : BesTestsBase
  {
      [TestMethod]
      public void AddSubTeacher()
      {
          LoginAndGoToHome().GoToEmployeesPage().ClickAdd().AddSubTeachers();
      }

      [TestMethod]
      public void DeleteSubTeacher()
      {
          LoginAndGoToHome().GoToEmployeesPage()
              .ClickAdd().DeleteSubTeachers();
      }
  }
}
