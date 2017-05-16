using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject3.Tests
{
    [TestClass]
    public class AddEmployeeTest : BesTestsBase
    {
        public string chars;

        [TestMethod]
        public void AddEmployee()
        {
           // LoginAndGoToHome().GoToEmployeePage().FillNewEmployeeAndSave();
            LoginAndGoToHome().GoToEmployeePage().FillNewEmployeeAndSave("Rami");

        }
    }
}
