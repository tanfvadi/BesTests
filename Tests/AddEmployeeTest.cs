using NUnit.Framework;

namespace BesTests.Tests
{
    [TestFixture]
    public class AddEmployeeTest : BesTestsBase
    {
        public string chars;

        [Test]
        public void AddEmployee()
        {
             LoginAndGoToHome().GoToEmployeesPage().ClickAdd().FillNewEmployeeAndSave();
            //LoginAndGoToHome().GoToEmployeePage().FillNewEmployeeAndSave("Rami");

        }
    }
}
