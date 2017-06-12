using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BesTests.Tests
{
    [TestClass]
    public class AddEmployeeTest : BesTestsBase
    {
        public string chars;

        [TestMethod]
        public void AddEmployee()
        {
             LoginAndGoToHome().GoToEmployeesPage().ClickAdd().FillNewEmployeeAndSave();
            //LoginAndGoToHome().GoToEmployeePage().FillNewEmployeeAndSave("Rami");

        }
    }
}
