using NUnit.Framework;

namespace BesTests.Tests
{
    [TestFixture]
  public class SubTeacherTests : BesTestsBase
  {
      [Test]
      public void AddSubTeacher()
      {
          LoginAndGoToHome().GoToEmployeesPage().ClickAdd().AddSubTeachers();
      }

      [Test]
      public void DeleteSubTeacher()
      {
          LoginAndGoToHome().GoToEmployeesPage()
              .ClickAdd().DeleteSubTeachers();
      }
  }
}
