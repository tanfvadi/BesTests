using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using PageObject3.Pages;

namespace PageObject3.Tests
{
    [TestClass]
    public class GetObjectEmployeeDataTest : BesTestsBase
    {
        [TestMethod]
        public void PrintNamesOfAllEmployees()
        {
            //loop through all employees and write line all names
            var employeesPage = LoginAndGoToHome().GoToEmployeesPage();
            var employees = employeesPage.Employees.Where(a => a.Branch == "All");
            foreach (var emoloyeeRow in employees)
            {
                Console.WriteLine(emoloyeeRow.Name);
            }
        }

        [TestMethod]
        public void EditEmployee()
        {
            //loop through all employees and writeline all names
            var employeesPage = LoginAndGoToHome().GoToEmployeesPage();
            var employee = employeesPage.Employees.First(a => a.Name == "Transfer Naomi");
            employee.Edit();
        }

        [TestMethod]
        public void SelectMessage()
        {
            //loop through all employees and writeline all names
            var employeesPage = LoginAndGoToHome().GoToEmployeesPage();
            var employees = employeesPage.Employees.Where(a => a.Name.Contains("Naomi"));
            foreach (var emoloyeeRow in employees)
            {
                emoloyeeRow.CheckMessage();
            }
        }

        [TestMethod]
        public void CheckRolesFilter()
        {
            var employeesPage = LoginAndGoToHome().GoToEmployeesPage();
            var realTeachersCount = employeesPage.Employees.Count(a => a.Roles.Contains(EmployeeRole.Teacher));
            employeesPage.FilterByRole(EmployeeRole.Teacher);
            var actualCountAfterFilter = employeesPage.Employees.Count;
            Assert.AreEqual(realTeachersCount,actualCountAfterFilter);
        }
    }
}
