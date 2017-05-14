
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PageObject3.Tests
{
  [TestClass]
  public class SubTeacherTests : BesTestsBase
  {
    [TestMethod]
    public void AddSubTeacher()
    {
            LoginAndGoToHome().GoToEditEmployeePage().AddSubTeachers();
    }

    [TestMethod]
    public void DeleteSubTeacher()
    {
            LoginAndGoToHome().GoToEditEmployeePage().DeleteSubTeachers();
    }
  }
}
